namespace Client
{
    partial class Private_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Private_Chat));
            this.txtGroupRecieved = new System.Windows.Forms.RichTextBox();
            this.textUserMessageInput = new System.Windows.Forms.TextBox();
            this.btnSendMessages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGroupRecieved
            // 
            this.txtGroupRecieved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupRecieved.BackColor = System.Drawing.Color.White;
            this.txtGroupRecieved.Location = new System.Drawing.Point(13, 12);
            this.txtGroupRecieved.Name = "txtGroupRecieved";
            this.txtGroupRecieved.ReadOnly = true;
            this.txtGroupRecieved.Size = new System.Drawing.Size(583, 410);
            this.txtGroupRecieved.TabIndex = 1;
            this.txtGroupRecieved.Text = "";
            // 
            // textUserMessageInput
            // 
            this.textUserMessageInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textUserMessageInput.Location = new System.Drawing.Point(13, 443);
            this.textUserMessageInput.Multiline = true;
            this.textUserMessageInput.Name = "textUserMessageInput";
            this.textUserMessageInput.Size = new System.Drawing.Size(485, 41);
            this.textUserMessageInput.TabIndex = 2;
            // 
            // btnSendMessages
            // 
            this.btnSendMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessages.Enabled = false;
            this.btnSendMessages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessages.Location = new System.Drawing.Point(506, 443);
            this.btnSendMessages.Name = "btnSendMessages";
            this.btnSendMessages.Size = new System.Drawing.Size(90, 41);
            this.btnSendMessages.TabIndex = 3;
            this.btnSendMessages.Text = "Send";
            this.btnSendMessages.UseVisualStyleBackColor = true;
            // 
            // Private_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 509);
            this.Controls.Add(this.btnSendMessages);
            this.Controls.Add(this.textUserMessageInput);
            this.Controls.Add(this.txtGroupRecieved);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Private_Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Private Chat - User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtGroupRecieved;
        private System.Windows.Forms.TextBox textUserMessageInput;
        private System.Windows.Forms.Button btnSendMessages;
    }
}