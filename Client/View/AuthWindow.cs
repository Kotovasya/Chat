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
        private ClientModel model;

        private Point MouseDownLocation;

        public AuthWindow(ClientModel model)
        {
            InitializeComponent();
            if (model.Id == Guid.Empty)
                warningLabel.Visible = true;
            this.model = model;
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
            if (model.Id == Guid.Empty)
            {
                warningLabel.Visible = true;
                warningLabel.Text = "Попытка подключения к серверу...";
                model = new ClientModel();
                if (model.Id == Guid.Empty)
                {
                    warningLabel.Text = "Сервер в данный момент не доступен";
                    return;
                }
            }

            var request = new AuthRequest() { Id = model.Id, Login = loginTextbox.Text, Password = passwordTextbox.Text };
            var response = isAuth ? model.Authorization(request) : model.Registration(request);

            if (response.Result == Result.Succesfully)
            {
                model.Id = response.Id;
                model.Name = loginTextbox.Text;
                model.Users.Add(model.Id, new Entities.User(model.Id, model.Name, true, DateTime.UtcNow));
                var mainWindow = new MainWindow(this, model);
                mainWindow.Show();
                Hide();
            }
            else
            {
                warningLabel.Visible = true;
                if (response.Result == Result.WrongLogin)
                    warningLabel.Text = "Неверный логин";
                else if (response.Result == Result.WrongPassword)
                    warningLabel.Text = "Неверный пароль";
                else if (response.Result == Result.AlreadyLogged)
                    warningLabel.Text = "Данный пользователь уже авторизован";
                else if (response.Result == Result.InvalidName)
                    warningLabel.Text = "Длина имени должна быть от 3 до 30 не пробельных символов";
                else if (response.Result == Result.InvalidPassword)
                    warningLabel.Text = "Пароль должен содержать минимум 3 непробельных символа";
                else
                {
                    model.Id = Guid.Empty;
                    warningLabel.Text = "На сервере произошла ошибка";
                }
            }
        }

        private void AuthWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
                if (model.State != System.ServiceModel.CommunicationState.Opened && model.Id != Guid.Empty)
                    model.Disconnect(model.Id);
        }

        private void input_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;
        }

        private void closeImage_Click(object sender, EventArgs e)
        {     
            Application.Exit();
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }
    }
}
