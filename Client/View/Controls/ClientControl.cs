using Client.Extensions;
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
            userNameLabel.CreateBinding("Text", user, "Name");
            onlinePicture.CreateBinding("Image", user, "Online", ConvertOnlineToPicture);
        }

        private void ConvertOnlineToPicture(object sender, ConvertEventArgs e)
        {
            bool isOnline = (bool)e.Value;
            e.Value = isOnline ? Resources.online : Resources.offline;
        }
    }
}
