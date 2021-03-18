using Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference;
using Client.Binding;
using Client.View.Controls;
using Client.Extensions;

namespace Client.View
{
    public partial class MainWindow : Form
    {
        private readonly AuthWindow authWindow;
        private readonly ClientModel model;

        public MainWindow(AuthWindow authWindow, ClientModel model)
        {
            this.authWindow = authWindow;
            this.model = model;
            InitializeComponent();

            model.Messages.Collection = messagesContainer.Controls;
            model.Messages.ControlRemoving += messageContainer_ControlRemoving;
            model.Messages.ControlSizeChanged += messageContainer_ControlSizeChanged;

            model.Users.Collection = usersContainer.Controls;
            model.Users.ControlRemoving += usersContainer_ControlRemoving;
        }

        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                var response = model.SendMessage(new SendMessageRequest() { Id = model.Id, Text = messageBox.Text });
                if (response.Result == Result.Succesfully)
                {
                    model.Messages.Add(response.MessageId, new Entities.Message(response.MessageId, messageBox.Text, model.Users[model.Id]));
                }
            }
        }

        #region Messages Container Events

        private void messagesContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            int x = e.Control.Location.X;
            var control = (MessageControl)e.Control;
            if (control.Message.Author.Id == model.Id)
            {
                control.BackColor = Color.Aqua;
                x = messagesContainer.Width - control.Width;
            }

            var lastControl = model.Messages.Last()?.Control;
            if (lastControl != null)
                e.Control.Location = new Point(x, lastControl.Location.Y + lastControl.Height + 2);
        }

        private void messageContainer_ControlRemoving(object sender, ControlEventArgs e)
        {
            messagesContainer.Controls.ControlRemove(e.Control);
        }

        private void messageContainer_ControlSizeChanged(object sender, ControlEventArgs e)
        {
            MessageControl editedControl = (MessageControl)e.Control;
            if (editedControl.Message.Author.Id == model.Id)
                editedControl.Location = new Point(messagesContainer.Width - editedControl.Width, editedControl.Location.Y);

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

        #region Users Container Events

        private void usersContainer_ControlRemoving(object sender, ControlEventArgs e)
        {
            usersContainer.Controls.ControlRemove(e.Control);
        }

        #endregion

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Disconnect(model.Id);
        }
    }
}
