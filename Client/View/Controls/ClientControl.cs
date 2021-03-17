using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.Controls
{
    public partial class ClientControl : UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
        }

        public ClientControl(Entities.User user)
            : this()
        {
            userNameLabel.Text = user.Name;
            userNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", user, "Name"));
        }
    }
}
