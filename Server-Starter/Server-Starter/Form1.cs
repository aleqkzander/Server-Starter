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
        private string webServer;
        private string mysqlServer;
        private string authServer;
        private string worldServer;
        List<Process> processes;
        string state = "loading";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // get properties
            hideProcess = Properties.Settings.Default.hide_process;
            webServer = Properties.Settings.Default.webserver_dir;
            mysqlServer = Properties.Settings.Default.mysql_dir;
            authServer = Properties.Settings.Default.auth_dir;
            worldServer = Properties.Settings.Default.world_dir;

            // set form
            HideProcessCheckBox.Checked = hideProcess;
            WebServerTextBox.Text = webServer;
            MySQLTextBox.Text = mysqlServer;
            AuthServerTextBox.Text = authServer;
            WorldServerTextBox.Text = worldServer;

            // init
            processes = new List<Process>();


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


        /// <summary>
        /// Use this method to start a process
        /// </summary>
        /// <param name="executable"></param>
        private void StartProcess(string executable)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.WorkingDirectory = Path.GetDirectoryName(executable);
            info.Arguments = "--console";
            info.FileName = executable;
            if (hideProcess) { info.WindowStyle = ProcessWindowStyle.Hidden; info.CreateNoWindow = true; }
            else { info.WindowStyle = ProcessWindowStyle.Normal; info.CreateNoWindow = false; } 
            Process process = Process.Start(info);
            processes.Add(process);
        }


        private void ChangeButtonLabelOnClick(Button button, string name)
        {
            button.Text = name;
        }


        private void SetupWebServerBtn_Click(object sender, EventArgs e)
        {
            // search for httpd
            ConfigureSearch("httpd.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // exe from dialog
                webServer = openFileDialog.FileName;
                // worldserver path on settings
                Properties.Settings.Default.webserver_dir = webServer;
                // save settings
                Properties.Settings.Default.Save();
                // set text
                WebServerTextBox.Text = Properties.Settings.Default.webserver_dir;
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
                // mysqlserver path on settings
                Properties.Settings.Default.mysql_dir = mysqlServer;
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
                // authserver path on settings
                Properties.Settings.Default.auth_dir = authServer;
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
                // worldserver path on settings
                Properties.Settings.Default.world_dir = worldServer;
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


        private void ResetConfigurationBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            Application.Exit();
        }


    }
}
