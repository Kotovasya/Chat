using Client.Model;
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
using Client.ServiceReference;

namespace Client.View.Controls
{
    public partial class SettingsControl : UserControl
    {
        
        private readonly ClientModel model;
        private Graphics g;
        private Pen borderPen;

        public SettingsControl(ClientModel model)
        {
            InitializeComponent();
            InitializeButtons();
            this.model = model;
            
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            var response = model.ChangePassword(new ChangePasswordRequest() 
            { 
                Id = model.Id, 
                OldPassword = oldPasswordTextbox.Text, 
                NewPassword = newPasswordTextbox.Text 
            });

        }

        private void ChangeUsername_Click(object sender, EventArgs e)
        {
            var response = model.ChangeUsername(new ChangeUsernameRequest()
            {
                Id = model.Id,
                NewName = changeUsernameTextbox.Text,
            });
        }

        private void InitializeButtons()
        {
            ButtonControl changePasswordControl = new ButtonControl(Resources.change_password, "Изменить пароль");
            ButtonControl changeUsernameControl = new ButtonControl(Resources.edit_username, "Изменить имя");
            changePasswordControl.Click += changePassword_Click;
            changeUsernameControl.Click += ChangeUsername_Click;
            Controls.Add(changePasswordControl);
            Controls.Add(changeUsernameControl);
            changeUsernameControl.Location = new Point(596, 254);
            changePasswordControl.Location = new Point(87, 254);
        }

        private void SettingsControl_Paint(object sender, PaintEventArgs e)
        {
            g.DrawRectangle(borderPen, new Rectangle(messageTextbox.Location, messageTextbox.Size));
        }

        private void PaintRectangle(Rectangle rectangle, Color color)
        {
            Pen pen = new Pen(color, 2);
        }
    }
}
