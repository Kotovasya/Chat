
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
            this.changeNameLabel = new System.Windows.Forms.Label();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.saveSettiingsButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameImage = new System.Windows.Forms.PictureBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordImage = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.buttomWarningLabel = new System.Windows.Forms.Label();
            this.cancelEditMessageLabel = new System.Windows.Forms.Label();
            this.editMessageLabel = new System.Windows.Forms.Label();
            this.buttomPanelImage = new System.Windows.Forms.PictureBox();
            this.messageTextbox = new System.Windows.Forms.RichTextBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.removeSelectedMessagesButton = new System.Windows.Forms.Button();
            this.dialogSettingImage = new System.Windows.Forms.PictureBox();
            this.usersCountLabel = new System.Windows.Forms.Label();
            this.dialogNameLabel = new System.Windows.Forms.Label();
            this.searchImage = new System.Windows.Forms.PictureBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.messagesContainer.SuspendLayout();
            this.dialogSettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttomPanelImage)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialogSettingImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesContainer
            // 
            this.messagesContainer.AutoScroll = true;
            this.messagesContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.messagesContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagesContainer.Controls.Add(this.usersContainer);
            this.messagesContainer.Controls.Add(this.dialogSettingsPanel);
            this.messagesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesContainer.Location = new System.Drawing.Point(110, 79);
            this.messagesContainer.Name = "messagesContainer";
            this.messagesContainer.Size = new System.Drawing.Size(780, 526);
            this.messagesContainer.TabIndex = 13;
            this.messagesContainer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.messagesContainer_Scroll);
            // 
            // usersContainer
            // 
            this.usersContainer.AutoScroll = true;
            this.usersContainer.BackColor = System.Drawing.SystemColors.Menu;
            this.usersContainer.Location = new System.Drawing.Point(229, 5);
            this.usersContainer.Name = "usersContainer";
            this.usersContainer.Size = new System.Drawing.Size(176, 320);
            this.usersContainer.TabIndex = 1;
            this.usersContainer.Visible = false;
            // 
            // dialogSettingsPanel
            // 
            this.dialogSettingsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dialogSettingsPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.dialogSettingsPanel.Controls.Add(this.changeNameLabel);
            this.dialogSettingsPanel.Controls.Add(this.changePasswordLabel);
            this.dialogSettingsPanel.Controls.Add(this.saveSettiingsButton);
            this.dialogSettingsPanel.Controls.Add(this.warningLabel);
            this.dialogSettingsPanel.Controls.Add(this.nameTextbox);
            this.dialogSettingsPanel.Controls.Add(this.nameImage);
            this.dialogSettingsPanel.Controls.Add(this.passwordTextbox);
            this.dialogSettingsPanel.Controls.Add(this.passwordImage);
            this.dialogSettingsPanel.Location = new System.Drawing.Point(411, 5);
            this.dialogSettingsPanel.Name = "dialogSettingsPanel";
            this.dialogSettingsPanel.Size = new System.Drawing.Size(308, 192);
            this.dialogSettingsPanel.TabIndex = 0;
            this.dialogSettingsPanel.Visible = false;
            // 
            // changeNameLabel
            // 
            this.changeNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.changeNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changeNameLabel.Location = new System.Drawing.Point(42, 4);
            this.changeNameLabel.Name = "changeNameLabel";
            this.changeNameLabel.Size = new System.Drawing.Size(215, 23);
            this.changeNameLabel.TabIndex = 35;
            this.changeNameLabel.Text = "Изменить имя";
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.changePasswordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changePasswordLabel.Location = new System.Drawing.Point(42, 55);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(215, 23);
            this.changePasswordLabel.TabIndex = 34;
            this.changePasswordLabel.Text = "Изменить пароль";
            // 
            // saveSettiingsButton
            // 
            this.saveSettiingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSettiingsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveSettiingsButton.Location = new System.Drawing.Point(99, 154);
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
            this.warningLabel.Location = new System.Drawing.Point(3, 106);
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
            this.nameTextbox.Location = new System.Drawing.Point(76, 28);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(193, 27);
            this.nameTextbox.TabIndex = 31;
            this.nameTextbox.Click += new System.EventHandler(this.settingsInput_Click);
            // 
            // nameImage
            // 
            this.nameImage.Image = global::Client.Properties.Resources.create_dialog;
            this.nameImage.Location = new System.Drawing.Point(46, 29);
            this.nameImage.Name = "nameImage";
            this.nameImage.Size = new System.Drawing.Size(24, 24);
            this.nameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nameImage.TabIndex = 30;
            this.nameImage.TabStop = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextbox.Location = new System.Drawing.Point(76, 79);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(193, 27);
            this.passwordTextbox.TabIndex = 29;
            this.passwordTextbox.Click += new System.EventHandler(this.settingsInput_Click);
            // 
            // passwordImage
            // 
            this.passwordImage.Image = global::Client.Properties.Resources.password;
            this.passwordImage.Location = new System.Drawing.Point(46, 81);
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
            this.bottomPanel.Location = new System.Drawing.Point(110, 605);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(780, 75);
            this.bottomPanel.TabIndex = 9;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bottomPanel_Paint);
            // 
            // buttomWarningLabel
            // 
            this.buttomWarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttomWarningLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.buttomWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.buttomWarningLabel.Location = new System.Drawing.Point(412, 0);
            this.buttomWarningLabel.Name = "buttomWarningLabel";
            this.buttomWarningLabel.Size = new System.Drawing.Size(285, 23);
            this.buttomWarningLabel.TabIndex = 22;
            this.buttomWarningLabel.Text = "Не удалось отправить собщение";
            this.buttomWarningLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttomWarningLabel.Visible = false;
            // 
            // cancelEditMessageLabel
            // 
            this.cancelEditMessageLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelEditMessageLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.cancelEditMessageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cancelEditMessageLabel.Location = new System.Drawing.Point(257, 2);
            this.cancelEditMessageLabel.Name = "cancelEditMessageLabel";
            this.cancelEditMessageLabel.Size = new System.Drawing.Size(85, 23);
            this.cancelEditMessageLabel.TabIndex = 21;
            this.cancelEditMessageLabel.Text = "Отменить";
            this.cancelEditMessageLabel.Visible = false;
            this.cancelEditMessageLabel.Click += new System.EventHandler(this.cancelEditMessageLabel_Click);
            this.cancelEditMessageLabel.MouseEnter += new System.EventHandler(this.cancelEditMessageLabel_MouseEnter);
            this.cancelEditMessageLabel.MouseLeave += new System.EventHandler(this.cancelEditMessageLabel_MouseLeave);
            // 
            // editMessageLabel
            // 
            this.editMessageLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.editMessageLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.editMessageLabel.Location = new System.Drawing.Point(36, -1);
            this.editMessageLabel.Name = "editMessageLabel";
            this.editMessageLabel.Size = new System.Drawing.Size(215, 23);
            this.editMessageLabel.TabIndex = 20;
            this.editMessageLabel.Text = "Редактирование сообщения";
            this.editMessageLabel.Visible = false;
            // 
            // buttomPanelImage
            // 
            this.buttomPanelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttomPanelImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttomPanelImage.Image = global::Client.Properties.Resources.send;
            this.buttomPanelImage.Location = new System.Drawing.Point(718, 17);
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
            this.messageTextbox.Size = new System.Drawing.Size(657, 25);
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
            this.rightPanel.Location = new System.Drawing.Point(890, 79);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(110, 601);
            this.rightPanel.TabIndex = 12;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 79);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(110, 601);
            this.leftPanel.TabIndex = 10;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.topPanel.Controls.Add(this.searchImage);
            this.topPanel.Controls.Add(this.searchTextbox);
            this.topPanel.Controls.Add(this.removeSelectedMessagesButton);
            this.topPanel.Controls.Add(this.dialogSettingImage);
            this.topPanel.Controls.Add(this.usersCountLabel);
            this.topPanel.Controls.Add(this.dialogNameLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1000, 79);
            this.topPanel.TabIndex = 11;
            // 
            // removeSelectedMessagesButton
            // 
            this.removeSelectedMessagesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.removeSelectedMessagesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(197)))));
            this.removeSelectedMessagesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedMessagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMessagesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeSelectedMessagesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeSelectedMessagesButton.Location = new System.Drawing.Point(621, 41);
            this.removeSelectedMessagesButton.Name = "removeSelectedMessagesButton";
            this.removeSelectedMessagesButton.Size = new System.Drawing.Size(104, 35);
            this.removeSelectedMessagesButton.TabIndex = 34;
            this.removeSelectedMessagesButton.Text = "Удалить";
            this.removeSelectedMessagesButton.UseVisualStyleBackColor = false;
            this.removeSelectedMessagesButton.Visible = false;
            this.removeSelectedMessagesButton.Click += new System.EventHandler(this.removeSelectedMessagesButton_Click);
            // 
            // dialogSettingImage
            // 
            this.dialogSettingImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dialogSettingImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dialogSettingImage.Image = global::Client.Properties.Resources.edit_dialog_name;
            this.dialogSettingImage.Location = new System.Drawing.Point(782, 26);
            this.dialogSettingImage.Name = "dialogSettingImage";
            this.dialogSettingImage.Size = new System.Drawing.Size(48, 48);
            this.dialogSettingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogSettingImage.TabIndex = 20;
            this.dialogSettingImage.TabStop = false;
            this.dialogSettingImage.Click += new System.EventHandler(this.dialogSettingImage_Click);
            this.dialogSettingImage.MouseEnter += new System.EventHandler(this.dialogSettingImage_MouseEnter);
            this.dialogSettingImage.MouseLeave += new System.EventHandler(this.dialogSettingImage_MouseLeave);
            // 
            // usersCountLabel
            // 
            this.usersCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usersCountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersCountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usersCountLabel.Location = new System.Drawing.Point(360, 30);
            this.usersCountLabel.Name = "usersCountLabel";
            this.usersCountLabel.Size = new System.Drawing.Size(280, 30);
            this.usersCountLabel.TabIndex = 19;
            this.usersCountLabel.Text = "Участники";
            this.usersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usersCountLabel.Click += new System.EventHandler(this.usersCountLabel_Click);
            this.usersCountLabel.MouseEnter += new System.EventHandler(this.usersCountLabel_MouseEnter);
            this.usersCountLabel.MouseLeave += new System.EventHandler(this.usersCountLabel_MouseLeave);
            // 
            // dialogNameLabel
            // 
            this.dialogNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dialogNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.dialogNameLabel.Location = new System.Drawing.Point(3, 0);
            this.dialogNameLabel.Name = "dialogNameLabel";
            this.dialogNameLabel.Size = new System.Drawing.Size(994, 30);
            this.dialogNameLabel.TabIndex = 18;
            this.dialogNameLabel.Text = "Название диалога";
            this.dialogNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchImage
            // 
            this.searchImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchImage.Image = global::Client.Properties.Resources.search;
            this.searchImage.Location = new System.Drawing.Point(110, 38);
            this.searchImage.Name = "searchImage";
            this.searchImage.Size = new System.Drawing.Size(36, 36);
            this.searchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchImage.TabIndex = 36;
            this.searchImage.TabStop = false;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.searchTextbox.Location = new System.Drawing.Point(151, 37);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(257, 36);
            this.searchTextbox.TabIndex = 35;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
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
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dialogSettingImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).EndInit();
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
        private System.Windows.Forms.Button removeSelectedMessagesButton;
        private System.Windows.Forms.Label changeNameLabel;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.PictureBox searchImage;
        private System.Windows.Forms.TextBox searchTextbox;
    }
}
