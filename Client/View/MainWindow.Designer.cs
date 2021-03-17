
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.messagesContainer = new System.Windows.Forms.Panel();
            this.usersContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(165, 488);
            this.messageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(730, 76);
            this.messageBox.TabIndex = 2;
            this.messageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBox_KeyDown);
            // 
            // messagesContainer
            // 
            this.messagesContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagesContainer.Location = new System.Drawing.Point(165, 16);
            this.messagesContainer.Name = "messagesContainer";
            this.messagesContainer.Size = new System.Drawing.Size(730, 449);
            this.messagesContainer.TabIndex = 3;
            this.messagesContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.messagesContainer_ControlAdded);
            // 
            // usersContainer
            // 
            this.usersContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usersContainer.Location = new System.Drawing.Point(12, 16);
            this.usersContainer.Name = "usersContainer";
            this.usersContainer.Size = new System.Drawing.Size(140, 548);
            this.usersContainer.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.usersContainer);
            this.Controls.Add(this.messagesContainer);
            this.Controls.Add(this.messageBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Panel messagesContainer;
        private System.Windows.Forms.Panel usersContainer;
    }
}