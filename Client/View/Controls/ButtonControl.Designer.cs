
namespace Client.View.Controls
{
    partial class ButtonControl
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
            this.buttonText = new System.Windows.Forms.Label();
            this.buttonImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.buttonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonText
            // 
            this.buttonText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonText.Location = new System.Drawing.Point(35, 0);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(196, 48);
            this.buttonText.TabIndex = 1;
            this.buttonText.Text = "Информация";
            this.buttonText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonText.Click += new System.EventHandler(this.ButtonControl_Click);
            this.buttonText.MouseEnter += new System.EventHandler(this.buttonControl_MouseEnter);
            this.buttonText.MouseLeave += new System.EventHandler(this.buttonControl_MouseLeave);
            this.buttonText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonControl_MouseMove);
            // 
            // buttonImage
            // 
            this.buttonImage.Image = global::Client.Properties.Resources.close_window;
            this.buttonImage.Location = new System.Drawing.Point(16, 0);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(32, 48);
            this.buttonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonImage.TabIndex = 0;
            this.buttonImage.TabStop = false;
            this.buttonImage.Click += new System.EventHandler(this.ButtonControl_Click);
            this.buttonImage.MouseEnter += new System.EventHandler(this.buttonControl_MouseEnter);
            this.buttonImage.MouseLeave += new System.EventHandler(this.buttonControl_MouseLeave);
            this.buttonImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonControl_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 2;
            // 
            // ButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.buttonText);
            this.Name = "ButtonControl";
            this.Size = new System.Drawing.Size(250, 64);
            this.MouseEnter += new System.EventHandler(this.buttonControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.buttonControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonControl_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.buttonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonImage;
        private System.Windows.Forms.Label buttonText;
        private System.Windows.Forms.Panel panel1;
    }
}
