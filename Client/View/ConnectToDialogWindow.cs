using Client.Entities;
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

namespace Client.View
{
    public partial class ConnectToDialogWindow : Form
    {
        private readonly ClientModel model;

        public EventHandler<Dialog> ConnectedToDialog;

        public ConnectToDialogWindow(ClientModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectToDialogButton_Click(object sender, EventArgs e)
        {
            var response = model.ConnectToDialog(new ConnectToDialogRequest() 
            { 
                Id = model.Id, 
                Name = nameTextbox.Text, 
                Password = passwordTextbox.Text 
            });
            if (response.Result == Result.Succesfully)
            {
                Dialog dialog = new Dialog(response.DialogInfo);
                model.Dialogs.Add(dialog.Id, dialog);
                ConnectedToDialog?.Invoke(this, dialog);
                this.Close();
            }
            else if (response.Result == Result.WrongLogin)
            {
                warningLabel.Visible = true;
                warningLabel.Text = "Неверное название диалога";
            }
            else if (response.Result == Result.WrongPassword)
            {
                warningLabel.Visible = true;
                warningLabel.Text = "Неверный пароль";
            }
        }

        private void Input_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }
    }
}
