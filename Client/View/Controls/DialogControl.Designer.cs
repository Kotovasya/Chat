
namespace Client.View.Controls
{
    partial class DialogControl
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
            this.messagesContainer = new System.Windows.Forms.Panel();
            this.usersContainer = new System.Windows.Forms.Panel();
            this.dialogSettingsPanel = new System.Windows.Forms.Panel();
            this.saveSettiingsButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameImage = new System.Windows.Forms.PictureBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordImage = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.buttomPanelImage = new System.Windows.Forms.PictureBox();
            this.messageTextbox = new System.Windows.Forms.RichTextBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.dialogSettingImage = new System.Windows.Forms.PictureBox();
            this.usersCountLabel = new System.Windows.Forms.Label();
            this.dialogNameLabel = new System.Windows.Forms.Label();
            this.editMessageLabel = new System.Windows.Forms.Label();
            this.cancelEditMessageLabel = new System.Windows.Forms.Label();
            this.buttomWarningLabel = new System.Windows.Forms.Label();
            this.messagesContainer.SuspendLayout();
            this.dialogSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttomPanelImage)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialogSettingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesContainer
            // 
            this.messagesContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.messagesContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagesContainer.Controls.Add(this.usersContainer);
            this.messagesContainer.Controls.Add(this.dialogSettingsPanel);
            this.messagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesContainer.Location = new System.Drawing.Point(150, 100);
            this.messagesContainer.Name = "messagesContainer";
            this.messagesContainer.Size = new System.Drawing.Size(700, 505);
            this.messagesContainer.TabIndex = 13;
            this.messagesContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.messagesContainer_ControlAdded);
            // 
            // usersContainer
            // 
            this.usersContainer.BackColor = System.Drawing.SystemColors.Menu;
            this.usersContainer.Location = new System.Drawing.Point(213, 5);
            this.usersContainer.Name = "usersContainer";
            this.usersContainer.Size = new System.Drawing.Size(152, 320);
            this.usersContainer.TabIndex = 1;
            this.usersContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.usersContainer_ControlAdded);
            // 
            // dialogSettingsPanel
            // 
            this.dialogSettingsPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.dialogSettingsPanel.Controls.Add(this.saveSettiingsButton);
            this.dialogSettingsPanel.Controls.Add(this.warningLabel);
            this.dialogSettingsPanel.Controls.Add(this.nameTextbox);
            this.dialogSettingsPanel.Controls.Add(this.nameImage);
            this.dialogSettingsPanel.Controls.Add(this.passwordTextbox);
            this.dialogSettingsPanel.Controls.Add(this.passwordImage);
            this.dialogSettingsPanel.Location = new System.Drawing.Point(371, 5);
            this.dialogSettingsPanel.Name = "dialogSettingsPanel";
            this.dialogSettingsPanel.Size = new System.Drawing.Size(308, 158);
            this.dialogSettingsPanel.TabIndex = 0;
            this.dialogSettingsPanel.Visible = false;
            // 
            // saveSettiingsButton
            // 
            this.saveSettiingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveSettiingsButton.Location = new System.Drawing.Point(95, 120);
            this.saveSettiingsButton.Name = "saveSettiingsButton";
            this.saveSettiingsButton.Size = new System.Drawing.Size(104, 35);
            this.saveSettiingsButton.TabIndex = 33;
            this.saveSettiingsButton.Text = "Сохранить";
            this.saveSettiingsButton.UseVisualStyleBackColor = true;
            this.saveSettiingsButton.Click += new System.EventHandler(this.saveSettiingsButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(3, 72);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(302, 45);
            this.warningLabel.TabIndex = 32;
            this.warningLabel.Text = "Изменение настроек диалога доступно только его создателю";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLabel.Visible = false;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextbox.Location = new System.Drawing.Point(76, 12);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(193, 27);
            this.nameTextbox.TabIndex = 31;
            this.nameTextbox.Click += new System.EventHandler(this.settingsInput_Click);
            // 
            // nameImage
            // 
            this.nameImage.Image = global::Client.Properties.Resources.create_dialog;
            this.nameImage.Location = new System.Drawing.Point(46, 12);
            this.nameImage.Name = "nameImage";
            this.nameImage.Size = new System.Drawing.Size(24, 24);
            this.nameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nameImage.TabIndex = 30;
            this.nameImage.TabStop = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextbox.Location = new System.Drawing.Point(76, 45);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(193, 27);
            this.passwordTextbox.TabIndex = 29;
            this.passwordTextbox.Click += new System.EventHandler(this.settingsInput_Click);
            // 
            // passwordImage
            // 
            this.passwordImage.Image = global::Client.Properties.Resources.password;
            this.passwordImage.Location = new System.Drawing.Point(46, 45);
            this.passwordImage.Name = "passwordImage";
            this.passwordImage.Size = new System.Drawing.Size(24, 24);
            this.passwordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordImage.TabIndex = 28;
            this.passwordImage.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomPanel.Controls.Add(this.buttomWarningLabel);
            this.bottomPanel.Controls.Add(this.cancelEditMessageLabel);
            this.bottomPanel.Controls.Add(this.editMessageLabel);
            this.bottomPanel.Controls.Add(this.buttomPanelImage);
            this.bottomPanel.Controls.Add(this.messageTextbox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(150, 605);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(700, 75);
            this.bottomPanel.TabIndex = 9;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomPanel_Paint);
            // 
            // buttomPanelImage
            // 
            this.buttomPanelImage.Image = global::Client.Properties.Resources.send;
            this.buttomPanelImage.Location = new System.Drawing.Point(639, 18);
            this.buttomPanelImage.Name = "buttomPanelImage";
            this.buttomPanelImage.Size = new System.Drawing.Size(40, 40);
            this.buttomPanelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttomPanelImage.TabIndex = 10;
            this.buttomPanelImage.TabStop = false;
            this.buttomPanelImage.Click += new System.EventHandler(this.buttomPanelImage_Click);
            // 
            // messageTextbox
            // 
            this.messageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageTextbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.messageTextbox.Location = new System.Drawing.Point(40, 25);
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Size = new System.Drawing.Size(577, 25);
            this.messageTextbox.TabIndex = 9;
            this.messageTextbox.Text = "";
            this.messageTextbox.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.messageTextbox_ContentsResized);
            this.messageTextbox.Click += new System.EventHandler(this.messageTextbox_Click);
            this.messageTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextbox_KeyDown);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(850, 100);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(150, 580);
            this.rightPanel.TabIndex = 12;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 100);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(150, 580);
            this.leftPanel.TabIndex = 10;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.topPanel.Controls.Add(this.dialogSettingImage);
            this.topPanel.Controls.Add(this.usersCountLabel);
            this.topPanel.Controls.Add(this.dialogNameLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1000, 100);
            this.topPanel.TabIndex = 11;
            // 
            // dialogSettingImage
            // 
            this.dialogSettingImage.Image = global::Client.Properties.Resources.edit_dialog_name;
            this.dialogSettingImage.Location = new System.Drawing.Point(782, 46);
            this.dialogSettingImage.Name = "dialogSettingImage";
            this.dialogSettingImage.Size = new System.Drawing.Size(48, 48);
            this.dialogSettingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogSettingImage.TabIndex = 20;
            this.dialogSettingImage.TabStop = false;
            this.dialogSettingImage.Click += new System.EventHandler(this.dialogSettingImage_Click);
            // 
            // usersCountLabel
            // 
            this.usersCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usersCountLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.usersCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usersCountLabel.Location = new System.Drawing.Point(360, 46);
            this.usersCountLabel.Name = "usersCountLabel";
            this.usersCountLabel.Size = new System.Drawing.Size(280, 30);
            this.usersCountLabel.TabIndex = 19;
            this.usersCountLabel.Text = "Участников: 100";
            this.usersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usersCountLabel.Click += new System.EventHandler(this.usersCountLabel_Click);
            // 
            // dialogNameLabel
            // 
            this.dialogNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.dialogNameLabel.Location = new System.Drawing.Point(3, 9);
            this.dialogNameLabel.Name = "dialogNameLabel";
            this.dialogNameLabel.Size = new System.Drawing.Size(994, 30);
            this.dialogNameLabel.TabIndex = 18;
            this.dialogNameLabel.Text = "Название диалога";
            this.dialogNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editMessageLabel
            // 
            this.editMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editMessageLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.editMessageLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editMessageLabel.Location = new System.Drawing.Point(36, 0);
            this.editMessageLabel.Name = "editMessageLabel";
            this.editMessageLabel.Size = new System.Drawing.Size(215, 23);
            this.editMessageLabel.TabIndex = 20;
            this.editMessageLabel.Text = "Редактирование сообщения";
            this.editMessageLabel.Visible = false;
            // 
            // cancelEditMessageLabel
            // 
            this.cancelEditMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelEditMessageLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.cancelEditMessageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cancelEditMessageLabel.Location = new System.Drawing.Point(241, 0);
            this.cancelEditMessageLabel.Name = "cancelEditMessageLabel";
            this.cancelEditMessageLabel.Size = new System.Drawing.Size(85, 23);
            this.cancelEditMessageLabel.TabIndex = 21;
            this.cancelEditMessageLabel.Text = "Отменить";
            this.cancelEditMessageLabel.Visible = false;
            this.cancelEditMessageLabel.Click += new System.EventHandler(this.cancelEditMessageLabel_Click);
            this.cancelEditMessageLabel.MouseEnter += new System.EventHandler(this.cancelEditMessageLabel_MouseEnter);
            this.cancelEditMessageLabel.MouseLeave += new System.EventHandler(this.cancelEditMessageLabel_MouseLeave);
            // 
            // buttomWarningLabel
            // 
            this.buttomWarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttomWarningLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.buttomWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.buttomWarningLabel.Location = new System.Drawing.Point(332, 0);
            this.buttomWarningLabel.Name = "buttomWarningLabel";
            this.buttomWarningLabel.Size = new System.Drawing.Size(285, 23);
            this.buttomWarningLabel.TabIndex = 22;
            this.buttomWarningLabel.Text = "Не удалось отправить собщение";
            this.buttomWarningLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttomWarningLabel.Visible = false;
            // 
            // DialogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messagesContainer);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "DialogControl";
            this.Size = new System.Drawing.Size(1000, 680);
            this.messagesContainer.ResumeLayout(false);
            this.dialogSettingsPanel.ResumeLayout(false);
            this.dialogSettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttomPanelImage)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dialogSettingImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messagesContainer;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.RichTextBox messageTextbox;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox buttomPanelImage;
        private System.Windows.Forms.Label dialogNameLabel;
        private System.Windows.Forms.Label usersCountLabel;
        private System.Windows.Forms.PictureBox dialogSettingImage;
        private System.Windows.Forms.Panel dialogSettingsPanel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.PictureBox nameImage;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.PictureBox passwordImage;
        private System.Windows.Forms.Button saveSettiingsButton;
        private System.Windows.Forms.Panel usersContainer;
        private System.Windows.Forms.Label cancelEditMessageLabel;
        private System.Windows.Forms.Label editMessageLabel;
        private System.Windows.Forms.Label buttomWarningLabel;
    }
}
