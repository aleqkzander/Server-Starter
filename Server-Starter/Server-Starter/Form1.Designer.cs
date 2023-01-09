
namespace Server_Starter
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
            this.AutomaticRestartCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.HideProcessCheckBox = new System.Windows.Forms.CheckBox();
            this.ResetConfigurationBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StartServerBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SetupWorldServer = new System.Windows.Forms.Button();
            this.WorldServerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SetupAuthServer = new System.Windows.Forms.Button();
            this.AuthServerTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetupMysqlServerBtn = new System.Windows.Forms.Button();
            this.MySQLTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetupWebServerBtn = new System.Windows.Forms.Button();
            this.WebServerTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.StopServerBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutomaticRestartCheckBox
            // 
            this.AutomaticRestartCheckBox.AutoSize = true;
            this.AutomaticRestartCheckBox.Location = new System.Drawing.Point(6, 42);
            this.AutomaticRestartCheckBox.Name = "AutomaticRestartCheckBox";
            this.AutomaticRestartCheckBox.Size = new System.Drawing.Size(143, 17);
            this.AutomaticRestartCheckBox.TabIndex = 8;
            this.AutomaticRestartCheckBox.Text = "AUTOMATIC RESTART";
            this.AutomaticRestartCheckBox.UseVisualStyleBackColor = true;
            this.AutomaticRestartCheckBox.CheckedChanged += new System.EventHandler(this.AutomaticRestartCheckBox_CheckedChanged);
            // 
            // HideProcessCheckBox
            // 
            this.HideProcessCheckBox.AutoSize = true;
            this.HideProcessCheckBox.Location = new System.Drawing.Point(6, 19);
            this.HideProcessCheckBox.Name = "HideProcessCheckBox";
            this.HideProcessCheckBox.Size = new System.Drawing.Size(106, 17);
            this.HideProcessCheckBox.TabIndex = 9;
            this.HideProcessCheckBox.Text = "HIDE PROCESS";
            this.HideProcessCheckBox.UseVisualStyleBackColor = true;
            this.HideProcessCheckBox.CheckedChanged += new System.EventHandler(this.HideProcessCheckBox_CheckedChanged);
            // 
            // ResetConfigurationBtn
            // 
            this.ResetConfigurationBtn.Location = new System.Drawing.Point(189, 34);
            this.ResetConfigurationBtn.Name = "ResetConfigurationBtn";
            this.ResetConfigurationBtn.Size = new System.Drawing.Size(113, 23);
            this.ResetConfigurationBtn.TabIndex = 10;
            this.ResetConfigurationBtn.Text = "Reset configuration";
            this.ResetConfigurationBtn.UseVisualStyleBackColor = true;
            this.ResetConfigurationBtn.Click += new System.EventHandler(this.ResetConfigurationBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 280);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StopServerBtn);
            this.tabPage1.Controls.Add(this.StartServerBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(323, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StartServerBtn
            // 
            this.StartServerBtn.Location = new System.Drawing.Point(6, 6);
            this.StartServerBtn.Name = "StartServerBtn";
            this.StartServerBtn.Size = new System.Drawing.Size(109, 23);
            this.StartServerBtn.TabIndex = 0;
            this.StartServerBtn.Text = "Start Server";
            this.StartServerBtn.UseVisualStyleBackColor = true;
            this.StartServerBtn.Click += new System.EventHandler(this.StartServerBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.HideProcessCheckBox);
            this.groupBox5.Controls.Add(this.AutomaticRestartCheckBox);
            this.groupBox5.Controls.Add(this.ResetConfigurationBtn);
            this.groupBox5.Location = new System.Drawing.Point(7, 182);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 63);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Generic";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SetupWorldServer);
            this.groupBox4.Controls.Add(this.WorldServerTextBox);
            this.groupBox4.Location = new System.Drawing.Point(164, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 82);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "World";
            // 
            // SetupWorldServer
            // 
            this.SetupWorldServer.Location = new System.Drawing.Point(6, 19);
            this.SetupWorldServer.Name = "SetupWorldServer";
            this.SetupWorldServer.Size = new System.Drawing.Size(139, 23);
            this.SetupWorldServer.TabIndex = 11;
            this.SetupWorldServer.Text = "Setup World-Server";
            this.SetupWorldServer.UseVisualStyleBackColor = true;
            this.SetupWorldServer.Click += new System.EventHandler(this.SetupWorldServer_Click);
            // 
            // WorldServerTextBox
            // 
            this.WorldServerTextBox.Location = new System.Drawing.Point(6, 48);
            this.WorldServerTextBox.Name = "WorldServerTextBox";
            this.WorldServerTextBox.ReadOnly = true;
            this.WorldServerTextBox.Size = new System.Drawing.Size(139, 20);
            this.WorldServerTextBox.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SetupAuthServer);
            this.groupBox3.Controls.Add(this.AuthServerTextBox);
            this.groupBox3.Location = new System.Drawing.Point(164, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 82);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auth";
            // 
            // SetupAuthServer
            // 
            this.SetupAuthServer.Location = new System.Drawing.Point(6, 19);
            this.SetupAuthServer.Name = "SetupAuthServer";
            this.SetupAuthServer.Size = new System.Drawing.Size(139, 23);
            this.SetupAuthServer.TabIndex = 11;
            this.SetupAuthServer.Text = "Setup Auth-Server";
            this.SetupAuthServer.UseVisualStyleBackColor = true;
            this.SetupAuthServer.Click += new System.EventHandler(this.SetupAuthServer_Click);
            // 
            // AuthServerTextBox
            // 
            this.AuthServerTextBox.Location = new System.Drawing.Point(6, 48);
            this.AuthServerTextBox.Name = "AuthServerTextBox";
            this.AuthServerTextBox.ReadOnly = true;
            this.AuthServerTextBox.Size = new System.Drawing.Size(139, 20);
            this.AuthServerTextBox.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetupMysqlServerBtn);
            this.groupBox2.Controls.Add(this.MySQLTextBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 82);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My SQL";
            // 
            // SetupMysqlServerBtn
            // 
            this.SetupMysqlServerBtn.Location = new System.Drawing.Point(6, 19);
            this.SetupMysqlServerBtn.Name = "SetupMysqlServerBtn";
            this.SetupMysqlServerBtn.Size = new System.Drawing.Size(139, 23);
            this.SetupMysqlServerBtn.TabIndex = 11;
            this.SetupMysqlServerBtn.Text = "Setup MySQL-Server";
            this.SetupMysqlServerBtn.UseVisualStyleBackColor = true;
            this.SetupMysqlServerBtn.Click += new System.EventHandler(this.SetupMysqlServerBtn_Click);
            // 
            // MySQLTextBox
            // 
            this.MySQLTextBox.Location = new System.Drawing.Point(6, 48);
            this.MySQLTextBox.Name = "MySQLTextBox";
            this.MySQLTextBox.ReadOnly = true;
            this.MySQLTextBox.Size = new System.Drawing.Size(139, 20);
            this.MySQLTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetupWebServerBtn);
            this.groupBox1.Controls.Add(this.WebServerTextBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 82);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web";
            // 
            // SetupWebServerBtn
            // 
            this.SetupWebServerBtn.Location = new System.Drawing.Point(6, 19);
            this.SetupWebServerBtn.Name = "SetupWebServerBtn";
            this.SetupWebServerBtn.Size = new System.Drawing.Size(139, 23);
            this.SetupWebServerBtn.TabIndex = 11;
            this.SetupWebServerBtn.Text = "Setup Web-Server";
            this.SetupWebServerBtn.UseVisualStyleBackColor = true;
            this.SetupWebServerBtn.Click += new System.EventHandler(this.SetupWebServerBtn_Click);
            // 
            // WebServerTextBox
            // 
            this.WebServerTextBox.Location = new System.Drawing.Point(6, 48);
            this.WebServerTextBox.Name = "WebServerTextBox";
            this.WebServerTextBox.ReadOnly = true;
            this.WebServerTextBox.Size = new System.Drawing.Size(139, 20);
            this.WebServerTextBox.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(323, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // StopServerBtn
            // 
            this.StopServerBtn.Location = new System.Drawing.Point(6, 35);
            this.StopServerBtn.Name = "StopServerBtn";
            this.StopServerBtn.Size = new System.Drawing.Size(109, 23);
            this.StopServerBtn.TabIndex = 1;
            this.StopServerBtn.Text = "Stop Server";
            this.StopServerBtn.UseVisualStyleBackColor = true;
            this.StopServerBtn.Click += new System.EventHandler(this.StopServerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 304);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Server Starter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox AutomaticRestartCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox HideProcessCheckBox;
        private System.Windows.Forms.Button ResetConfigurationBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button StartServerBtn;
        private System.Windows.Forms.Button SetupWebServerBtn;
        private System.Windows.Forms.TextBox WebServerTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SetupMysqlServerBtn;
        private System.Windows.Forms.TextBox MySQLTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SetupAuthServer;
        private System.Windows.Forms.TextBox AuthServerTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SetupWorldServer;
        private System.Windows.Forms.TextBox WorldServerTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button StopServerBtn;
    }
}

