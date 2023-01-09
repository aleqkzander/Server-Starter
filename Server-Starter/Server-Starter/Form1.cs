using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Server_Starter
{
    public partial class Form1 : Form
    {
        private bool hideProcess;
        private bool automaticRestart;
        private string webServer;
        private string mysqlServer;
        private string authServer;
        private string worldServer;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // get properties
            hideProcess = Properties.Settings.Default.hide_process;
            automaticRestart = Properties.Settings.Default.automatic_restart;
            webServer = Properties.Settings.Default.webserver_dir;
            mysqlServer = Properties.Settings.Default.mysql_dir;
            authServer = Properties.Settings.Default.auth_dir;
            worldServer = Properties.Settings.Default.world_dir;

            // set forms
            HideProcessCheckBox.Checked = hideProcess;
            AutomaticRestartCheckBox.Checked = automaticRestart;
            WebServerTextBox.Text = webServer;
            MySQLTextBox.Text = mysqlServer;
            AuthServerTextBox.Text = authServer;
            WorldServerTextBox.Text = worldServer;
        }


        /// <summary>
        /// Configure the openfiledialog
        /// </summary>
        /// <param name="name"></param>
        private void ConfigureSearch(string name)
        {
            openFileDialog.FileName = $"{name}";
            openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = Application.StartupPath;
        }


        private void SetupWebServerBtn_Click(object sender, EventArgs e)
        {
            // search for httpd
            ConfigureSearch("httpd.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // file from dialog
                webServer = openFileDialog.FileName;
                // get path
                FileInfo info = new FileInfo(webServer);
                // worldserver path on settings
                Properties.Settings.Default.world_dir = info.DirectoryName + webServer;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                WebServerTextBox.Text = webServer;
            }
        }


        private void SetupMysqlServerBtn_Click(object sender, EventArgs e)
        {
            // search for mysqld
            ConfigureSearch("mysqld.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // path from dialog
                mysqlServer = openFileDialog.FileName;
                // get path
                FileInfo info = new FileInfo(mysqlServer);
                // mysqlserver path on settings
                Properties.Settings.Default.mysql_dir = info.DirectoryName + mysqlServer;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                MySQLTextBox.Text = mysqlServer;
            }
        }


        private void SetupAuthServer_Click(object sender, EventArgs e)
        {
            // search for auth
            ConfigureSearch("authserver.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // path from dialog
                authServer = openFileDialog.FileName;
                // get path
                FileInfo info = new FileInfo(authServer);
                // authserver path on settings
                Properties.Settings.Default.auth_dir = info.DirectoryName + authServer;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                AuthServerTextBox.Text = authServer;
            }
        }


        private void SetupWorldServer_Click(object sender, EventArgs e)
        {
            // search for world
            ConfigureSearch("worldserver.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // path from dialog
                worldServer = openFileDialog.FileName;
                // get path
                FileInfo info = new FileInfo(worldServer);
                // worldserver path on settings
                Properties.Settings.Default.world_dir = info.DirectoryName + worldServer;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                WorldServerTextBox.Text = worldServer;
            }
        }


        private void HideProcessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.hide_process = Convert.ToBoolean(HideProcessCheckBox.CheckState);
            Properties.Settings.Default.Save();
        }


        private void AutomaticRestartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.automatic_restart = Convert.ToBoolean(AutomaticRestartCheckBox.CheckState);
            Properties.Settings.Default.Save();
        }


        private void ResetConfigurationBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Exit();
        }


        private void StartServerBtn_Click(object sender, EventArgs e)
        {

        }


        private void StopServerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
