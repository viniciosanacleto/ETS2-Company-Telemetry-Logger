using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETS2_Company_Telemetry_Logger
{
    public partial class Settings : Form
    {
        FolderBrowserDialog logP = new FolderBrowserDialog();

        public Settings()
        {
            InitializeComponent();
            txt_logPath.Text = Properties.Settings.Default.LogPath;
        }

        private void button2_Click(object sender, EventArgs e) //Cancel Button
        {
            this.Close();
        }

        private void bt_logPath_Click(object sender, EventArgs e)
        {            
            logP.ShowDialog();
            txt_logPath.Text = logP.SelectedPath;
        }

        private void bt_apply_Click(object sender, EventArgs e) //Apply Button
        {
            Properties.Settings.Default.LogPath = logP.SelectedPath;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
