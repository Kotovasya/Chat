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
            userNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", user, "Name"));

            System.Windows.Forms.Binding binding = new System.Windows.Forms.Binding("Image", user, "Online");
            binding.Format += ConvertOnlineToPicture;
            onlinePicture.DataBindings.Add(binding);
        }

        private void ConvertOnlineToPicture(object sender, ConvertEventArgs e)
        {
            bool isOnline = (bool)e.Value;
            e.Value = isOnline ? Resources.online : Resources.offline;
        }
    }
}
