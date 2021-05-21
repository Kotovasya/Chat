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
            lastActivityLabel.CreateBinding("Visible", user, "Online", (sender, e) =>
            {
                e.Value = !(bool)e.Value;
            });
            lastActivityLabel.CreateBinding("Text", user, "LastActivity", (sender, e) =>
            {
                if (e.Value != null)
                {
                    var localTime = ((DateTime)e.Value).ToLocalTime();
                    if (localTime.Day == DateTime.Now.Day)
                        e.Value = localTime.ToString("HH:mm:ss");
                    else if (localTime.AddDays(1).Day == DateTime.Now.Day)
                        e.Value = "Вчера " + localTime.ToString("HH:ss");
                    else
                        e.Value = localTime.ToString("dd.MM.yyyy");
                    e.Value = "Последний раз в сети: " + e.Value;
                }
                else
                    e.Value = string.Empty;
            });
        }

        private void ConvertOnlineToPicture(object sender, ConvertEventArgs e)
        {
            bool isOnline = (bool)e.Value;
            e.Value = isOnline ? Resources.online : Resources.offline;
        }
    }
}
