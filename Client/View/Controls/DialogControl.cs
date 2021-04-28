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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.Controls
{
    public partial class DialogControl : UserControl
    {
        private Graphics g;
        private ClientModel model;
        private static readonly Pen borderPen = new Pen(Color.FromArgb(122, 122, 122), 2);
        private Entities.Message EditableMessage;

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
        {
            InitializeComponent();
            Dialog = dialog;

            dialogNameLabel.CreateBinding("Text", dialog, "Name");
            usersCountLabel.CreateBinding("Text", dialog, "UsersCount", (sender, e) => e.Value = "Количество участников: " + e.Value);

            dialog.Messages.Collection = messagesContainer.Controls;
            dialog.Messages.ControlRemoving += messageContainer_ControlRemoving;
            dialog.Messages.ControlSizeChanged += messageContainer_ControlSizeChanged;

            dialog.Users.Collection = usersContainer.Controls;
            dialog.Users.ControlRemoving += usersContainer_ControlRemoving;

            messageTextbox.BorderStyle = BorderStyle.None;
        }

        #region Messages Container Events

        private void messagesContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            var lastControl = Dialog.Messages.Last()?.Control;
            if (lastControl != null)
                e.Control.Location = new Point(e.Control.Location.X, lastControl.Location.Y + lastControl.Height + 2);

            var control = (MessageControl)e.Control;
            control.IsClientAuthor = control.Message.Author.Id == model.Id;
            control.EditMessage += editMessage;
            control.RemoveMessage += removeMessage;
        }

        private void messageContainer_ControlRemoving(object sender, ControlEventArgs e)
        {
            messagesContainer.Controls.ControlRemove(e.Control);
        }

        private void messageContainer_ControlSizeChanged(object sender, ControlEventArgs e)
        {
            Control lastControl = e.Control;
            int index = messagesContainer.Controls.IndexOf(e.Control);
            for (int i = ++index; i < messagesContainer.Controls.Count; i++)
            {
                var control = messagesContainer.Controls[i];
                control.Location = new Point(control.Location.X, lastControl.Location.Y + lastControl.Height + 2);
                lastControl = control;
            }
        }

        private void editMessage(object sender, MessageControl control)
        {
            editMessageLabel.Visible = true;
            cancelEditMessageLabel.Visible = true;
            buttomPanelImage.Image = Resources.edit;
            messageTextbox.Text = control.Message.Text;
            EditableMessage = control.Message;
        }

        private void removeMessage(object sender, MessageControl control)
        {
            var response = model.RemoveMessage(new RemoveMessageRequest()
            {
                Id = model.Id,
                DialogId = Dialog.Id,
                MessageId = control.Message.Id
            });
            if (response.Result == Result.Succesfully)
            {
                Dialog.Messages.Remove(control.Message.Id);
            }
        }

        #endregion

        #region Users Container Events

        private void usersCountLabel_Click(object sender, EventArgs e)
        {
            usersContainer.Visible = !usersContainer.Visible;
        }

        private void usersContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            var lastControl = Dialog.Users.Last()?.Control;
            if (lastControl != null)
                e.Control.Location = new Point(e.Control.Location.X, lastControl.Location.Y + lastControl.Height + 2);
        }

        private void usersContainer_ControlRemoving(object sender, ControlEventArgs e)
        {
            usersContainer.Controls.ControlRemove(e.Control);
        }

        #endregion

        #region Bottom Panel Events

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

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {
            if (g == null)
                e.Graphics.DrawRectangle(borderPen, new Rectangle(messageTextbox.Location, messageTextbox.Size));
        }

        private void messageTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                buttomPanelImage_Click(this, new EventArgs());
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
                    messageTextbox.Text = string.Empty;
                    Dialog.Messages.Add(response.MessageId,
                        new Entities.Message(response.MessageId, Dialog.Id, messageTextbox.Text, model.Users[model.Id], DateTime.UtcNow));
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

        private void settingsInput_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }

        private void saveSettiingsButton_Click(object sender, EventArgs e)
        {
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
                Dialog.Name = name ?? Dialog.Name;
            else
                warningLabel.Visible = true;
        }

        private void dialogSettingImage_Click(object sender, EventArgs e)
        {
            dialogSettingsPanel.Visible = !dialogSettingsPanel.Visible;
        }

        #endregion      
    }
}
