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
        public EventHandler<int> DialogOpen;
        public readonly int DialogId;

        public DialogPreviewControl()
        {
            InitializeComponent();
        }

        public DialogPreviewControl(Dialog dialog)
            : this()
        {
            DialogId = dialog.Id;
            dialogNameLabel.CreateBinding("Text", dialog, "Name");
            lastMessageLabel.CreateBinding("Text", dialog.Preview, "LastMessage", (sender, e) => 
            {
                if (e.Value == null)
                    e.Value = "Нет сообщений";
                else
                {
                    var message = (Entities.Message)e.Value;
                    e.Value = message.Text;
                }
            });
            authorLabel.CreateBinding("Text", dialog.Preview, "LastMessage", (sender, e) =>
            {
                if (e.Value == null)
                    e.Value = string.Empty;
                else
                {
                    var message = (Entities.Message)e.Value;
                    if (message.Author == null)
                        e.Value = string.Empty;
                    else
                        e.Value = message.Author.Name + ":";
                }
            });
            dateLabel.CreateBinding("Text", dialog.Preview, "LastMessage", ConvertDateToString);
            dialogImage.CreateBinding("Image", dialog.Preview, "UnreadMessage", ConvertDialogImage);
            Dock = DockStyle.Top;
        }

        private void ConvertDateToString(object sender, ConvertEventArgs e)
        {
            if (e.Value != null)
            {
                var message = (Entities.Message)e.Value;
                DateTime localTime = message.Date.ToLocalTime();
                if (localTime.Day == DateTime.Now.Day)
                    e.Value = localTime.ToString("hh:mm:ss");
                else if (localTime.AddDays(1).Day == DateTime.Now.Day)
                    e.Value = "Вчера " + localTime.ToString("mm:ss");
                else
                    e.Value = localTime.ToString("dd:MM:yyyy");
            }
            else
                e.Value = string.Empty;
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

        private void DialogPreviewControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
        }

        private void DialogPreviewControl_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(240, 242, 245);
        }

        private void DialogPreviewControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(240, 242, 245);
        }

        private void dateLabel_SizeChanged(object sender, EventArgs e)
        {
            lastMessageLabel.Location = new Point(dateLabel.Location.X + dateLabel.Width + 2, dateLabel.Location.Y);
        }
    }
}
