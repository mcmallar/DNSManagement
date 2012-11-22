using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNSManagement
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void btnSetDnsServer_Click(object sender, EventArgs e)
        {
            DNSManagement.Properties.Settings.Default.Server = txtSetDnsServer.Text;
            DNSManagement.Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
