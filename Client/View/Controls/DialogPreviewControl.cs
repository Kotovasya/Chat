using Client.Entities;
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
    public partial class DialogPreviewControl : UserControl
    {
        private readonly Dialog dialog;

        public DialogPreviewControl(Dialog dialog)
        {
            InitializeComponent();
            this.dialog = dialog;
            dialogNameLabel.CreateBinding("Text", dialog, "Name");
            lastMessageLabel.CreateBinding("Text", dialog.Preview, "LastMessage.Text");
            dateLabel.CreateBinding("Text", dialog.Preview, "LastMessage.Date", ConvertDateToString);
            dialogImage.CreateBinding("Image", dialog.Preview, "UnreadMessage", ConvertDialogImage);
        }

        private void ConvertDateToString(object sender, ConvertEventArgs e)
        {
            var date = (DateTime)e.Value;
            e.Value = date.ToLocalTime().ToShortTimeString();
        }

        private void ConvertDialogImage(object sender, ConvertEventArgs e)
        {
            var flag = (bool)e.Value;
            e.Value = flag ? Resources.unread_dialog : Resources.read_dialog;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        private void DialogPreviewControl_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
