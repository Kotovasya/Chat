
namespace Client.View.Controls
{
    partial class DialogPreviewControl
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
            this.dialogNameLabel = new System.Windows.Forms.Label();
            this.lastMessageLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dialogImage = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dialogImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogNameLabel
            // 
            this.dialogNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.dialogNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dialogNameLabel.Location = new System.Drawing.Point(70, -1);
            this.dialogNameLabel.Name = "dialogNameLabel";
            this.dialogNameLabel.Size = new System.Drawing.Size(227, 23);
            this.dialogNameLabel.TabIndex = 6;
            this.dialogNameLabel.Text = "Заголовок";
            this.dialogNameLabel.Click += new System.EventHandler(this.DialogPreviewControl_Click);
            this.dialogNameLabel.MouseEnter += new System.EventHandler(this.DialogPreviewControl_MouseEnter);
            this.dialogNameLabel.MouseLeave += new System.EventHandler(this.DialogPreviewControl_MouseLeave);
            this.dialogNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogPreviewControl_MouseMove);
            // 
            // lastMessageLabel
            // 
            this.lastMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lastMessageLabel.Location = new System.Drawing.Point(115, 49);
            this.lastMessageLabel.Name = "lastMessageLabel";
            this.lastMessageLabel.Size = new System.Drawing.Size(180, 21);
            this.lastMessageLabel.TabIndex = 7;
            this.lastMessageLabel.Text = "Последнее сообщение";
            this.lastMessageLabel.Click += new System.EventHandler(this.DialogPreviewControl_Click);
            this.lastMessageLabel.MouseEnter += new System.EventHandler(this.DialogPreviewControl_MouseEnter);
            this.lastMessageLabel.MouseLeave += new System.EventHandler(this.DialogPreviewControl_MouseLeave);
            this.lastMessageLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogPreviewControl_MouseMove);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateLabel.Location = new System.Drawing.Point(71, 49);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 19);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "00:01";
            this.dateLabel.SizeChanged += new System.EventHandler(this.dateLabel_SizeChanged);
            this.dateLabel.Click += new System.EventHandler(this.DialogPreviewControl_Click);
            this.dateLabel.MouseEnter += new System.EventHandler(this.DialogPreviewControl_MouseEnter);
            this.dateLabel.MouseLeave += new System.EventHandler(this.DialogPreviewControl_MouseLeave);
            this.dateLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogPreviewControl_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 9;
            // 
            // dialogImage
            // 
            this.dialogImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dialogImage.ErrorImage = null;
            this.dialogImage.Image = global::Client.Properties.Resources.read_dialog;
            this.dialogImage.Location = new System.Drawing.Point(10, 12);
            this.dialogImage.Name = "dialogImage";
            this.dialogImage.Size = new System.Drawing.Size(48, 48);
            this.dialogImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogImage.TabIndex = 10;
            this.dialogImage.TabStop = false;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.authorLabel.Location = new System.Drawing.Point(71, 25);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(225, 20);
            this.authorLabel.TabIndex = 11;
            this.authorLabel.Text = "Kotovasya:";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.authorLabel.Click += new System.EventHandler(this.DialogPreviewControl_Click);
            this.authorLabel.MouseEnter += new System.EventHandler(this.DialogPreviewControl_MouseEnter);
            this.authorLabel.MouseLeave += new System.EventHandler(this.DialogPreviewControl_MouseLeave);
            this.authorLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogPreviewControl_MouseMove);
            // 
            // DialogPreviewControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.dialogImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.lastMessageLabel);
            this.Controls.Add(this.dialogNameLabel);
            this.MaximumSize = new System.Drawing.Size(4000, 72);
            this.Name = "DialogPreviewControl";
            this.Size = new System.Drawing.Size(300, 72);
            this.MouseEnter += new System.EventHandler(this.DialogPreviewControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DialogPreviewControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DialogPreviewControl_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dialogImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dialogNameLabel;
        private System.Windows.Forms.Label lastMessageLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox dialogImage;
        private System.Windows.Forms.Label authorLabel;
    }
}
