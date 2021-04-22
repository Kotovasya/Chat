
namespace Client.View.Controls
{
    partial class CreateDialogControl
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.dialogNameLabel = new System.Windows.Forms.Label();
            this.dialogNameTextbox = new System.Windows.Forms.TextBox();
            this.dialogNameImage = new System.Windows.Forms.PictureBox();
            this.passwordImage = new System.Windows.Forms.PictureBox();
            this.createDialogButton = new Client.View.Controls.ButtonControl();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dialogNameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.passwordLabel.Location = new System.Drawing.Point(549, 179);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(238, 43);
            this.passwordLabel.TabIndex = 26;
            this.passwordLabel.Text = "Введите пароль, необходимый для присоединения к диалогу";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.passwordTextbox.Location = new System.Drawing.Point(553, 225);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(234, 36);
            this.passwordTextbox.TabIndex = 25;
            // 
            // dialogNameLabel
            // 
            this.dialogNameLabel.AutoSize = true;
            this.dialogNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.dialogNameLabel.Location = new System.Drawing.Point(138, 197);
            this.dialogNameLabel.Name = "dialogNameLabel";
            this.dialogNameLabel.Size = new System.Drawing.Size(189, 21);
            this.dialogNameLabel.TabIndex = 28;
            this.dialogNameLabel.Text = "Введите назване диалога";
            // 
            // dialogNameTextbox
            // 
            this.dialogNameTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.dialogNameTextbox.Location = new System.Drawing.Point(142, 223);
            this.dialogNameTextbox.Name = "dialogNameTextbox";
            this.dialogNameTextbox.Size = new System.Drawing.Size(234, 36);
            this.dialogNameTextbox.TabIndex = 29;
            // 
            // dialogNameImage
            // 
            this.dialogNameImage.Image = global::Client.Properties.Resources.edit_dialog_name;
            this.dialogNameImage.Location = new System.Drawing.Point(106, 225);
            this.dialogNameImage.Name = "dialogNameImage";
            this.dialogNameImage.Size = new System.Drawing.Size(30, 32);
            this.dialogNameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogNameImage.TabIndex = 30;
            this.dialogNameImage.TabStop = false;
            // 
            // passwordImage
            // 
            this.passwordImage.Image = global::Client.Properties.Resources.password;
            this.passwordImage.Location = new System.Drawing.Point(517, 227);
            this.passwordImage.Name = "passwordImage";
            this.passwordImage.Size = new System.Drawing.Size(30, 32);
            this.passwordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordImage.TabIndex = 27;
            this.passwordImage.TabStop = false;
            // 
            // createDialogButton
            // 
            this.createDialogButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.createDialogButton.Image = global::Client.Properties.Resources.create_dialog;
            this.createDialogButton.Location = new System.Drawing.Point(315, 379);
            this.createDialogButton.Name = "createDialogButton";
            this.createDialogButton.Size = new System.Drawing.Size(250, 50);
            this.createDialogButton.TabIndex = 31;
            this.createDialogButton.Title = "Создать диалог";
            this.createDialogButton.Click += new System.EventHandler(this.createDialogButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(311, 432);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(254, 29);
            this.warningLabel.TabIndex = 32;
            this.warningLabel.Text = "Данное имя уже занято";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLabel.Visible = false;
            // 
            // CreateDialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.createDialogButton);
            this.Controls.Add(this.dialogNameImage);
            this.Controls.Add(this.dialogNameTextbox);
            this.Controls.Add(this.dialogNameLabel);
            this.Controls.Add(this.passwordImage);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Name = "CreateDialogControl";
            this.Size = new System.Drawing.Size(900, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dialogNameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.PictureBox passwordImage;
        private System.Windows.Forms.Label dialogNameLabel;
        private System.Windows.Forms.PictureBox dialogNameImage;
        private System.Windows.Forms.TextBox dialogNameTextbox;
        private ButtonControl createDialogButton;
        private System.Windows.Forms.Label warningLabel;
    }
}
