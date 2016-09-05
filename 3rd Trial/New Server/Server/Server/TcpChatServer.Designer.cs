namespace Server
{
    partial class TcpChatServer
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
            this.TurnOnServer = new System.Windows.Forms.Button();
            this.ReviewMessageBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TurnOnServer
            // 
            this.TurnOnServer.Location = new System.Drawing.Point(465, 31);
            this.TurnOnServer.Name = "TurnOnServer";
            this.TurnOnServer.Size = new System.Drawing.Size(167, 95);
            this.TurnOnServer.TabIndex = 0;
            this.TurnOnServer.Text = "Connect Server";
            this.TurnOnServer.UseVisualStyleBackColor = true;
            this.TurnOnServer.Click += new System.EventHandler(this.TurnOnServer_Click);
            // 
            // ReviewMessageBox
            // 
            this.ReviewMessageBox.FormattingEnabled = true;
            this.ReviewMessageBox.Location = new System.Drawing.Point(28, 26);
            this.ReviewMessageBox.Name = "ReviewMessageBox";
            this.ReviewMessageBox.Size = new System.Drawing.Size(397, 199);
            this.ReviewMessageBox.TabIndex = 1;
            // 
            // TcpChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 444);
            this.Controls.Add(this.ReviewMessageBox);
            this.Controls.Add(this.TurnOnServer);
            this.Name = "TcpChatServer";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TurnOnServer;
        private System.Windows.Forms.ListBox ReviewMessageBox;
    }
}

