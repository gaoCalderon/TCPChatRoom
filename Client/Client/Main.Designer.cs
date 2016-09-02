namespace Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblClientUserCreate = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtClientIPAddress = new System.Windows.Forms.TextBox();
            this.lblEnterIP = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClientUserCreate
            // 
            this.lblClientUserCreate.AutoSize = true;
            this.lblClientUserCreate.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientUserCreate.Location = new System.Drawing.Point(30, 33);
            this.lblClientUserCreate.Name = "lblClientUserCreate";
            this.lblClientUserCreate.Size = new System.Drawing.Size(181, 20);
            this.lblClientUserCreate.TabIndex = 0;
            this.lblClientUserCreate.Text = "Create User Screen Name : ";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(30, 56);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(337, 20);
            this.txtClientName.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(153, 222);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 43);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtClientIPAddress
            // 
            this.txtClientIPAddress.Location = new System.Drawing.Point(30, 114);
            this.txtClientIPAddress.Name = "txtClientIPAddress";
            this.txtClientIPAddress.Size = new System.Drawing.Size(337, 20);
            this.txtClientIPAddress.TabIndex = 4;
            // 
            // lblEnterIP
            // 
            this.lblEnterIP.AutoSize = true;
            this.lblEnterIP.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterIP.Location = new System.Drawing.Point(30, 91);
            this.lblEnterIP.Name = "lblEnterIP";
            this.lblEnterIP.Size = new System.Drawing.Size(108, 20);
            this.lblEnterIP.TabIndex = 3;
            this.lblEnterIP.Text = "My IP Address : ";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(30, 173);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(337, 20);
            this.txtStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(30, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status : ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 291);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtClientIPAddress);
            this.Controls.Add(this.lblEnterIP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientUserCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Chat - Client";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientUserCreate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtClientIPAddress;
        private System.Windows.Forms.Label lblEnterIP;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

