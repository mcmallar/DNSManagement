namespace DNSManagement
{
    partial class Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSetDnsServer = new System.Windows.Forms.TextBox();
            this.btnSetDnsServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the name of DNS server:";
            // 
            // txtSetDnsServer
            // 
            this.txtSetDnsServer.Location = new System.Drawing.Point(203, 28);
            this.txtSetDnsServer.Name = "txtSetDnsServer";
            this.txtSetDnsServer.Size = new System.Drawing.Size(198, 20);
            this.txtSetDnsServer.TabIndex = 1;
            // 
            // btnSetDnsServer
            // 
            this.btnSetDnsServer.Location = new System.Drawing.Point(419, 26);
            this.btnSetDnsServer.Name = "btnSetDnsServer";
            this.btnSetDnsServer.Size = new System.Drawing.Size(75, 23);
            this.btnSetDnsServer.TabIndex = 2;
            this.btnSetDnsServer.Text = "OK";
            this.btnSetDnsServer.UseVisualStyleBackColor = true;
            this.btnSetDnsServer.Click += new System.EventHandler(this.btnSetDnsServer_Click);
            // 
            // Server
            // 
            this.AcceptButton = this.btnSetDnsServer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 80);
            this.Controls.Add(this.btnSetDnsServer);
            this.Controls.Add(this.txtSetDnsServer);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSetDnsServer;
        private System.Windows.Forms.Button btnSetDnsServer;
    }
}