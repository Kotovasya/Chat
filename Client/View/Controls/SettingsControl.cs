using Client.Model;
using Client.Properties;
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

namespace Client.View.Controls
{
    public partial class SettingsControl : UserControl
    {
        
        private readonly ClientModel model;

        public SettingsControl()
        {
            InitializeComponent();
        }

        public SettingsControl(ClientModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            var response = model.ChangePassword(new ChangePasswordRequest() 
            { 
                Id = model.Id, 
                OldPassword = oldPasswordTextbox.Text, 
                NewPassword = newPasswordTextbox.Text 
            });
            if (response.Result == Result.Succesfully)
            {
                oldPasswordTextbox.Text = string.Empty;
                newPasswordTextbox.Text = string.Empty;
            }

            else if (response.Result == Result.WrongPassword)
            {
                oldPasswordLabel.Text = "Неверный пароль";
                oldPasswordLabel.ForeColor = Color.Red;
            }
        }

        private void ChangeUsername_Click(object sender, EventArgs e)
        {
            var response = model.ChangeUsername(new ChangeUsernameRequest()
            {
                Id = model.Id,
                NewName = changeUsernameTextbox.Text,
            });
            if (response.Result == Result.Succesfully)
            {
                model.Name = changeUsernameTextbox.Text;
                changeUsernameTextbox.Text = string.Empty;
            }

            else if (response.Result == Result.AlreadyRegister)
            {
                changeUsernameLabel.Text = "Данное имя уже занято";
                changeUsernameLabel.ForeColor = Color.Red;
            }
        }

        private void oldPasswordTextbox_Click(object sender, EventArgs e)
        {
            oldPasswordLabel.Text = "Введите старый пароль";
            oldPasswordLabel.ForeColor = Color.Black;
        }

        private void changeUsernameTextbox_Click(object sender, EventArgs e)
        {
            changeUsernameLabel.Text = "Введите новое имя";
            changeUsernameLabel.ForeColor = Color.Black;
        }
    }
}
