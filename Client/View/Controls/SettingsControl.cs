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
using System.Threading;

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
                new Thread(new ThreadStart(() =>
                {
                    SetVisible(passwordSuccesfullyChangedLabel, true);
                    Thread.Sleep(1500);
                    SetVisible(passwordSuccesfullyChangedLabel, false);
                })).Start();
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
                model.Users[model.Id].Name = changeUsernameTextbox.Text;
                changeUsernameTextbox.Text = string.Empty;
                new Thread(new ThreadStart(() =>
                {
                    SetVisible(nameSuccesfullyChangedLabel, true);
                    Thread.Sleep(1500);
                    SetVisible(nameSuccesfullyChangedLabel, false);
                })).Start();
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

        private void SetVisible(Control control, bool visible)
        {
            if (control.InvokeRequired)
                control.BeginInvoke(new Action(delegate { control.Visible = visible; }));
            else
                control.Visible = visible;
        }
    }
}
