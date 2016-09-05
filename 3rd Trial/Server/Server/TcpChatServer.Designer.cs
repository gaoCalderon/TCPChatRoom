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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TcpChatServer));
            this.btnTurnOnServer = new System.Windows.Forms.Button();
            this.ReviewMessageBox = new System.Windows.Forms.ListBox();
            this.txtTypeMessagesHere = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTurnOnServer
            // 
            this.btnTurnOnServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTurnOnServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOnServer.Location = new System.Drawing.Point(533, 22);
            this.btnTurnOnServer.Name = "btnTurnOnServer";
            this.btnTurnOnServer.Size = new System.Drawing.Size(98, 70);
            this.btnTurnOnServer.TabIndex = 0;
            this.btnTurnOnServer.Text = "TurnOn Server";
            this.btnTurnOnServer.UseVisualStyleBackColor = false;
            this.btnTurnOnServer.Click += new System.EventHandler(this.btnTurnOnServer_Click);
            // 
            // ReviewMessageBox
            // 
            this.ReviewMessageBox.FormattingEnabled = true;
            this.ReviewMessageBox.Location = new System.Drawing.Point(23, 22);
            this.ReviewMessageBox.Name = "ReviewMessageBox";
            this.ReviewMessageBox.Size = new System.Drawing.Size(504, 212);
            this.ReviewMessageBox.TabIndex = 1;
            // 
            // txtTypeMessagesHere
            // 
            this.txtTypeMessagesHere.Location = new System.Drawing.Point(23, 240);
            this.txtTypeMessagesHere.Name = "txtTypeMessagesHere";
            this.txtTypeMessagesHere.Size = new System.Drawing.Size(504, 20);
            this.txtTypeMessagesHere.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(533, 207);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 52);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // TcpChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 451);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtTypeMessagesHere);
            this.Controls.Add(this.ReviewMessageBox);
            this.Controls.Add(this.btnTurnOnServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TcpChatServer";
            this.Text = "Tcp Chat Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTurnOnServer;
        private System.Windows.Forms.ListBox ReviewMessageBox;
        private System.Windows.Forms.TextBox txtTypeMessagesHere;
        private System.Windows.Forms.Button btnSend;
    }
}

