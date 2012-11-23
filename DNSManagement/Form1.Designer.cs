namespace DNSManagement
{
    partial class Form1
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
            this.tabDNS = new System.Windows.Forms.TabControl();
            this.tabCheckDnsARecords = new System.Windows.Forms.TabPage();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.dgvDnsARecords = new System.Windows.Forms.DataGridView();
            this.IpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnsServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZones = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvOrphans = new System.Windows.Forms.DataGridView();
            this.orph_ipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orph_Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orph_dnsServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orph_Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orph_TTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblSettingsSaved = new System.Windows.Forms.GroupBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDnsServer = new System.Windows.Forms.TextBox();
            this.tabDNS.SuspendLayout();
            this.tabCheckDnsARecords.SuspendLayout();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnsARecords)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrphans)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.lblSettingsSaved.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDNS
            // 
            this.tabDNS.Controls.Add(this.tabCheckDnsARecords);
            this.tabDNS.Controls.Add(this.tabPage2);
            this.tabDNS.Controls.Add(this.tabSettings);
            this.tabDNS.Location = new System.Drawing.Point(12, 12);
            this.tabDNS.Name = "tabDNS";
            this.tabDNS.SelectedIndex = 0;
            this.tabDNS.Size = new System.Drawing.Size(864, 632);
            this.tabDNS.TabIndex = 0;
            // 
            // tabCheckDnsARecords
            // 
            this.tabCheckDnsARecords.Controls.Add(this.grpFilter);
            this.tabCheckDnsARecords.Controls.Add(this.chkFilter);
            this.tabCheckDnsARecords.Controls.Add(this.dgvDnsARecords);
            this.tabCheckDnsARecords.Controls.Add(this.btnSelect);
            this.tabCheckDnsARecords.Controls.Add(this.label1);
            this.tabCheckDnsARecords.Controls.Add(this.cmbZones);
            this.tabCheckDnsARecords.Location = new System.Drawing.Point(4, 22);
            this.tabCheckDnsARecords.Name = "tabCheckDnsARecords";
            this.tabCheckDnsARecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckDnsARecords.Size = new System.Drawing.Size(856, 606);
            this.tabCheckDnsARecords.TabIndex = 0;
            this.tabCheckDnsARecords.Text = "Check A Records";
            this.tabCheckDnsARecords.UseVisualStyleBackColor = true;
            this.tabCheckDnsARecords.Enter += new System.EventHandler(this.tabCheckDnsARecords_Enter);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.txtFilter);
            this.grpFilter.Location = new System.Drawing.Point(481, 6);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(369, 65);
            this.grpFilter.TabIndex = 5;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(6, 28);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(357, 20);
            this.txtFilter.TabIndex = 0;
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(427, 18);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(48, 17);
            this.chkFilter.TabIndex = 4;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // dgvDnsARecords
            // 
            this.dgvDnsARecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDnsARecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDnsARecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IpAddress,
            this.owner,
            this.dnsServer,
            this.timeStamp,
            this.ttl});
            this.dgvDnsARecords.Location = new System.Drawing.Point(9, 77);
            this.dgvDnsARecords.Name = "dgvDnsARecords";
            this.dgvDnsARecords.Size = new System.Drawing.Size(841, 523);
            this.dgvDnsARecords.TabIndex = 3;
            // 
            // IpAddress
            // 
            this.IpAddress.HeaderText = "IP Address";
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Width = 83;
            // 
            // owner
            // 
            this.owner.HeaderText = "Owner";
            this.owner.Name = "owner";
            this.owner.Width = 63;
            // 
            // dnsServer
            // 
            this.dnsServer.HeaderText = "DNS Server";
            this.dnsServer.Name = "dnsServer";
            this.dnsServer.Width = 89;
            // 
            // timeStamp
            // 
            this.timeStamp.HeaderText = "Time Stamp";
            this.timeStamp.Name = "timeStamp";
            this.timeStamp.Width = 88;
            // 
            // ttl
            // 
            this.ttl.HeaderText = "TTL (sec)";
            this.ttl.Name = "ttl";
            this.ttl.Width = 78;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(337, 18);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select DNS Zone";
            // 
            // cmbZones
            // 
            this.cmbZones.FormattingEnabled = true;
            this.cmbZones.Location = new System.Drawing.Point(115, 20);
            this.cmbZones.Name = "cmbZones";
            this.cmbZones.Size = new System.Drawing.Size(216, 21);
            this.cmbZones.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvOrphans);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orphaned Records";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvOrphans
            // 
            this.dgvOrphans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrphans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orph_ipAddress,
            this.orph_Owner,
            this.orph_dnsServer,
            this.orph_Timestamp,
            this.orph_TTL});
            this.dgvOrphans.Location = new System.Drawing.Point(6, 59);
            this.dgvOrphans.Name = "dgvOrphans";
            this.dgvOrphans.Size = new System.Drawing.Size(844, 541);
            this.dgvOrphans.TabIndex = 2;
            // 
            // orph_ipAddress
            // 
            this.orph_ipAddress.HeaderText = "IP Address";
            this.orph_ipAddress.Name = "orph_ipAddress";
            // 
            // orph_Owner
            // 
            this.orph_Owner.HeaderText = "Owner";
            this.orph_Owner.Name = "orph_Owner";
            // 
            // orph_dnsServer
            // 
            this.orph_dnsServer.HeaderText = "DNS Server";
            this.orph_dnsServer.Name = "orph_dnsServer";
            // 
            // orph_Timestamp
            // 
            this.orph_Timestamp.HeaderText = "Timestamp";
            this.orph_Timestamp.Name = "orph_Timestamp";
            // 
            // orph_TTL
            // 
            this.orph_TTL.HeaderText = "TTL";
            this.orph_TTL.Name = "orph_TTL";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Checking for orphaned (only TXT entry) in domain";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblSettingsSaved);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(856, 606);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            this.tabSettings.Leave += new System.EventHandler(this.tabSettings_Leave);
            // 
            // lblSettingsSaved
            // 
            this.lblSettingsSaved.Controls.Add(this.btnSaveSettings);
            this.lblSettingsSaved.Controls.Add(this.label3);
            this.lblSettingsSaved.Controls.Add(this.txtDnsServer);
            this.lblSettingsSaved.Location = new System.Drawing.Point(6, 6);
            this.lblSettingsSaved.Name = "lblSettingsSaved";
            this.lblSettingsSaved.Size = new System.Drawing.Size(844, 114);
            this.lblSettingsSaved.TabIndex = 0;
            this.lblSettingsSaved.TabStop = false;
            this.lblSettingsSaved.Text = "Settings";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(303, 17);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DNS Server:";
            // 
            // txtDnsServer
            // 
            this.txtDnsServer.Location = new System.Drawing.Point(97, 19);
            this.txtDnsServer.Name = "txtDnsServer";
            this.txtDnsServer.Size = new System.Drawing.Size(190, 20);
            this.txtDnsServer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 656);
            this.Controls.Add(this.tabDNS);
            this.Name = "Form1";
            this.Text = "DNS Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabDNS.ResumeLayout(false);
            this.tabCheckDnsARecords.ResumeLayout(false);
            this.tabCheckDnsARecords.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnsARecords)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrphans)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.lblSettingsSaved.ResumeLayout(false);
            this.lblSettingsSaved.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDNS;
        private System.Windows.Forms.TabPage tabCheckDnsARecords;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZones;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDnsARecords;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnsServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttl;
        private System.Windows.Forms.DataGridView dgvOrphans;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orph_ipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn orph_Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn orph_dnsServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn orph_Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn orph_TTL;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox lblSettingsSaved;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDnsServer;
        private System.Windows.Forms.Button btnSaveSettings;
    }
}

