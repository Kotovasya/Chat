using Client.Binding;
using Client.Extensions;
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
        public Entities.Message Message { get; private set; }
        public bool IsSelected { get; set; }


        public MessageControl()
        {
            InitializeComponent();
        }

        public MessageControl(Entities.Message message)
            : this()
        {
            Message = message;

            textLabel.CreateBinding("Text", message, "Text");
            authorLabel.CreateBinding("Text", message.Author, "Name");
            dateLabel.CreateBinding("Text", message, "Date", ConvertDateToString);

            this.Size = new Size(this.Width, textLabel.Height + 35);
            this.Dock = DockStyle.Top;
        }

        private void textLabel_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Width, textLabel.Height + 35);
        }

        private void ConvertDateToString(object sender, ConvertEventArgs e)
        {
            var date = (DateTime)e.Value;
            e.Value = date.ToLocalTime().ToShortTimeString();
        }

        private void MessageControl_Click(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;
            this.BackColor = IsSelected ? Color.FromArgb(240, 242, 245) : Color.FromKnownColor(KnownColor.ControlLightLight);
        }
    }
}
