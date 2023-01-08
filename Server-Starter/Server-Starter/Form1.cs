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

namespace Server_Starter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        /// Change button text on press
        /// </summary>
        /// <param name="button"></param>
        private void ChangeButtonText(Button button)
        {
            if (button.Text == "Start") button.Text = "Stop";
            if (button.Text == "Stop") button.Text = "Start";
        }


        #region Webserver
        private void StartWebserverBtn_Click(object sender, EventArgs e)
        {
            
            ChangeButtonText(StartWebserverBtn);

            // Prepare procces
            ProcessStartInfo start = new ProcessStartInfo();
        }

        private void SetupWebServerBtn_Click(object sender, EventArgs e)
        {
            ConfigureSearch("httpd.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string executeable = openFileDialog.FileName;
                Properties.Settings.Default.webserver_dir = executeable;
                Properties.Settings.Default.Save();
                StartWebserverBtn.Enabled = true;
            }
        }
        #endregion


        #region My-Sql
        private void StartMysqlBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonText(StartMysqlBtn);
        }

        private void SetupMysqlBtn_Click(object sender, EventArgs e)
        {
            ConfigureSearch("mysqld.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string executeable = openFileDialog.FileName;
                Properties.Settings.Default.mysql_dir = executeable;
                Properties.Settings.Default.Save();
                StartMysqlBtn.Enabled = true;
            }
        }
        #endregion


        #region Auth
        private void StartAuthBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonText(StartAuthBtn);
        }

        private void SetupAuthBtn_Click(object sender, EventArgs e)
        {
            ConfigureSearch("auth.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string executeable = openFileDialog.FileName;
                Properties.Settings.Default.auth_dir = executeable;
                Properties.Settings.Default.Save();
                StartAuthBtn.Enabled = true;
            }
        }
        #endregion


        #region World
        private void StartWorldBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonText(StartWebserverBtn);
        }

        private void SetupWorldBtn_Click(object sender, EventArgs e)
        {
            ConfigureSearch("world.exe");

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string executeable = openFileDialog.FileName;
                Properties.Settings.Default.world_dir = executeable;
                Properties.Settings.Default.Save();
                StartWorldBtn.Enabled = true;
            }
        }
        #endregion

        #region Check state
        private void AutomaticRestart_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autuomatic_restart = Convert.ToBoolean(AutomaticRestart.CheckState);
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
