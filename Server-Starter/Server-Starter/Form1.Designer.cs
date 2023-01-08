
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
            this.label1 = new System.Windows.Forms.Label();
            this.StartWebserverBtn = new System.Windows.Forms.Button();
            this.StartMysqlBtn = new System.Windows.Forms.Button();
            this.StartAuthBtn = new System.Windows.Forms.Button();
            this.StartWorldBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetupWebServerBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SetupMysqlBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SetupAuthBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SetupWorldBtn = new System.Windows.Forms.Button();
            this.AutomaticRestart = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Runtime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Starter";
            // 
            // StartWebserverBtn
            // 
            this.StartWebserverBtn.Enabled = false;
            this.StartWebserverBtn.Location = new System.Drawing.Point(6, 19);
            this.StartWebserverBtn.Name = "StartWebserverBtn";
            this.StartWebserverBtn.Size = new System.Drawing.Size(106, 23);
            this.StartWebserverBtn.TabIndex = 1;
            this.StartWebserverBtn.Text = "Start";
            this.StartWebserverBtn.UseVisualStyleBackColor = true;
            this.StartWebserverBtn.Click += new System.EventHandler(this.StartWebserverBtn_Click);
            // 
            // StartMysqlBtn
            // 
            this.StartMysqlBtn.Enabled = false;
            this.StartMysqlBtn.Location = new System.Drawing.Point(6, 19);
            this.StartMysqlBtn.Name = "StartMysqlBtn";
            this.StartMysqlBtn.Size = new System.Drawing.Size(106, 23);
            this.StartMysqlBtn.TabIndex = 2;
            this.StartMysqlBtn.Text = "Start";
            this.StartMysqlBtn.UseVisualStyleBackColor = true;
            this.StartMysqlBtn.Click += new System.EventHandler(this.StartMysqlBtn_Click);
            // 
            // StartAuthBtn
            // 
            this.StartAuthBtn.Enabled = false;
            this.StartAuthBtn.Location = new System.Drawing.Point(6, 19);
            this.StartAuthBtn.Name = "StartAuthBtn";
            this.StartAuthBtn.Size = new System.Drawing.Size(106, 23);
            this.StartAuthBtn.TabIndex = 3;
            this.StartAuthBtn.Text = "Start";
            this.StartAuthBtn.UseVisualStyleBackColor = true;
            this.StartAuthBtn.Click += new System.EventHandler(this.StartAuthBtn_Click);
            // 
            // StartWorldBtn
            // 
            this.StartWorldBtn.Enabled = false;
            this.StartWorldBtn.Location = new System.Drawing.Point(6, 19);
            this.StartWorldBtn.Name = "StartWorldBtn";
            this.StartWorldBtn.Size = new System.Drawing.Size(106, 23);
            this.StartWorldBtn.TabIndex = 4;
            this.StartWorldBtn.Text = "Start";
            this.StartWorldBtn.UseVisualStyleBackColor = true;
            this.StartWorldBtn.Click += new System.EventHandler(this.StartWorldBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetupWebServerBtn);
            this.groupBox1.Controls.Add(this.StartWebserverBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Webserver Control";
            // 
            // SetupWebServerBtn
            // 
            this.SetupWebServerBtn.Location = new System.Drawing.Point(6, 48);
            this.SetupWebServerBtn.Name = "SetupWebServerBtn";
            this.SetupWebServerBtn.Size = new System.Drawing.Size(106, 23);
            this.SetupWebServerBtn.TabIndex = 2;
            this.SetupWebServerBtn.Text = "Setup";
            this.SetupWebServerBtn.UseVisualStyleBackColor = true;
            this.SetupWebServerBtn.Click += new System.EventHandler(this.SetupWebServerBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SetupMysqlBtn);
            this.groupBox2.Controls.Add(this.StartMysqlBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 79);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. My-SQL Control";
            // 
            // SetupMysqlBtn
            // 
            this.SetupMysqlBtn.Location = new System.Drawing.Point(6, 48);
            this.SetupMysqlBtn.Name = "SetupMysqlBtn";
            this.SetupMysqlBtn.Size = new System.Drawing.Size(106, 23);
            this.SetupMysqlBtn.TabIndex = 3;
            this.SetupMysqlBtn.Text = "Setup";
            this.SetupMysqlBtn.UseVisualStyleBackColor = true;
            this.SetupMysqlBtn.Click += new System.EventHandler(this.SetupMysqlBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SetupAuthBtn);
            this.groupBox3.Controls.Add(this.StartAuthBtn);
            this.groupBox3.Location = new System.Drawing.Point(142, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 83);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auth Control";
            // 
            // SetupAuthBtn
            // 
            this.SetupAuthBtn.Location = new System.Drawing.Point(6, 48);
            this.SetupAuthBtn.Name = "SetupAuthBtn";
            this.SetupAuthBtn.Size = new System.Drawing.Size(106, 23);
            this.SetupAuthBtn.TabIndex = 4;
            this.SetupAuthBtn.Text = "Setup";
            this.SetupAuthBtn.UseVisualStyleBackColor = true;
            this.SetupAuthBtn.Click += new System.EventHandler(this.SetupAuthBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SetupWorldBtn);
            this.groupBox4.Controls.Add(this.StartWorldBtn);
            this.groupBox4.Location = new System.Drawing.Point(142, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 79);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "World Control";
            // 
            // SetupWorldBtn
            // 
            this.SetupWorldBtn.Location = new System.Drawing.Point(6, 48);
            this.SetupWorldBtn.Name = "SetupWorldBtn";
            this.SetupWorldBtn.Size = new System.Drawing.Size(106, 23);
            this.SetupWorldBtn.TabIndex = 5;
            this.SetupWorldBtn.Text = "Setup";
            this.SetupWorldBtn.UseVisualStyleBackColor = true;
            this.SetupWorldBtn.Click += new System.EventHandler(this.SetupWorldBtn_Click);
            // 
            // AutomaticRestart
            // 
            this.AutomaticRestart.AutoSize = true;
            this.AutomaticRestart.Location = new System.Drawing.Point(12, 211);
            this.AutomaticRestart.Name = "AutomaticRestart";
            this.AutomaticRestart.Size = new System.Drawing.Size(105, 17);
            this.AutomaticRestart.TabIndex = 8;
            this.AutomaticRestart.Text = "Automatic restart";
            this.AutomaticRestart.UseVisualStyleBackColor = true;
            this.AutomaticRestart.CheckedChanged += new System.EventHandler(this.AutomaticRestart_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(123, 211);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Hide Process";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Runtime
            // 
            this.Runtime.AutoSize = true;
            this.Runtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Runtime.Location = new System.Drawing.Point(129, 9);
            this.Runtime.Name = "Runtime";
            this.Runtime.Size = new System.Drawing.Size(139, 20);
            this.Runtime.TabIndex = 10;
            this.Runtime.Text = "Runtime: 00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 236);
            this.Controls.Add(this.Runtime);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AutomaticRestart);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server Starter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartWebserverBtn;
        private System.Windows.Forms.Button StartMysqlBtn;
        private System.Windows.Forms.Button StartAuthBtn;
        private System.Windows.Forms.Button StartWorldBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetupWebServerBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SetupMysqlBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SetupAuthBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SetupWorldBtn;
        private System.Windows.Forms.CheckBox AutomaticRestart;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label Runtime;
    }
}

