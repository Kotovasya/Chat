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

        private readonly AuthWindow authWindow;
        private readonly ClientModel model;
        private readonly SourceList<int, Dialog.DialogPreview> favouriteDialogs;
        private readonly CreateDialogControl createDialogControl;
        private readonly SettingsControl settingsControl;
        private readonly DialogsControl dialogsControl;

        private Point MouseDownLocation;

        public MainWindow(AuthWindow authWindow, ClientModel model)
        {
            this.authWindow = authWindow;
            this.model = model;
            InitializeComponent();
            favouriteDialogs = new SourceList<int, Dialog.DialogPreview>();
            settingsControl = new SettingsControl(model);
            dialogsControl = new DialogsControl(model);
            createDialogControl = new CreateDialogControl(model);
            dialogsControl.DialogOpen += DialogOpen_Click;
            createDialogControl.DialogCreate += DialogOpen_Click;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Disconnect(model.Id);
        }

        #region Menu Buttons Events
        private void DialogsButton_Click(object sender, EventArgs e)
        {
            SetControl(dialogsControl);
        }

        private void DialogOpen_Click(object sender, Dialog openedDialog)
        {
            openedDialog.Control.Model = model;
            SetControl(openedDialog.Control);
        }

        private void CreateDialogButton_Click(object sender, EventArgs e)
        {
            SetControl(createDialogControl);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SetControl(settingsControl);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            model.Id = model.LogOut(model.Id);
            authWindow.Show();
            Close();
        }
        #endregion

        private void SetControl(Control control)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        #region Top Panel Events

        private void closeImage_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void restoreImage_Click(object sender, EventArgs e)
        {
            restoreImage.Image = WindowState == FormWindowState.Normal ? Resources.full_window : Resources.restore_window;
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
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
