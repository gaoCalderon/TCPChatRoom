namespace Client
{
    partial class Public_Chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Public_Chat));
            this.btnSendMessages = new System.Windows.Forms.Button();
            this.textUserMessageInput = new System.Windows.Forms.TextBox();
            this.txtGroupRecieved = new System.Windows.Forms.RichTextBox();
            this.UserList = new System.Windows.Forms.ListBox();
            this.privateChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendMessages
            // 
            this.btnSendMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessages.Enabled = false;
            this.btnSendMessages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessages.Location = new System.Drawing.Point(508, 408);
            this.btnSendMessages.Name = "btnSendMessages";
            this.btnSendMessages.Size = new System.Drawing.Size(90, 41);
            this.btnSendMessages.TabIndex = 7;
            this.btnSendMessages.Text = "Send";
            this.btnSendMessages.UseVisualStyleBackColor = true;
            // 
            // textUserMessageInput
            // 
            this.textUserMessageInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textUserMessageInput.Location = new System.Drawing.Point(15, 408);
            this.textUserMessageInput.Multiline = true;
            this.textUserMessageInput.Name = "textUserMessageInput";
            this.textUserMessageInput.Size = new System.Drawing.Size(485, 41);
            this.textUserMessageInput.TabIndex = 6;
            // 
            // txtGroupRecieved
            // 
            this.txtGroupRecieved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupRecieved.BackColor = System.Drawing.Color.White;
            this.txtGroupRecieved.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupRecieved.Location = new System.Drawing.Point(15, 12);
            this.txtGroupRecieved.Name = "txtGroupRecieved";
            this.txtGroupRecieved.ReadOnly = true;
            this.txtGroupRecieved.Size = new System.Drawing.Size(583, 390);
            this.txtGroupRecieved.TabIndex = 5;
            this.txtGroupRecieved.Text = "";
            // 
            // UserList
            // 
            this.UserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserList.ContextMenuStrip = this.Menu;
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(604, 12);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(198, 433);
            this.UserList.TabIndex = 4;
            // 
            // privateChatToolStripMenuItem
            // 
            this.privateChatToolStripMenuItem.Image = global::Client.Properties.Resources.Chat_256;
            this.privateChatToolStripMenuItem.Name = "privateChatToolStripMenuItem";
            this.privateChatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.privateChatToolStripMenuItem.Text = "Private Chat";
            this.privateChatToolStripMenuItem.Click += new System.EventHandler(this.privateChatToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateChatToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(153, 48);
            // 
            // Public_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 462);
            this.Controls.Add(this.btnSendMessages);
            this.Controls.Add(this.textUserMessageInput);
            this.Controls.Add(this.txtGroupRecieved);
            this.Controls.Add(this.UserList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Public_Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Chat - ip";
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessages;
        private System.Windows.Forms.TextBox textUserMessageInput;
        private System.Windows.Forms.RichTextBox txtGroupRecieved;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem privateChatToolStripMenuItem;
    }
}