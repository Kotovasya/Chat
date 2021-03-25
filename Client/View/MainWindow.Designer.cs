
namespace Client.View
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeImage = new System.Windows.Forms.PictureBox();
            this.restoreImage = new System.Windows.Forms.PictureBox();
            this.closeImage = new System.Windows.Forms.PictureBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.minimizeImage);
            this.topPanel.Controls.Add(this.restoreImage);
            this.topPanel.Controls.Add(this.closeImage);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1250, 32);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // minimizeImage
            // 
            this.minimizeImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeImage.Image = global::Client.Properties.Resources.minimize_window;
            this.minimizeImage.InitialImage = global::Client.Properties.Resources.minimize_window;
            this.minimizeImage.Location = new System.Drawing.Point(1152, 0);
            this.minimizeImage.Name = "minimizeImage";
            this.minimizeImage.Size = new System.Drawing.Size(32, 30);
            this.minimizeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeImage.TabIndex = 2;
            this.minimizeImage.TabStop = false;
            this.minimizeImage.Click += new System.EventHandler(this.minimizeImage_Click);
            this.minimizeImage.MouseEnter += new System.EventHandler(this.topPanelImage_MouseEnter);
            this.minimizeImage.MouseLeave += new System.EventHandler(this.topPanelImage_MouseLeave);
            this.minimizeImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanelImage_MouseMove);
            // 
            // restoreImage
            // 
            this.restoreImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.restoreImage.Image = global::Client.Properties.Resources.full_window;
            this.restoreImage.InitialImage = global::Client.Properties.Resources.full_window;
            this.restoreImage.Location = new System.Drawing.Point(1184, 0);
            this.restoreImage.Name = "restoreImage";
            this.restoreImage.Size = new System.Drawing.Size(32, 30);
            this.restoreImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restoreImage.TabIndex = 1;
            this.restoreImage.TabStop = false;
            this.restoreImage.Click += new System.EventHandler(this.restoreImage_Click);
            this.restoreImage.MouseEnter += new System.EventHandler(this.topPanelImage_MouseEnter);
            this.restoreImage.MouseLeave += new System.EventHandler(this.topPanelImage_MouseLeave);
            this.restoreImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanelImage_MouseMove);
            // 
            // closeImage
            // 
            this.closeImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeImage.Image = global::Client.Properties.Resources.close_window;
            this.closeImage.InitialImage = global::Client.Properties.Resources.close_window;
            this.closeImage.Location = new System.Drawing.Point(1216, 0);
            this.closeImage.Name = "closeImage";
            this.closeImage.Size = new System.Drawing.Size(32, 30);
            this.closeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeImage.TabIndex = 0;
            this.closeImage.TabStop = false;
            this.closeImage.Click += new System.EventHandler(this.closeImage_Click);
            this.closeImage.MouseEnter += new System.EventHandler(this.topPanelImage_MouseEnter);
            this.closeImage.MouseLeave += new System.EventHandler(this.topPanelImage_MouseLeave);
            this.closeImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanelImage_MouseMove);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 32);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(250, 708);
            this.menuPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1000, 708);
            this.mainPanel.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 740);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restoreImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox closeImage;
        private System.Windows.Forms.PictureBox minimizeImage;
        private System.Windows.Forms.PictureBox restoreImage;
    }
}