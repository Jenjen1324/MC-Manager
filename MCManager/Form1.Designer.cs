﻿namespace MCManager
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBackups = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxNewBackup = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRestoreBackup = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMCStart = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPluginManager = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listPlugins = new System.Windows.Forms.ListBox();
            this.tabConfigManager = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label6 = new System.Windows.Forms.Label();
            this.lstConfigs = new System.Windows.Forms.ListBox();
            this.tabNews = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.lblLoginInfo = new System.Windows.Forms.TextBox();
            this.btnLoginInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.tabChangelog = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabBackups.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPluginManager.SuspendLayout();
            this.tabConfigManager.SuspendLayout();
            this.tabNews.SuspendLayout();
            this.tabLoginInfo.SuspendLayout();
            this.tabChangelog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBackups);
            this.tabControl1.Controls.Add(this.tabPluginManager);
            this.tabControl1.Controls.Add(this.tabConfigManager);
            this.tabControl1.Controls.Add(this.tabNews);
            this.tabControl1.Controls.Add(this.tabLoginInfo);
            this.tabControl1.Controls.Add(this.tabChangelog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 362);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabBackups
            // 
            this.tabBackups.Controls.Add(this.panel2);
            this.tabBackups.Controls.Add(this.panel1);
            this.tabBackups.ImageKey = "drop-box-icon.png";
            this.tabBackups.Location = new System.Drawing.Point(4, 42);
            this.tabBackups.Name = "tabBackups";
            this.tabBackups.Size = new System.Drawing.Size(380, 316);
            this.tabBackups.TabIndex = 0;
            this.tabBackups.Text = "Backups";
            this.tabBackups.ToolTipText = "Backups";
            this.tabBackups.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbxNewBackup);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnRestoreBackup);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 275);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // cbxNewBackup
            // 
            this.cbxNewBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewBackup.FormattingEnabled = true;
            this.cbxNewBackup.Items.AddRange(new object[] {
            "New Backup"});
            this.cbxNewBackup.Location = new System.Drawing.Point(234, 8);
            this.cbxNewBackup.Name = "cbxNewBackup";
            this.cbxNewBackup.Size = new System.Drawing.Size(138, 21);
            this.cbxNewBackup.TabIndex = 7;
            this.cbxNewBackup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(234, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(138, 161);
            this.textBox1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Delete Backup";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRestoreBackup
            // 
            this.btnRestoreBackup.Location = new System.Drawing.Point(234, 35);
            this.btnRestoreBackup.Name = "btnRestoreBackup";
            this.btnRestoreBackup.Size = new System.Drawing.Size(138, 23);
            this.btnRestoreBackup.TabIndex = 3;
            this.btnRestoreBackup.Text = "Restore Backup";
            this.btnRestoreBackup.UseVisualStyleBackColor = true;
            this.btnRestoreBackup.Click += new System.EventHandler(this.btnRestoreBackup_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(8, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(220, 267);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxMCStart);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 41);
            this.panel1.TabIndex = 0;
            // 
            // cbxMCStart
            // 
            this.cbxMCStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMCStart.FormattingEnabled = true;
            this.cbxMCStart.Items.AddRange(new object[] {
            "Start Minecraft",
            "without Launcher"});
            this.cbxMCStart.Location = new System.Drawing.Point(177, 12);
            this.cbxMCStart.Name = "cbxMCStart";
            this.cbxMCStart.Size = new System.Drawing.Size(94, 21);
            this.cbxMCStart.TabIndex = 3;
            this.cbxMCStart.SelectedIndexChanged += new System.EventHandler(this.cbxMCStart_SelectedIndexChanged);
            this.cbxMCStart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbxMCStart_MouseDoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Force update?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup Manager";
            // 
            // tabPluginManager
            // 
            this.tabPluginManager.Controls.Add(this.button2);
            this.tabPluginManager.Controls.Add(this.label5);
            this.tabPluginManager.Controls.Add(this.listPlugins);
            this.tabPluginManager.ImageKey = "Plugin.png";
            this.tabPluginManager.Location = new System.Drawing.Point(4, 23);
            this.tabPluginManager.Name = "tabPluginManager";
            this.tabPluginManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPluginManager.Size = new System.Drawing.Size(380, 335);
            this.tabPluginManager.TabIndex = 3;
            this.tabPluginManager.Text = "Plugin Manager";
            this.tabPluginManager.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Import format";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Backup formats:";
            // 
            // listPlugins
            // 
            this.listPlugins.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPlugins.FormattingEnabled = true;
            this.listPlugins.ItemHeight = 17;
            this.listPlugins.Location = new System.Drawing.Point(11, 35);
            this.listPlugins.Name = "listPlugins";
            this.listPlugins.Size = new System.Drawing.Size(238, 276);
            this.listPlugins.TabIndex = 0;
            // 
            // tabConfigManager
            // 
            this.tabConfigManager.Controls.Add(this.button1);
            this.tabConfigManager.Controls.Add(this.propertyGrid1);
            this.tabConfigManager.Controls.Add(this.label6);
            this.tabConfigManager.Controls.Add(this.lstConfigs);
            this.tabConfigManager.ImageKey = "Control Panel.png";
            this.tabConfigManager.Location = new System.Drawing.Point(4, 23);
            this.tabConfigManager.Name = "tabConfigManager";
            this.tabConfigManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfigManager.Size = new System.Drawing.Size(380, 335);
            this.tabConfigManager.TabIndex = 4;
            this.tabConfigManager.Text = "Config Manager";
            this.tabConfigManager.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(146, 33);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(226, 249);
            this.propertyGrid1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Configs:";
            // 
            // lstConfigs
            // 
            this.lstConfigs.FormattingEnabled = true;
            this.lstConfigs.Location = new System.Drawing.Point(12, 33);
            this.lstConfigs.Name = "lstConfigs";
            this.lstConfigs.Size = new System.Drawing.Size(128, 277);
            this.lstConfigs.TabIndex = 0;
            this.lstConfigs.SelectedIndexChanged += new System.EventHandler(this.lstConfigs_SelectedIndexChanged);
            // 
            // tabNews
            // 
            this.tabNews.Controls.Add(this.webBrowser1);
            this.tabNews.ImageKey = "Internet.png";
            this.tabNews.Location = new System.Drawing.Point(4, 23);
            this.tabNews.Name = "tabNews";
            this.tabNews.Size = new System.Drawing.Size(380, 335);
            this.tabNews.TabIndex = 1;
            this.tabNews.Text = "News";
            this.tabNews.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(380, 335);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://mcupdate.tumblr.com/", System.UriKind.Absolute);
            // 
            // tabLoginInfo
            // 
            this.tabLoginInfo.Controls.Add(this.lblLoginInfo);
            this.tabLoginInfo.Controls.Add(this.btnLoginInfo);
            this.tabLoginInfo.Controls.Add(this.label4);
            this.tabLoginInfo.Controls.Add(this.label3);
            this.tabLoginInfo.Controls.Add(this.label2);
            this.tabLoginInfo.Controls.Add(this.txtLoginPassword);
            this.tabLoginInfo.Controls.Add(this.txtLoginName);
            this.tabLoginInfo.ImageKey = "Key.png";
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 42);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(380, 316);
            this.tabLoginInfo.TabIndex = 2;
            this.tabLoginInfo.Text = "Login Info";
            this.tabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.BackColor = System.Drawing.Color.White;
            this.lblLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoginInfo.Location = new System.Drawing.Point(8, 111);
            this.lblLoginInfo.Multiline = true;
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.ReadOnly = true;
            this.lblLoginInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblLoginInfo.Size = new System.Drawing.Size(194, 104);
            this.lblLoginInfo.TabIndex = 5;
            // 
            // btnLoginInfo
            // 
            this.btnLoginInfo.Location = new System.Drawing.Point(75, 82);
            this.btnLoginInfo.Name = "btnLoginInfo";
            this.btnLoginInfo.Size = new System.Drawing.Size(127, 23);
            this.btnLoginInfo.TabIndex = 4;
            this.btnLoginInfo.Text = "Store";
            this.btnLoginInfo.UseVisualStyleBackColor = true;
            this.btnLoginInfo.Click += new System.EventHandler(this.btnLoginInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login info:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(75, 56);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(127, 20);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(75, 30);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(127, 20);
            this.txtLoginName.TabIndex = 1;
            // 
            // tabChangelog
            // 
            this.tabChangelog.Controls.Add(this.richTextBox1);
            this.tabChangelog.ImageKey = "text-file-icon.png";
            this.tabChangelog.Location = new System.Drawing.Point(4, 42);
            this.tabChangelog.Name = "tabChangelog";
            this.tabChangelog.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangelog.Size = new System.Drawing.Size(380, 316);
            this.tabChangelog.TabIndex = 5;
            this.tabChangelog.Text = "Changelog";
            this.tabChangelog.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(364, 312);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Control Panel.png");
            this.imageList1.Images.SetKeyName(1, "drop-box-icon.png");
            this.imageList1.Images.SetKeyName(2, "Internet.png");
            this.imageList1.Images.SetKeyName(3, "Key.png");
            this.imageList1.Images.SetKeyName(4, "text-file-icon.png");
            this.imageList1.Images.SetKeyName(5, "Plugin.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 362);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "MC Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabBackups.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPluginManager.ResumeLayout(false);
            this.tabPluginManager.PerformLayout();
            this.tabConfigManager.ResumeLayout(false);
            this.tabConfigManager.PerformLayout();
            this.tabNews.ResumeLayout(false);
            this.tabLoginInfo.ResumeLayout(false);
            this.tabLoginInfo.PerformLayout();
            this.tabChangelog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBackups;
        private System.Windows.Forms.TabPage tabNews;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRestoreBackup;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Button btnLoginInfo;
        private System.Windows.Forms.TextBox lblLoginInfo;
        private System.Windows.Forms.ComboBox cbxNewBackup;
        private System.Windows.Forms.TabPage tabPluginManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listPlugins;
        private System.Windows.Forms.ComboBox cbxMCStart;
        private System.Windows.Forms.TabPage tabConfigManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstConfigs;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabChangelog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

