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

namespace Client.View
{
    public partial class AuthWindow : Form
    {
        private bool isAuth = true;
        private readonly ClientModel model;

        public AuthWindow(ClientModel model)
        {
            this.model = model;
            InitializeComponent();
        }

        #region Label Events

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.DarkBlue;
        }

        private void Label_MouseClick(object sender, MouseEventArgs e)
        {
            isAuth = !isAuth;
            authLabel.ForeColor = isAuth ? Color.RoyalBlue : Color.Black;
            registrationLabel.ForeColor = isAuth ? Color.Black : Color.RoyalBlue;
            button.Text = isAuth ? "Войти" : "Зарегистрироваться";
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            authLabel.ForeColor = isAuth ? Color.RoyalBlue : Color.Black;
            registrationLabel.ForeColor = isAuth ? Color.Black : Color.RoyalBlue;
        }

        #endregion

        private void Button_Click(object sender, EventArgs e)
        {
            var request = new AuthRequest() { Id = model.Id, Login = loginTextbox.Text, Password = passwordTextbox.Text };
            var response = isAuth ? model.Authorization(request) : model.Registration(request);

            if (response.Result == Result.Succesfully)
            {
                model.Id = response.Id;
                model.Name = loginTextbox.Text;
                model.Users.Add(model.Id, new Entities.User(model.Id, model.Name, true));
                var mainWindow = new MainWindow(this, model);
                mainWindow.Show();
                Hide();
            }
        }

        private void AuthWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            model.Disconnect(model.Id);
        }
    }
}
