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

            textLabel.CreateBinding("Text", message, "Text", (object sender, ConvertEventArgs e) =>
            {
                if (textLabel.InvokeRequired)
                    textLabel.BeginInvoke((Action)delegate { textLabel.Text = e.Value.ToString(); });
                else
                    textLabel.Text = e.Value.ToString();
            });
            authorLabel.CreateBinding("Text", message.Author, "Name", (object sender, ConvertEventArgs e) =>
            {
                if (textLabel.InvokeRequired)
                    textLabel.BeginInvoke((Action)delegate { authorLabel.Text = e.Value.ToString(); });
                else
                    textLabel.Text = e.Value.ToString();
            });
            dateLabel.CreateBinding("Text", message, "Date", ConvertDateToString);
            //this.Dock = DockStyle.Top;
        }

        private void textLabel_SizeChanged(object sender, EventArgs e)
        {
            if (textLabel.Width > this.Width)
                this.Size = new Size(textLabel.Width + 30, textLabel.Height + 35);
            TextEdited?.Invoke(this, this);
        }

        private void ConvertDateToString(object sender, ConvertEventArgs e)
        {
            if (e.Value != null)
            {
                var date = (DateTime)e.Value;
                DateTime localTime = date.ToLocalTime();
                if (localTime.Day == DateTime.Now.Day)
                    e.Value = localTime.ToString("HH:mm:ss");
                else if (localTime.AddDays(1).Day == DateTime.Now.Day)
                    e.Value = "Вчера " + localTime.ToString("HH:mm");
                else
                    e.Value = localTime.ToString("dd.MM.yyyy");
            }
            else e.Value = string.Empty;
        }

        public void MessageControl_Click(object sender, EventArgs e)
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

        private void authorLabel_SizeChanged(object sender, EventArgs e)
        {
            dateLabel.Location = new Point(authorLabel.Location.X + authorLabel.Width + 2, dateLabel.Location.Y);
        }

        private void dateLabel_LocationChanged(object sender, EventArgs e)
        {
            int newWidth = dateLabel.Location.X + dateLabel.Width + 60;
            if (newWidth > this.Width)
                this.Width = newWidth;
        }
    }
}
