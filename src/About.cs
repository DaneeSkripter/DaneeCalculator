using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaneeCalculator
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private UpdateLatest updateLatest;
        private UpdateOld updateOld;
        private void button1_Click(object sender, EventArgs e)
        {
            string currentversion = "1.0.0";
            System.Net.WebClient wc = new System.Net.WebClient();
            string newestversion = wc.DownloadString("https://daneeskripter.xyz/version-check/daneecalc.txt");
            if (currentversion == newestversion)
            {
                updateLatest = new UpdateLatest();
                updateLatest.Show();
            } else
            {
                updateOld = new UpdateOld();
                updateOld.Show();
            }

        }
    }
}
