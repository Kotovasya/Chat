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
        private bool isButtonVisible;

        public Entities.Message Message { get; private set; }
        public bool IsButtonsVisible
        {
            get { return isButtonVisible; }
            set
            {
                isButtonVisible = value;
                removeMessageImage.Visible = value;
                editMessageImage.Visible = value;
            }
        }
        public bool IsSelected { get; set; }
        public bool IsClientAuthor { get; set; }

        public EventHandler<MessageControl> MessageSelected;
        public EventHandler<MessageControl> TextEdited;
        public EventHandler<MessageControl> EditMessage;
        public EventHandler<MessageControl> RemoveMessage;


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
            //this.Dock = DockStyle.Top;
        }

        private void textLabel_SizeChanged(object sender, EventArgs e)
        {
            if (textLabel.Width < 170)
                this.Size = new Size(240, textLabel.Height + 35);
            else
                this.Size = new Size(textLabel.Width + 70, textLabel.Height + 35);
            TextEdited?.Invoke(this, this);
        }

        private void ConvertDateToString(object sender, ConvertEventArgs e)
        {
            if (e.Value != null)
            {
                var date = (DateTime)e.Value;
                DateTime localTime = date.ToLocalTime();
                if (localTime.Day == DateTime.Now.Day)
                    e.Value = localTime.ToString("hh:mm:ss");
                else if (localTime.AddDays(1).Day == DateTime.Now.Day)
                    e.Value = "Вчера " + localTime.ToString("mm:ss");
                else
                    e.Value = localTime.ToString("dd:MM:yyyy");
            }
            else e.Value = string.Empty;
        }

        private void MessageControl_Click(object sender, EventArgs e)
        {
            if (IsClientAuthor)
            {
                IsSelected = !IsSelected;
                MessageSelected?.Invoke(this, this);
                this.BackColor = IsSelected ? Color.FromArgb(240, 242, 245) : Color.FromKnownColor(KnownColor.ControlLightLight);
            }
        }

        private void editMessageImage_Click(object sender, EventArgs e)
        {
            if (IsClientAuthor && IsSelected)
                EditMessage?.Invoke(this, this);            
        }

        private void removeMessageImage_Click(object sender, EventArgs e)
        {
            if (IsClientAuthor && IsSelected)
                RemoveMessage?.Invoke(this, this);
        }

        private void editMessageImage_MouseEnter(object sender, EventArgs e)
        {
            var image = (PictureBox)sender;
            image.Size = new Size(28, 28);
        }

        private void editMessageImage_MouseLeave(object sender, EventArgs e)
        {
            var image = (PictureBox)sender;
            image.Size = new Size(26, 26);
        }

        public override string ToString()
        {
            return "X = " + Location.X + "; Y = " + Location.Y;
        }
    }
}
