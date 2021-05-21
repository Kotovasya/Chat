using Client.Entities;
using Client.Extensions;
using Client.Model;
using Client.Properties;
using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.Controls
{
    public partial class DialogControl : UserControl
    {
        private static readonly Pen borderPen = new Pen(Color.FromArgb(122, 122, 122), 2);

        private bool cancelEnter;

        private Graphics g;
        private ClientModel model;
        private Entities.Message EditableMessage;
        private SortedList<long, MessageControl> MessageControls;
        private List<MessageControl> SelectedMessages;

        public ClientModel Model
        {
            get { return model; }
            set
            {
                model = value;
                dialogSettingImage.Visible = Dialog.OwnerId == model.Id;
            }
        }

        public Dialog Dialog { get; private set; }

        public DialogControl(Dialog dialog)
            : this(dialog, null)
        {
            
        }

        public DialogControl(Dialog dialog, ClientModel model)
        {
            InitializeComponent();
            Dialog = dialog;
            Model = model;

            MessageControls = new SortedList<long, MessageControl>();
            SelectedMessages = new List<MessageControl>();

            dialogNameLabel.CreateBinding("Text", dialog, "Name");

            dialog.Messages.ControlAdding += messagesContainer_MessageAdded;
            dialog.Messages.Collection = messagesContainer.Controls;

            dialog.Users.ControlAdding += usersContainer_UserAdded;
            dialog.Users.Collection = usersContainer.Controls;

            messageTextbox.BorderStyle = BorderStyle.None;
            messageTextbox.Size = new Size(657, 25);
        }

        #region Messages Container Events

        private void messagesContainer_MessageAdded(object sender, Entities.Message message)
        {
            MessageControls.Add(message.Id, message.Control);
            int newMessageIndex = MessageControls.IndexOfKey(message.Id);
            for (int i = newMessageIndex; i < MessageControls.Count; i++)
            {
                if (i - 1 != -1)
                {
                    var control = MessageControls.ElementAt(i).Value;
                    var prevControl = MessageControls.ElementAt(i - 1).Value;
                    var newPoint = new Point(control.Location.X, prevControl.Location.Y + prevControl.Height + 2);
                    if (control.Location != newPoint)
                    {
                        if (control.InvokeRequired)
                            control.BeginInvoke((Action)delegate { control.Location = newPoint; });
                        else
                            control.Location = newPoint;
                    }
                }
            }       
            message.Control.IsClientAuthor = message.Control.Message.Author.Id == model.Id;
            message.Control.MessageSelected += OnSelectMessage;
            message.Control.TextEdited += messageContainer_ControlSizeChanged;
            message.Control.EditMessage += OnEditMessage;
            message.Control.RemoveMessage += OnRemoveMessage;
        }

        private void messageContainer_ControlSizeChanged(object sender, MessageControl e)
        {
            Control lastControl = e;
            int index = messagesContainer.Controls.IndexOf(lastControl);
            for (int i = ++index; i < messagesContainer.Controls.Count; i++)
            {
                var control = messagesContainer.Controls[i];
                control.Location = new Point(control.Location.X, lastControl.Location.Y + lastControl.Height + 2);
                lastControl = control;
            }
        }

        private void OnEditMessage(object sender, MessageControl control)
        {
            editMessageLabel.Visible = true;
            cancelEditMessageLabel.Visible = true;
            buttomPanelImage.Image = Resources.edit;
            messageTextbox.Text = control.Message.Text;
            EditableMessage = control.Message;
        }

        private void OnRemoveMessage(object sender, MessageControl control)
        {
            var response = model.RemoveMessage(new RemoveMessageRequest()
            {
                Id = model.Id,
                DialogId = Dialog.Id,
                MessagesIds = new[] { control.Message.Id }
            });
            if (response.Result == Result.Succesfully)
            {
                Dialog.Messages.Remove(control.Message.Id);
                SelectedMessages.Remove(control);
                MessageControls.Remove(control.Message.Id);
                control.Dispose();
            }     
        }

        private void OnSelectMessage(object sender, MessageControl control)
        {
            if (control.IsSelected)
            {
                SelectedMessages.Add(control);
                control.IsButtonsVisible = true;
            }
            else
            {
                SelectedMessages.Remove(control);
                control.IsButtonsVisible = false;
            }
            if (SelectedMessages.Count > 1)
            {
                SelectedMessages.ForEach(m => m.IsButtonsVisible = false);
                removeSelectedMessagesButton.Visible = true;
            }
            else
            {
                SelectedMessages.ForEach(m => m.IsButtonsVisible = true);
                removeSelectedMessagesButton.Visible = false;
                
            }
        }

        private void messagesContainer_Scroll(object sender, ScrollEventArgs e)
        {
            if (!Dialog.AllMessagesLoad && e.NewValue == messagesContainer.VerticalScroll.Minimum)
            {
                long? id;
                if (MessageControls.Count == 0)
                    id = null;
                else
                    id = MessageControls.Values.First().Message.Id;

                var response = model.LoadMessages(new LoadMessagesRequest()
                {
                    Id = model.Id,
                    DialogId = Dialog.Id,
                    LastMessageId = id
                });
                if (response.Result == Result.Succesfully)
                    Dialog.LoadMessages(response);
            }
        }

        private void removeSelectedMessagesButton_Click(object sender, EventArgs e)
        {
            var response = model.RemoveMessage(new RemoveMessageRequest()
            {
                Id = model.Id,
                DialogId = Dialog.Id,
                MessagesIds = SelectedMessages.Select(m => m.Message.Id).ToArray()
            });
            if (response.Result == Result.Succesfully)
            {
                foreach (var messageControl in SelectedMessages)
                {
                    Dialog.Messages.Remove(messageControl.Message.Id);
                    MessageControls.Remove(messageControl.Message.Id);
                }
                SelectedMessages.Clear();
                removeSelectedMessagesButton.Visible = false;
            }
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            var text = searchTextbox.Text;
            var result = Dialog.Messages.Values
                .Where(m => m.Author.Name.Contains(text) || m.Text.Contains(text))
                .OrderBy(m => m.Id)
                .Select(m => m.Control);
            foreach (var control in MessageControls.Values)
                control.Visible = false;
            Control prevControl = null;

            foreach (var control in result)
            {
                control.Visible = true;
                if (prevControl == null)
                    control.Location = new Point(0, 0);
                else
                    control.Location = new Point(control.Location.X, prevControl.Location.Y + prevControl.Height + 2);
                prevControl = control;
            }
        }
        #endregion

        #region Users Container Events

        private void usersCountLabel_Click(object sender, EventArgs e)
        {
            usersContainer.Visible = !usersContainer.Visible;
            if (!messagesContainer.Controls.Contains(usersContainer))
                messagesContainer.Controls.Add(usersContainer);   
            usersContainer.BringToFront();
        }

        private void usersContainer_UserAdded(object sender, User user)
        {
            var lastControl = Dialog.Users.Last()?.Control;
            if (lastControl != null)
                user.Control.Location = new Point(user.Control.Location.X, lastControl.Location.Y + lastControl.Height + 2);
        }

        #endregion

        #region Bottom Panel Events 

        private void messageTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                cancelEnter = true;
                buttomPanelImage_Click(this, new EventArgs());
            }
        }

        private void cancelEditMessageLabel_Click(object sender, EventArgs e)
        {
            editMessageLabel.Visible = false;
            cancelEditMessageLabel.Visible = false;
            messageTextbox.Text = string.Empty;
            buttomPanelImage.Image = Resources.send;
            EditableMessage = null;
        }

        private void buttomPanelImage_Click(object sender, EventArgs e)
        {
            if (EditableMessage != null)
            {
                var response = model.EditMessage(new EditMessageRequest()
                {
                    Id = model.Id,
                    DialogId = Dialog.Id,
                    MessageId = EditableMessage.Id,
                    NewText = messageTextbox.Text
                });
                if (response.Result == Result.Succesfully)
                {
                    EditableMessage.Text = messageTextbox.Text;
                    cancelEditMessageLabel_Click(this, new EventArgs());
                    EditableMessage.Control.MessageControl_Click(this, new EventArgs());
                }
                else
                {
                    buttomWarningLabel.Text = "Не удалось отредактировать сообщение";
                    buttomWarningLabel.Visible = true;
                }
            }
            else
            {
                var response = model.SendMessage(new SendMessageRequest()
                {
                    Id = model.Id,
                    DialogId = Dialog.Id,
                    Text = messageTextbox.Text
                });

                if (response.Result == Result.Succesfully)
                {
                    Dialog.Messages.Add(response.MessageId,
                        new Entities.Message(response.MessageId, Dialog.Id, messageTextbox.Text, model.Users[model.Id], DateTime.UtcNow));
                    messageTextbox.Text = string.Empty;                   
                }
                else
                {
                    buttomWarningLabel.Text = "Не удалось отправить сообщение";
                    buttomWarningLabel.Visible = true;
                }
            }
        }

        private void messageTextbox_Click(object sender, EventArgs e)
        {
            buttomWarningLabel.Visible = false;
        }
        #endregion

        #region Settings Panel Events

        private void saveSettiingsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text) && string.IsNullOrWhiteSpace(passwordTextbox.Text))
                return;

            string name = nameTextbox.Text != string.Empty ? nameTextbox.Text : null;
            Response response = model.ChangeDialog(new ChangeDialogRequest() 
            { 
                Id = model.Id,
                DialogId = Dialog.Id,
                NewName = name,
                NewPassword = passwordTextbox.Text != string.Empty ? passwordTextbox.Text : null
            });
            if (response.Result == Result.DialogNameAlreadyTaken)
                warningLabel.Text = "Данное имя уже занято";
            if (response.Result == Result.NotPremissions)
                warningLabel.Text = "Изменение настроек диалога доступно только его создателю";
            if (response.Result == Result.InvalidName)
                warningLabel.Text = "Длина имени не должна первышать 30 символов";
            if (response.Result == Result.Succesfully)
            {
                Dialog.Name = name ?? Dialog.Name;
                new Thread(new ThreadStart(() =>
                {
                    SetVisible(settingsSuccesfullyChangedLabel, true);
                    Thread.Sleep(1500);
                    SetVisible(settingsSuccesfullyChangedLabel, false);
                })).Start();
            }
            else
                warningLabel.Visible = true;
        }

        private void dialogSettingImage_Click(object sender, EventArgs e)
        {
            dialogSettingsPanel.Visible = !dialogSettingsPanel.Visible;
            if (!messagesContainer.Controls.Contains(dialogSettingsPanel))
                messagesContainer.Controls.Add(dialogSettingsPanel);
            dialogSettingsPanel.BringToFront();
        }

        #endregion

        #region View Events
        private void buttomPanelImage_MouseEnter(object sender, EventArgs e)
        {
            buttomPanelImage.Size = new Size(34, 34);
        }

        private void buttomPanelImage_MouseLeave(object sender, EventArgs e)
        {
            buttomPanelImage.Size = new Size(32, 32);
        }

        private void usersCountLabel_MouseEnter(object sender, EventArgs e)
        {
            usersCountLabel.Font = new Font("Segoe UI", 13);
        }

        private void usersCountLabel_MouseLeave(object sender, EventArgs e)
        {
            usersCountLabel.Font = new Font("Segoe UI", 12);
        }

        private void dialogSettingImage_MouseEnter(object sender, EventArgs e)
        {
            dialogSettingImage.Size = new Size(50, 50);
        }

        private void dialogSettingImage_MouseLeave(object sender, EventArgs e)
        {
            dialogSettingImage.Size = new Size(48, 48);
        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(borderPen, new Rectangle(messageTextbox.Location, messageTextbox.Size));
        }

        private void messageTextbox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            if (messageTextbox.Height < 100)
            {
                messageTextbox.Height = e.NewRectangle.Height + 8;
                bottomPanel.Height = messageTextbox.Height + 50;

                g = bottomPanel.CreateGraphics();
                g.Clear(bottomPanel.BackColor);
                g.DrawRectangle(borderPen, new Rectangle(messageTextbox.Location, messageTextbox.Size));
            }
        }

        private void cancelEditMessageLabel_MouseEnter(object sender, EventArgs e)
        {
            cancelEditMessageLabel.ForeColor = Color.Blue;
        }

        private void cancelEditMessageLabel_MouseLeave(object sender, EventArgs e)
        {
            cancelEditMessageLabel.ForeColor = Color.FromKnownColor(KnownColor.Highlight);
        }

        private void settingsInput_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }

        #endregion

        private void messageTextbox_TextChanged(object sender, EventArgs e)
        {
            if (cancelEnter && messageTextbox.Text == "\n")
            {
                cancelEnter = false;
                messageTextbox.Text = string.Empty;
            }
        }

        private void SetVisible(Control control, bool visible)
        {
            if (control.InvokeRequired)
                control.BeginInvoke(new Action(delegate { control.Visible = visible; }));
            else
                control.Visible = visible;
        }
    }
}
