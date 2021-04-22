
namespace Client.View
{
    partial class ConnectToDialogWindow
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.connectToDialogButton = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordImage = new System.Windows.Forms.PictureBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameImage = new System.Windows.Forms.PictureBox();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(131, 93);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 35);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // connectToDialogButton
            // 
            this.connectToDialogButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectToDialogButton.Location = new System.Drawing.Point(12, 93);
            this.connectToDialogButton.Name = "connectToDialogButton";
            this.connectToDialogButton.Size = new System.Drawing.Size(104, 35);
            this.connectToDialogButton.TabIndex = 1;
            this.connectToDialogButton.Text = "Подключиться";
            this.connectToDialogButton.UseVisualStyleBackColor = true;
            this.connectToDialogButton.Click += new System.EventHandler(this.connectToDialogButton_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextbox.Location = new System.Drawing.Point(42, 42);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(193, 27);
            this.passwordTextbox.TabIndex = 24;
            this.passwordTextbox.Click += new System.EventHandler(this.Input_Click);
            // 
            // passwordImage
            // 
            this.passwordImage.Image = global::Client.Properties.Resources.password;
            this.passwordImage.Location = new System.Drawing.Point(12, 42);
            this.passwordImage.Name = "passwordImage";
            this.passwordImage.Size = new System.Drawing.Size(24, 24);
            this.passwordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordImage.TabIndex = 23;
            this.passwordImage.TabStop = false;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextbox.Location = new System.Drawing.Point(42, 9);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(193, 27);
            this.nameTextbox.TabIndex = 26;
            this.nameTextbox.Click += new System.EventHandler(this.Input_Click);
            // 
            // nameImage
            // 
            this.nameImage.Image = global::Client.Properties.Resources.create_dialog;
            this.nameImage.Location = new System.Drawing.Point(12, 9);
            this.nameImage.Name = "nameImage";
            this.nameImage.Size = new System.Drawing.Size(24, 24);
            this.nameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nameImage.TabIndex = 25;
            this.nameImage.TabStop = false;
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11F);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(12, 70);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(223, 21);
            this.warningLabel.TabIndex = 27;
            this.warningLabel.Text = "Неверное название диалога";
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warningLabel.Visible = false;
            // 
            // ConnectToDialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 138);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameImage);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordImage);
            this.Controls.Add(this.connectToDialogButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectToDialogWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect to dialog";
            ((System.ComponentModel.ISupportInitialize)(this.passwordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button connectToDialogButton;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.PictureBox passwordImage;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.PictureBox nameImage;
        private System.Windows.Forms.Label warningLabel;
    }
}