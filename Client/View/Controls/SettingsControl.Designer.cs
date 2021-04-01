
namespace Client.View.Controls
{
    partial class SettingsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeUsernameImage = new System.Windows.Forms.PictureBox();
            this.newPasswordImage = new System.Windows.Forms.PictureBox();
            this.oldPasswordImage = new System.Windows.Forms.PictureBox();
            this.newPasswordTextbox = new System.Windows.Forms.TextBox();
            this.oldPasswordTextbox = new System.Windows.Forms.TextBox();
            this.changeUsernameTextbox = new System.Windows.Forms.TextBox();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.changeUsernameLabel = new System.Windows.Forms.Label();
            this.changeUsernameButton = new Client.View.Controls.ButtonControl();
            this.changePasswordButton = new Client.View.Controls.ButtonControl();
            ((System.ComponentModel.ISupportInitialize)(this.changeUsernameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.changePasswordLabel.Location = new System.Drawing.Point(123, 19);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(174, 30);
            this.changePasswordLabel.TabIndex = 16;
            this.changePasswordLabel.Text = "Сменить пароль";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.label1.Location = new System.Drawing.Point(479, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Сменить имя пользователя";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.label2.Location = new System.Drawing.Point(408, 159);
            this.label2.MaximumSize = new System.Drawing.Size(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Внимание! После смены имени пользователя, для авторизации необходимо использовать" +
    " новое имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeUsernameImage
            // 
            this.changeUsernameImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeUsernameImage.Image = global::Client.Properties.Resources.user;
            this.changeUsernameImage.Location = new System.Drawing.Point(448, 93);
            this.changeUsernameImage.Name = "changeUsernameImage";
            this.changeUsernameImage.Size = new System.Drawing.Size(30, 32);
            this.changeUsernameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changeUsernameImage.TabIndex = 15;
            this.changeUsernameImage.TabStop = false;
            // 
            // newPasswordImage
            // 
            this.newPasswordImage.Image = global::Client.Properties.Resources.password;
            this.newPasswordImage.Location = new System.Drawing.Point(89, 180);
            this.newPasswordImage.Name = "newPasswordImage";
            this.newPasswordImage.Size = new System.Drawing.Size(30, 32);
            this.newPasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newPasswordImage.TabIndex = 14;
            this.newPasswordImage.TabStop = false;
            // 
            // oldPasswordImage
            // 
            this.oldPasswordImage.Image = global::Client.Properties.Resources.password;
            this.oldPasswordImage.Location = new System.Drawing.Point(89, 93);
            this.oldPasswordImage.Name = "oldPasswordImage";
            this.oldPasswordImage.Size = new System.Drawing.Size(30, 32);
            this.oldPasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oldPasswordImage.TabIndex = 13;
            this.oldPasswordImage.TabStop = false;
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.newPasswordTextbox.Location = new System.Drawing.Point(125, 183);
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.PasswordChar = '•';
            this.newPasswordTextbox.Size = new System.Drawing.Size(234, 36);
            this.newPasswordTextbox.TabIndex = 21;
            // 
            // oldPasswordTextbox
            // 
            this.oldPasswordTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.oldPasswordTextbox.Location = new System.Drawing.Point(125, 96);
            this.oldPasswordTextbox.Name = "oldPasswordTextbox";
            this.oldPasswordTextbox.PasswordChar = '•';
            this.oldPasswordTextbox.Size = new System.Drawing.Size(234, 36);
            this.oldPasswordTextbox.TabIndex = 22;
            this.oldPasswordTextbox.Click += new System.EventHandler(this.oldPasswordTextbox_Click);
            // 
            // changeUsernameTextbox
            // 
            this.changeUsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeUsernameTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.changeUsernameTextbox.Location = new System.Drawing.Point(484, 93);
            this.changeUsernameTextbox.Name = "changeUsernameTextbox";
            this.changeUsernameTextbox.Size = new System.Drawing.Size(234, 36);
            this.changeUsernameTextbox.TabIndex = 23;
            this.changeUsernameTextbox.Click += new System.EventHandler(this.changeUsernameTextbox_Click);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.oldPasswordLabel.Location = new System.Drawing.Point(121, 72);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(176, 21);
            this.oldPasswordLabel.TabIndex = 24;
            this.oldPasswordLabel.Text = "Введите старый пароль";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.newPasswordLabel.Location = new System.Drawing.Point(121, 159);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(172, 21);
            this.newPasswordLabel.TabIndex = 25;
            this.newPasswordLabel.Text = "Введите новый пароль";
            // 
            // changeUsernameLabel
            // 
            this.changeUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeUsernameLabel.AutoSize = true;
            this.changeUsernameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.changeUsernameLabel.Location = new System.Drawing.Point(480, 69);
            this.changeUsernameLabel.Name = "changeUsernameLabel";
            this.changeUsernameLabel.Size = new System.Drawing.Size(146, 21);
            this.changeUsernameLabel.TabIndex = 26;
            this.changeUsernameLabel.Text = "Введите новое имя";
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeUsernameButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeUsernameButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeUsernameButton.Image = global::Client.Properties.Resources.edit_username;
            this.changeUsernameButton.Location = new System.Drawing.Point(484, 254);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(234, 51);
            this.changeUsernameButton.TabIndex = 28;
            this.changeUsernameButton.Title = "Сменить имя";
            this.changeUsernameButton.Click += new System.EventHandler(this.ChangeUsername_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changePasswordButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePasswordButton.Image = global::Client.Properties.Resources.change_password;
            this.changePasswordButton.Location = new System.Drawing.Point(125, 254);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(234, 51);
            this.changePasswordButton.TabIndex = 27;
            this.changePasswordButton.Title = "Сменить пароль";
            this.changePasswordButton.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.changeUsernameButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.changeUsernameLabel);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.oldPasswordLabel);
            this.Controls.Add(this.changeUsernameTextbox);
            this.Controls.Add(this.oldPasswordTextbox);
            this.Controls.Add(this.newPasswordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.changeUsernameImage);
            this.Controls.Add(this.newPasswordImage);
            this.Controls.Add(this.oldPasswordImage);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(807, 509);
            ((System.ComponentModel.ISupportInitialize)(this.changeUsernameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox oldPasswordImage;
        private System.Windows.Forms.PictureBox newPasswordImage;
        private System.Windows.Forms.PictureBox changeUsernameImage;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPasswordTextbox;
        private System.Windows.Forms.TextBox oldPasswordTextbox;
        private System.Windows.Forms.TextBox changeUsernameTextbox;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label changeUsernameLabel;
        private ButtonControl changePasswordButton;
        private ButtonControl changeUsernameButton;
    }
}
