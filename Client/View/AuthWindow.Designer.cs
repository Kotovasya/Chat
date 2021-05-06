
namespace Client.View
{
    partial class AuthWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthWindow));
            this.button = new System.Windows.Forms.Button();
            this.authLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.usernameImage = new System.Windows.Forms.PictureBox();
            this.passwordImage = new System.Windows.Forms.PictureBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.appLogoImage = new System.Windows.Forms.PictureBox();
            this.closeImage = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.mameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usernameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(140, 224);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(172, 42);
            this.button.TabIndex = 2;
            this.button.Text = "Войти";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.BackColor = System.Drawing.Color.White;
            this.authLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.authLabel.Location = new System.Drawing.Point(106, 45);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(127, 27);
            this.authLabel.TabIndex = 3;
            this.authLabel.Text = "Авторизация";
            this.authLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label_MouseClick);
            this.authLabel.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.authLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.BackColor = System.Drawing.Color.White;
            this.registrationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationLabel.Location = new System.Drawing.Point(232, 45);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(123, 27);
            this.registrationLabel.TabIndex = 4;
            this.registrationLabel.Text = "Регистрация";
            this.registrationLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label_MouseClick);
            this.registrationLabel.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.registrationLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.passwordTextbox.Location = new System.Drawing.Point(106, 158);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(249, 36);
            this.passwordTextbox.TabIndex = 1;
            this.passwordTextbox.Click += new System.EventHandler(this.input_Click);
            // 
            // loginTextbox
            // 
            this.loginTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.loginTextbox.Location = new System.Drawing.Point(106, 99);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(249, 36);
            this.loginTextbox.TabIndex = 0;
            this.loginTextbox.Click += new System.EventHandler(this.input_Click);
            // 
            // usernameImage
            // 
            this.usernameImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameImage.Image = global::Client.Properties.Resources.user;
            this.usernameImage.Location = new System.Drawing.Point(70, 101);
            this.usernameImage.Name = "usernameImage";
            this.usernameImage.Size = new System.Drawing.Size(30, 32);
            this.usernameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernameImage.TabIndex = 17;
            this.usernameImage.TabStop = false;
            // 
            // passwordImage
            // 
            this.passwordImage.Image = global::Client.Properties.Resources.password;
            this.passwordImage.Location = new System.Drawing.Point(70, 160);
            this.passwordImage.Name = "passwordImage";
            this.passwordImage.Size = new System.Drawing.Size(30, 32);
            this.passwordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordImage.TabIndex = 16;
            this.passwordImage.TabStop = false;
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(16, 197);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(442, 25);
            this.warningLabel.TabIndex = 33;
            this.warningLabel.Text = "Сервер в данный момент не доступен";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLabel.Visible = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.Control;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.appLogoImage);
            this.topPanel.Controls.Add(this.closeImage);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(466, 32);
            this.topPanel.TabIndex = 34;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // appLogoImage
            // 
            this.appLogoImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.appLogoImage.Image = global::Client.Properties.Resources.Chat_App_Icon;
            this.appLogoImage.InitialImage = global::Client.Properties.Resources.minimize_window;
            this.appLogoImage.Location = new System.Drawing.Point(0, 0);
            this.appLogoImage.Name = "appLogoImage";
            this.appLogoImage.Size = new System.Drawing.Size(32, 30);
            this.appLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogoImage.TabIndex = 26;
            this.appLogoImage.TabStop = false;
            // 
            // closeImage
            // 
            this.closeImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeImage.Image = global::Client.Properties.Resources.close_window;
            this.closeImage.InitialImage = global::Client.Properties.Resources.close_window;
            this.closeImage.Location = new System.Drawing.Point(432, 0);
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(32, 30);
            this.closeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeImage.TabIndex = 0;
            this.closeImage.TabStop = false;
            this.closeImage.Click += new System.EventHandler(this.closeImage_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 281);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(466, 1);
            this.bottomPanel.TabIndex = 35;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 32);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1, 249);
            this.leftPanel.TabIndex = 36;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(465, 32);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(1, 249);
            this.rightPanel.TabIndex = 37;
            // 
            // mameLabel
            // 
            this.mameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.mameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mameLabel.Location = new System.Drawing.Point(106, 75);
            this.mameLabel.Name = "mameLabel";
            this.mameLabel.Size = new System.Drawing.Size(215, 23);
            this.mameLabel.TabIndex = 39;
            this.mameLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordLabel.Location = new System.Drawing.Point(106, 135);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(215, 23);
            this.passwordLabel.TabIndex = 38;
            this.passwordLabel.Text = "Пароль";
            // 
            // AuthWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(466, 282);
            this.Controls.Add(this.mameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.usernameImage);
            this.Controls.Add(this.passwordImage);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.button);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.usernameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appLogoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.PictureBox usernameImage;
        private System.Windows.Forms.PictureBox passwordImage;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox appLogoImage;
        private System.Windows.Forms.PictureBox closeImage;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label mameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}