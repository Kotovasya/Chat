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
using Client.Properties;
using Client.Entities;

namespace Client.View
{
    public partial class MainWindow : Form
    {
        private static readonly ButtonControl dialogsButton = new ButtonControl(Resources.dialogs, "Все диалоги");
        private static readonly ButtonControl createDialogButton = new ButtonControl(Resources.create_dialog, "Создать диалог");
        private static readonly ButtonControl settingsButton = new ButtonControl(Resources.settings, "Настройки");
        private static readonly ButtonControl logoutButton = new ButtonControl(Resources.logout, "Выйти");

        private readonly AuthWindow authWindow;
        private readonly ClientModel model;
        private readonly SourceList<int, Dialog.DialogPreview> favouriteDialogs;

        private Point MouseDownLocation;

        public MainWindow()
        {
            InitializeComponent();
            favouriteDialogs = new SourceList<int, Dialog.DialogPreview>();
            dialogsButton.Click += DialogsButton_Click;
            createDialogButton.Click += CreateDialogButton_Click;
            settingsButton.Click += SettingsButton_Click;
            logoutButton.Click += LogoutButton_Click;
        }

        public MainWindow(AuthWindow authWindow, ClientModel model)
        {
            this.authWindow = authWindow;
            this.model = model;
            InitializeComponent();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Disconnect(model.Id);
        }

        #region Menu Buttons Events
        private void DialogsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CreateDialogButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            model.Id = model.LogOut(model.Id);
            authWindow.Show();
            Close();
        }
        #endregion

        #region Top Panel Events

        private void closeImage_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void restoreImage_Click(object sender, EventArgs e)
        {
            restoreImage.Image = restoreImage.Image == Resources.restore_window ? Resources.full_window : Resources.restore_window;
            WindowState = restoreImage.Image == Resources.restore_window ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void minimizeImage_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - MouseDownLocation.X;
                Top += e.Y - MouseDownLocation.Y;
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void topPanelImage_MouseMove(object sender, MouseEventArgs e)
        {
            var control = (Control)sender;
            control.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
        }

        private void topPanelImage_MouseEnter(object sender, EventArgs e)
        {
            var control = (Control)sender;
            control.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
        }

        private void topPanelImage_MouseLeave(object sender, EventArgs e)
        {
            var control = (Control)sender;
            control.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
        }

        #endregion
    }
}
