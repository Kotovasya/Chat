
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
            this.button = new System.Windows.Forms.Button();
            this.authLabel = new System.Windows.Forms.Label();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.usernameImage = new System.Windows.Forms.PictureBox();
            this.passwordImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usernameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(136, 197);
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
            this.authLabel.Location = new System.Drawing.Point(102, 18);
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
            this.registrationLabel.Location = new System.Drawing.Point(228, 18);
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
            this.passwordTextbox.Location = new System.Drawing.Point(102, 131);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(249, 36);
            this.passwordTextbox.TabIndex = 1;
            // 
            // loginTextbox
            // 
            this.loginTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.loginTextbox.Location = new System.Drawing.Point(102, 72);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(249, 36);
            this.loginTextbox.TabIndex = 0;
            // 
            // usernameImage
            // 
            this.usernameImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameImage.Image = global::Client.Properties.Resources.user;
            this.usernameImage.Location = new System.Drawing.Point(66, 74);
            this.usernameImage.Name = "usernameImage";
            this.usernameImage.Size = new System.Drawing.Size(30, 32);
            this.usernameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernameImage.TabIndex = 17;
            this.usernameImage.TabStop = false;
            // 
            // passwordImage
            // 
            this.passwordImage.Image = global::Client.Properties.Resources.password;
            this.passwordImage.Location = new System.Drawing.Point(66, 133);
            this.passwordImage.Name = "passwordImage";
            this.passwordImage.Size = new System.Drawing.Size(30, 32);
            this.passwordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordImage.TabIndex = 16;
            this.passwordImage.TabStop = false;
            // 
            // AuthWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(466, 251);
            this.Controls.Add(this.usernameImage);
            this.Controls.Add(this.passwordImage);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.button);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.usernameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).EndInit();
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
    }
}