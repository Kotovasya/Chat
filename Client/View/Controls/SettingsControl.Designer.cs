
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
            this.changeUsernameTextbox = new System.Windows.Forms.RichTextBox();
            this.newPasswordTextbox = new System.Windows.Forms.RichTextBox();
            this.oldPasswordTextbox = new System.Windows.Forms.RichTextBox();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonControl1 = new Client.View.Controls.ButtonControl();
            this.buttonControl2 = new Client.View.Controls.ButtonControl();
            this.changeUsernameImage = new System.Windows.Forms.PictureBox();
            this.newPasswordImage = new System.Windows.Forms.PictureBox();
            this.oldPasswordImage = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.changeUsernameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // changeUsernameTextbox
            // 
            this.changeUsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeUsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeUsernameTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeUsernameTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.changeUsernameTextbox.Location = new System.Drawing.Point(633, 96);
            this.changeUsernameTextbox.Multiline = false;
            this.changeUsernameTextbox.Name = "changeUsernameTextbox";
            this.changeUsernameTextbox.Size = new System.Drawing.Size(244, 40);
            this.changeUsernameTextbox.TabIndex = 10;
            this.changeUsernameTextbox.Text = "";
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.newPasswordTextbox.Location = new System.Drawing.Point(125, 186);
            this.newPasswordTextbox.Multiline = false;
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.Size = new System.Drawing.Size(244, 40);
            this.newPasswordTextbox.TabIndex = 11;
            this.newPasswordTextbox.Text = "Новый пароль";
            // 
            // oldPasswordTextbox
            // 
            this.oldPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldPasswordTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordTextbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.oldPasswordTextbox.Location = new System.Drawing.Point(125, 96);
            this.oldPasswordTextbox.Multiline = false;
            this.oldPasswordTextbox.Name = "oldPasswordTextbox";
            this.oldPasswordTextbox.Size = new System.Drawing.Size(244, 40);
            this.oldPasswordTextbox.TabIndex = 12;
            this.oldPasswordTextbox.Text = "Старый пароль";
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F);
            this.changePasswordLabel.Location = new System.Drawing.Point(104, 19);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(213, 37);
            this.changePasswordLabel.TabIndex = 16;
            this.changePasswordLabel.Text = "Сменить пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F);
            this.label1.Location = new System.Drawing.Point(555, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Сменить имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.label2.Location = new System.Drawing.Point(536, 149);
            this.label2.MaximumSize = new System.Drawing.Size(400, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 90);
            this.label2.TabIndex = 18;
            this.label2.Text = "Внимание! После смены имени пользователя, для авторизации необходимо использовать" +
    " новое имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonControl1
            // 
            this.buttonControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonControl1.Location = new System.Drawing.Point(596, 254);
            this.buttonControl1.Name = "buttonControl1";
            this.buttonControl1.Size = new System.Drawing.Size(250, 64);
            this.buttonControl1.TabIndex = 19;
            // 
            // buttonControl2
            // 
            this.buttonControl2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonControl2.Location = new System.Drawing.Point(87, 254);
            this.buttonControl2.Name = "buttonControl2";
            this.buttonControl2.Size = new System.Drawing.Size(250, 64);
            this.buttonControl2.TabIndex = 20;
            // 
            // changeUsernameImage
            // 
            this.changeUsernameImage.Image = global::Client.Properties.Resources.user;
            this.changeUsernameImage.Location = new System.Drawing.Point(562, 96);
            this.changeUsernameImage.Name = "changeUsernameImage";
            this.changeUsernameImage.Size = new System.Drawing.Size(40, 40);
            this.changeUsernameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changeUsernameImage.TabIndex = 15;
            this.changeUsernameImage.TabStop = false;
            // 
            // newPasswordImage
            // 
            this.newPasswordImage.Image = global::Client.Properties.Resources.password;
            this.newPasswordImage.Location = new System.Drawing.Point(54, 186);
            this.newPasswordImage.Name = "newPasswordImage";
            this.newPasswordImage.Size = new System.Drawing.Size(40, 40);
            this.newPasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newPasswordImage.TabIndex = 14;
            this.newPasswordImage.TabStop = false;
            // 
            // oldPasswordImage
            // 
            this.oldPasswordImage.Image = global::Client.Properties.Resources.password;
            this.oldPasswordImage.Location = new System.Drawing.Point(54, 96);
            this.oldPasswordImage.Name = "oldPasswordImage";
            this.oldPasswordImage.Size = new System.Drawing.Size(40, 40);
            this.oldPasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oldPasswordImage.TabIndex = 13;
            this.oldPasswordImage.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F);
            this.textBox1.Location = new System.Drawing.Point(343, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 43);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Новый пароль";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonControl2);
            this.Controls.Add(this.buttonControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.changeUsernameImage);
            this.Controls.Add(this.newPasswordImage);
            this.Controls.Add(this.oldPasswordImage);
            this.Controls.Add(this.oldPasswordTextbox);
            this.Controls.Add(this.newPasswordTextbox);
            this.Controls.Add(this.changeUsernameTextbox);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(1000, 708);
            this.Load += new System.EventHandler(this.SettingsControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsControl_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.changeUsernameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox changeUsernameTextbox;
        private System.Windows.Forms.RichTextBox newPasswordTextbox;
        private System.Windows.Forms.RichTextBox oldPasswordTextbox;
        private System.Windows.Forms.PictureBox oldPasswordImage;
        private System.Windows.Forms.PictureBox newPasswordImage;
        private System.Windows.Forms.PictureBox changeUsernameImage;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ButtonControl buttonControl1;
        private ButtonControl buttonControl2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
