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

            model.Users.Collection = usersContainer.Controls;
            model.Users.ControlRemoving += usersContainer_ControlRemoving;
        }

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
