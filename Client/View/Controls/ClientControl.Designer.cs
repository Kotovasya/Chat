
namespace Client.View.Controls
{
    partial class ClientControl
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.onlinePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.onlinePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.userNameLabel.Location = new System.Drawing.Point(32, 3);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(103, 23);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Kotovasya";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onlinePicture
            // 
            this.onlinePicture.Image = global::Client.Properties.Resources.offline;
            this.onlinePicture.Location = new System.Drawing.Point(7, 8);
            this.onlinePicture.Name = "onlinePicture";
            this.onlinePicture.Size = new System.Drawing.Size(16, 16);
            this.onlinePicture.TabIndex = 1;
            this.onlinePicture.TabStop = false;
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.onlinePicture);
            this.Controls.Add(this.userNameLabel);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(138, 32);
            ((System.ComponentModel.ISupportInitialize)(this.onlinePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox onlinePicture;
    }
}
