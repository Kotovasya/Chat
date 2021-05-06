
namespace Client.View.Controls
{
    partial class DialogsControl
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.connectToDialogButton = new Client.View.Controls.ButtonControl();
            this.searchImage = new System.Windows.Forms.PictureBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.dialogsContainer = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topPanel.Controls.Add(this.connectToDialogButton);
            this.topPanel.Controls.Add(this.searchImage);
            this.topPanel.Controls.Add(this.searchTextbox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(900, 100);
            this.topPanel.TabIndex = 2;
            // 
            // connectToDialogButton
            // 
            this.connectToDialogButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.connectToDialogButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectToDialogButton.Image = global::Client.Properties.Resources.connect_to_dialog;
            this.connectToDialogButton.Location = new System.Drawing.Point(581, 25);
            this.connectToDialogButton.Name = "connectToDialogButton";
            this.connectToDialogButton.Separator = false;
            this.connectToDialogButton.Size = new System.Drawing.Size(250, 49);
            this.connectToDialogButton.TabIndex = 25;
            this.connectToDialogButton.Title = "Присоединиться";
            this.connectToDialogButton.Click += new System.EventHandler(this.connectToDialogButton_Click);
            // 
            // searchImage
            // 
            this.searchImage.Image = global::Client.Properties.Resources.search;
            this.searchImage.Location = new System.Drawing.Point(100, 31);
            this.searchImage.Name = "searchImage";
            this.searchImage.Size = new System.Drawing.Size(36, 36);
            this.searchImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchImage.TabIndex = 24;
            this.searchImage.TabStop = false;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Segoe UI Semilight", 16F);
            this.searchTextbox.Location = new System.Drawing.Point(147, 31);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(309, 36);
            this.searchTextbox.TabIndex = 23;
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 100);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(150, 600);
            this.leftPanel.TabIndex = 3;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(750, 100);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(150, 600);
            this.rightPanel.TabIndex = 4;
            // 
            // dialogsContainer
            // 
            this.dialogsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogsContainer.Location = new System.Drawing.Point(150, 100);
            this.dialogsContainer.Name = "dialogsContainer";
            this.dialogsContainer.Size = new System.Drawing.Size(600, 600);
            this.dialogsContainer.TabIndex = 5;
            // 
            // DialogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dialogsContainer);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "DialogsControl";
            this.Size = new System.Drawing.Size(900, 700);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.PictureBox searchImage;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Panel dialogsContainer;
        private ButtonControl connectToDialogButton;
    }
}
