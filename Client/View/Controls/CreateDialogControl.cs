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
using Client.Entities;

namespace Client.View.Controls
{
    public partial class CreateDialogControl : UserControl
    {
        private readonly ClientModel model;

        public EventHandler<Dialog> DialogCreate;

        public CreateDialogControl(ClientModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void Input_Clicked(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }

        private void createDialogButton_Click(object sender, EventArgs e)
        {
            CreateDialogResponse response = model.CreateDialog(new CreateDialogRequest() 
            { 
                Id = model.Id, 
                Name = dialogNameLabel.Text, 
                Password = passwordLabel.Text 
            });
            if (response.Result == Result.Succesfully)
            {
                var dialog = new Dialog(response.Dialog);
                model.Dialogs.Add(response.Dialog.Id, dialog);
                DialogCreate?.Invoke(this, dialog);
            }
            if (response.Result == Result.DialogNameAlreadyTaken)
            {
                warningLabel.Text = "Данное имя уже занято";
                warningLabel.Visible = true;               
            }
        }
    }
}
