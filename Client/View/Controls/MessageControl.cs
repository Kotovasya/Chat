using Client.Binding;
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
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        public MessageControl(Entities.Message message)
            : this()
        {
            textLabel.Text = message.Text;
            this.Size = new Size(textLabel.Width + 70, textLabel.Height + 15);
        }

        private void textLabel_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(textLabel.Width + 70, textLabel.Height + 15);
        }
    }
}
