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
            textLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", message, "Text"));
            this.Size = new Size(textLabel.Width + 70, textLabel.Height + 15);

            authorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", message.Author, "Name"));

            System.Windows.Forms.Binding binding = new System.Windows.Forms.Binding("Text", message, "Date");
            binding.Format += new ConvertEventHandler(ConvertDateToString);
            dateLabel.DataBindings.Add(binding);
        }

        private void textLabel_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(textLabel.Width + 70, textLabel.Height + 15);
        }

        private void ConvertDateToString(object sender, ConvertEventArgs e)
        {
            var date = (DateTime)e.Value;
            e.Value = date.ToShortTimeString();
        }
    }
}
