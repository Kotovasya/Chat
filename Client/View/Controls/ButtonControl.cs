using Client.Extensions;
using Client.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View.Controls
{
    public partial class ButtonControl : UserControl
    {
        public string Title
        {
            get { return buttonText.Text; }
            set { buttonText.Text = value; }
        }

        public Image Image
        {
            get { return buttonImage.Image; }
            set { buttonImage.Image = value; }
        }

        public ButtonControl()
        {
            InitializeComponent();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        private void ButtonControl_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void buttonControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromKnownColor(KnownColor.ControlLight);
        }

        private void buttonControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
        }

        private void buttonControl_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromKnownColor(KnownColor.ControlLight);
        }
    }
}
