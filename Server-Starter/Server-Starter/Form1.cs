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
using System.Threading;

namespace Server_Starter
{
    public partial class Form1 : Form
    {
        private bool hideProcess;
        private string serverWeb;
        private string serverSql;
        private string serverAuth;
        private string serverWorld;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // get properties
            hideProcess = Properties.Settings.Default.hide_process;
            serverWeb = Properties.Settings.Default.webserver_dir;
            serverSql = Properties.Settings.Default.mysql_dir;
            serverAuth = Properties.Settings.Default.auth_dir;
            serverWorld = Properties.Settings.Default.world_dir;

            // set in form
            HideProcessCheckBox.Checked = hideProcess;
            WebServerTextBox.Text = serverWeb;
            MySQLTextBox.Text = serverSql;
            AuthServerTextBox.Text = serverAuth;
            WorldServerTextBox.Text = serverWorld;
        }


        #region METHODS

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


        /// <summary>
        /// Use this method to start a process
        /// </summary>
        /// <param name="executable"></param>
        private Process StartProcess(string executable)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.WorkingDirectory = Path.GetDirectoryName(executable);
                info.Arguments = "--console";
                info.FileName = executable;
                if (hideProcess) { info.WindowStyle = ProcessWindowStyle.Hidden; info.CreateNoWindow = true; }
                else { info.WindowStyle = ProcessWindowStyle.Normal; info.CreateNoWindow = false; }
                Process process = Process.Start(info);
                return process;
            }
            catch
            {
                MessageBox.Show("Error on starting");
                return null;
            }
        }


        /// <summary>
        /// Use this method to stop a process 
        /// </summary>
        /// <param name="process"></param>
        private void KillProcess(string process)
        {
            try
            {
                foreach (var kill in Process.GetProcessesByName(process))
                {
                    kill.Kill();
                }
            }
            catch
            {

            }
        }

        #endregion


        #region CONFIGURATION

        private void SetupWebServerBtn_Click(object sender, EventArgs e)
        {
            // search for httpd
            ConfigureSearch("httpd.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // exe from dialog
                serverWeb = openFileDialog.FileName;
                // worldserver path on settings
                Properties.Settings.Default.webserver_dir = serverWeb;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                WebServerTextBox.Text = serverWeb;
            }
        }


        private void SetupMysqlServerBtn_Click(object sender, EventArgs e)
        {
            // search for mysqld
            ConfigureSearch("mysqld.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // path from dialog
                serverSql = openFileDialog.FileName;
                // mysqlserver path on settings
                Properties.Settings.Default.mysql_dir = serverSql;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                MySQLTextBox.Text = serverSql;
            }
        }


        private void SetupAuthServer_Click(object sender, EventArgs e)
        {
            // search for auth
            ConfigureSearch("authserver.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // path from dialog
                serverAuth = openFileDialog.FileName;
                // authserver path on settings
                Properties.Settings.Default.auth_dir = serverAuth;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                AuthServerTextBox.Text = serverAuth;
            }
        }


        private void SetupWorldServer_Click(object sender, EventArgs e)
        {
            // search for world
            ConfigureSearch("worldserver.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // path from dialog
                serverWorld = openFileDialog.FileName;
                // worldserver path on settings
                Properties.Settings.Default.world_dir = serverWorld;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                WorldServerTextBox.Text = serverWorld;
            }
        }


        private void HideProcessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.hide_process = Convert.ToBoolean(HideProcessCheckBox.CheckState);
            Properties.Settings.Default.Save();
        }


        private void ResetConfigurationBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Exit();
        }

        #endregion


        #region START/STOP SERVER

        private void MySQLBtn_Click(object sender, EventArgs e)
        {
            // start sql
            StartProcess(serverSql);

            // enable web
            WebserverBtn.Enabled = true;

            // log console
            ConsoleTextBox.Clear();
            ConsoleTextBox.Text = "> Start Web-Server now...";
        }


        private void WebserverBtn_Click(object sender, EventArgs e)
        {
            // start web
            StartProcess(serverWeb);

            // enable auth
            AuthServerBtn.Enabled = true;

            // log console
            ConsoleTextBox.Clear();
            ConsoleTextBox.Text = "> Start Auth-Server now...";
        }


        private void AuthServerBtn_Click(object sender, EventArgs e)
        {
            // start auth
            StartProcess(serverAuth);

            // enable world
            WorldServerBtn.Enabled = true;

            // log console
            ConsoleTextBox.Clear();
            ConsoleTextBox.Text = "> Start World-Server now...";
        }


        private void WorldServerBtn_Click(object sender, EventArgs e)
        {
            // start world
            StartProcess(serverWorld);

            // enable stop
            StopServerBtn.Enabled = true;

            // log console
            ConsoleTextBox.Clear();
            ConsoleTextBox.Text += "> Server is up and running...\n";
            ConsoleTextBox.Text += "> You can stop the server now...\n";

        }


        private void StopServerBtn_Click(object sender, EventArgs e)
        {
            // kill word and disable
            KillProcess("worldserver");
            WorldServerBtn.Enabled = false;

            // kill auth and disable
            KillProcess("authserver");
            AuthServerBtn.Enabled = false;

            // kill httpd and disable
            KillProcess("httpd");
            WebserverBtn.Enabled = false;

            // kill mysql
            KillProcess("mysqld");
            
            // disable stop server
            StopServerBtn.Enabled = false;

            // log console
            ConsoleTextBox.Clear();
            ConsoleTextBox.Text += "> Server stopped...\n";
            ConsoleTextBox.Text += "> Start SQL-Server...\n";
        }

        #endregion

    }
}  
