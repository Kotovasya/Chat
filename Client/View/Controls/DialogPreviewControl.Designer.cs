
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
            this.dialogImage = new System.Windows.Forms.PictureBox();
            this.dialogNameLabel = new System.Windows.Forms.Label();
            this.lastMessageLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dialogImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogImage
            // 
            this.dialogImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.dialogImage.ErrorImage = null;
            this.dialogImage.Image = global::Client.Properties.Resources.read_dialog;
            this.dialogImage.Location = new System.Drawing.Point(0, 0);
            this.dialogImage.Name = "dialogImage";
            this.dialogImage.Size = new System.Drawing.Size(64, 64);
            this.dialogImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogImage.TabIndex = 0;
            this.dialogImage.TabStop = false;
            this.dialogImage.Click += new System.EventHandler(this.DialogPreviewControl_Click);
            // 
            // dialogNameLabel
            // 
            this.dialogNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialogNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dialogNameLabel.Location = new System.Drawing.Point(70, 0);
            this.dialogNameLabel.Name = "dialogNameLabel";
            this.dialogNameLabel.Size = new System.Drawing.Size(227, 32);
            this.dialogNameLabel.TabIndex = 2;
            this.dialogNameLabel.Text = "Заголовок";
            this.dialogNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dialogNameLabel.Click += new System.EventHandler(this.DialogPreviewControl_Click);
            // 
            // lastMessageLabel
            // 
            this.lastMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastMessageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastMessageLabel.Location = new System.Drawing.Point(70, 32);
            this.lastMessageLabel.Name = "lastMessageLabel";
            this.lastMessageLabel.Size = new System.Drawing.Size(185, 32);
            this.lastMessageLabel.TabIndex = 3;
            this.lastMessageLabel.Text = "Последнее сообщение";
            this.lastMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastMessageLabel.Click += new System.EventHandler(this.DialogPreviewControl_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(261, 32);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 32);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "00:01";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateLabel.Click += new System.EventHandler(this.DialogPreviewControl_Click);
            // 
            // DialogPreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.lastMessageLabel);
            this.Controls.Add(this.dialogNameLabel);
            this.Controls.Add(this.dialogImage);
            this.Name = "DialogPreviewControl";
            this.Size = new System.Drawing.Size(300, 64);
            ((System.ComponentModel.ISupportInitialize)(this.dialogImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dialogImage;
        private System.Windows.Forms.Label dialogNameLabel;
        private System.Windows.Forms.Label lastMessageLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}
