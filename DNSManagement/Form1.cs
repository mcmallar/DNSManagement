using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Collections;

namespace DNSManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grpFilter.Hide();
        }

        private void tabCheckDnsARecords_Enter(object sender, EventArgs e)
        {
            if (cmbZones.Items.Count == 0)
            {
                ObjectQuery query = new ObjectQuery();
                ManagementScope ms = new ManagementScope("\\\\" + txtDnsServer.Text + "\\root\\microsoftdns");
                ms.Connect();

                query = new ObjectQuery("Select Name from MicrosoftDNS_Zone");

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(ms, query);
                ManagementObjectCollection coll = searcher.Get();

                foreach (ManagementObject m in coll)
                {
                    cmbZones.Items.Add(m["Name"]);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvDnsARecords.Rows.Clear();

            if (cmbZones.Text == "")
            {
                MessageBox.Show("Please select zone.");
            }
            else
            {
                ObjectQuery query = new ObjectQuery();
                ManagementScope ms = new ManagementScope("\\\\" + txtDnsServer.Text + "\\root\\microsoftdns");
                ms.Connect();

                query = new ObjectQuery("Select * from MicrosoftDNS_AType where ContainerName = '" + cmbZones.Text + "'");

                try
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(ms, query);
                    ManagementObjectCollection coll = searcher.Get();
                    Cursor.Current = Cursors.WaitCursor;

                    foreach (ManagementObject m in coll)
                    {
                        double hours = Convert.ToDouble(m["TimeStamp"]);
                        string timestamp;

                        if (hours == 0)
                            timestamp = "Static";
                        else
                        {
                            DateTime ts = new DateTime();
                            ts = Convert.ToDateTime("1/1/1601 01:00:00 AM");
                            ts = ts.AddHours(hours);
                            timestamp = ts.ToString();
                        }

                        if (txtFilter.Text == "")
                            dgvDnsARecords.Rows.Add(m["IPAddress"], m["OwnerName"], m["DnsServerName"], timestamp, m["TTL"]);
                        else
                        {
                            string name = m["OwnerName"].ToString();
                            int dotLocation = name.IndexOf(".");
                            name = name.Substring(0, dotLocation);
                            if (name.IndexOf(txtFilter.Text) > -1)
                                dgvDnsARecords.Rows.Add(m["IPAddress"], m["OwnerName"], m["DnsServerName"], timestamp, m["TTL"]);
                        }
                    }
                }

                catch
                {
                    MessageBox.Show("A wrong query statement was entered. Please revise and try again.");
                }

 

                Cursor.Current = Cursors.Default;
            }
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilter.Checked == true)
                grpFilter.Show();
            else
            {
                grpFilter.Hide();
                txtFilter.Clear();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            dgvOrphans.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dnsServer = DNSManagement.Properties.Settings.Default.Server;
            if (dnsServer == "")
            {
                Form Server = new Server();
                Server.ShowDialog();
            }
            txtDnsServer.Text = DNSManagement.Properties.Settings.Default.Server;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            DNSManagement.Properties.Settings.Default.Server = txtDnsServer.Text;
            DNSManagement.Properties.Settings.Default.Save();
            btnSaveSettings.Text = "Saved";
        }

        private void tabSettings_Leave(object sender, EventArgs e)
        {
            btnSaveSettings.Text = "Save";
        }
    }
}
