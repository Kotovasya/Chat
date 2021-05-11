
namespace Client.View.Controls
{
    partial class MessageControl
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
            this.textLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.editMessageImage = new System.Windows.Forms.PictureBox();
            this.removeMessageImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editMessageImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeMessageImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textLabel.AutoSize = true;
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(3, 27);
            this.textLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(33, 20);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "111";
            this.textLabel.SizeChanged += new System.EventHandler(this.textLabel_SizeChanged);
            this.textLabel.Click += new System.EventHandler(this.MessageControl_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.Location = new System.Drawing.Point(3, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(79, 20);
            this.authorLabel.TabIndex = 3;
            this.authorLabel.Text = "Kotovasya";
            this.authorLabel.SizeChanged += new System.EventHandler(this.authorLabel_SizeChanged);
            this.authorLabel.Click += new System.EventHandler(this.MessageControl_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateLabel.Location = new System.Drawing.Point(84, 3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(90, 20);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Вчера 15:38";
            this.dateLabel.LocationChanged += new System.EventHandler(this.dateLabel_LocationChanged);
            this.dateLabel.SizeChanged += new System.EventHandler(this.dateLabel_LocationChanged);
            this.dateLabel.Click += new System.EventHandler(this.MessageControl_Click);
            // 
            // editMessageImage
            // 
            this.editMessageImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editMessageImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editMessageImage.Image = global::Client.Properties.Resources.edit;
            this.editMessageImage.Location = new System.Drawing.Point(181, 0);
            this.editMessageImage.Name = "editMessageImage";
            this.editMessageImage.Size = new System.Drawing.Size(26, 26);
            this.editMessageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editMessageImage.TabIndex = 4;
            this.editMessageImage.TabStop = false;
            this.editMessageImage.Visible = false;
            this.editMessageImage.Click += new System.EventHandler(this.editMessageImage_Click);
            this.editMessageImage.MouseEnter += new System.EventHandler(this.editMessageImage_MouseEnter);
            this.editMessageImage.MouseLeave += new System.EventHandler(this.editMessageImage_MouseLeave);
            // 
            // removeMessageImage
            // 
            this.removeMessageImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeMessageImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeMessageImage.Image = global::Client.Properties.Resources.delete_message;
            this.removeMessageImage.Location = new System.Drawing.Point(211, 0);
            this.removeMessageImage.Name = "removeMessageImage";
            this.removeMessageImage.Size = new System.Drawing.Size(26, 26);
            this.removeMessageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeMessageImage.TabIndex = 5;
            this.removeMessageImage.TabStop = false;
            this.removeMessageImage.Visible = false;
            this.removeMessageImage.Click += new System.EventHandler(this.removeMessageImage_Click);
            this.removeMessageImage.MouseEnter += new System.EventHandler(this.editMessageImage_MouseEnter);
            this.removeMessageImage.MouseLeave += new System.EventHandler(this.editMessageImage_MouseLeave);
            // 
            // MessageControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.removeMessageImage);
            this.Controls.Add(this.editMessageImage);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.textLabel);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(240, 51);
            this.Click += new System.EventHandler(this.MessageControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.editMessageImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeMessageImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox editMessageImage;
        private System.Windows.Forms.PictureBox removeMessageImage;
    }
}
