using Client.Entities;
using Client.Extensions;
using Client.Model;
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
        private static readonly Pen borderPen = new Pen(Color.FromArgb(122, 122, 122), 2);

        public ClientModel Model { get; set; }

        public Dialog Dialog { get; private set; }

        public DialogControl(Dialog dialog)
        {
            Dialog = dialog;

            dialog.Messages.Collection = messagesContainer.Controls;
            dialog.Messages.ControlRemoving += messageContainer_ControlRemoving;
            dialog.Messages.ControlSizeChanged += messageContainer_ControlSizeChanged;

            messageTextbox.BorderStyle = BorderStyle.None;
        }

        #region Messages Container Events

        private void messagesContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            var lastControl = Dialog.Messages.Last()?.Control;
            if (lastControl != null)
                e.Control.Location = new Point(e.Control.Location.X, lastControl.Location.Y + lastControl.Height + 2);
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

                var response = Model.SendMessage(new SendMessageRequest() { Id = Model.Id, Text = messageTextbox.Text });
                if (response.Result == Result.Succesfully)
                {
                    Dialog.Messages.Add(response.MessageId, new Entities.Message(response.MessageId, Dialog.Id, messageTextbox.Text, Model.Users[Model.Id], DateTime.UtcNow));
                }
            }
        }
        #endregion
    }
}
