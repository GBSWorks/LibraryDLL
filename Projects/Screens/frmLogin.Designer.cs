namespace Projects.Screens
{
    partial class frmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDBStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbDatabaseName = new System.Windows.Forms.ComboBox();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.gbUserAccount = new System.Windows.Forms.GroupBox();
            this.tbDBPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDBUsername = new System.Windows.Forms.TextBox();
            this.cbWinAuth = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbUserAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login User Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Password:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Username:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssDBStatus,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4,
            this.tssDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 133);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(528, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // tssDBStatus
            // 
            this.tssDBStatus.Name = "tssDBStatus";
            this.tssDBStatus.Size = new System.Drawing.Size(178, 17);
            this.tssDBStatus.Text = "STATUS: Database Disconnected";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(176, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "Press F12 to DB Settings";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel4.Text = "   ";
            // 
            // tssDateTime
            // 
            this.tssDateTime.Name = "tssDateTime";
            this.tssDateTime.Size = new System.Drawing.Size(95, 17);
            this.tssDateTime.Text = "00-00-0000 00:00";
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.databaseSettingsToolStripMenuItem.Text = "Database Settings";
            this.databaseSettingsToolStripMenuItem.Click += new System.EventHandler(this.databaseSettingsToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cmbDatabaseName);
            this.groupBox2.Controls.Add(this.cmbServerName);
            this.groupBox2.Controls.Add(this.gbUserAccount);
            this.groupBox2.Controls.Add(this.cbWinAuth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Database Settings";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "&Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbDatabaseName
            // 
            this.cmbDatabaseName.FormattingEnabled = true;
            this.cmbDatabaseName.Location = new System.Drawing.Point(99, 50);
            this.cmbDatabaseName.Name = "cmbDatabaseName";
            this.cmbDatabaseName.Size = new System.Drawing.Size(153, 21);
            this.cmbDatabaseName.TabIndex = 9;
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(99, 24);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(153, 21);
            this.cmbServerName.TabIndex = 8;
            this.cmbServerName.SelectedValueChanged += new System.EventHandler(this.cmbServerName_SelectedValueChanged);
            this.cmbServerName.Validating += new System.ComponentModel.CancelEventHandler(this.cmbServerName_Validating);
            // 
            // gbUserAccount
            // 
            this.gbUserAccount.Controls.Add(this.checkBox1);
            this.gbUserAccount.Controls.Add(this.tbDBPassword);
            this.gbUserAccount.Controls.Add(this.label5);
            this.gbUserAccount.Controls.Add(this.label6);
            this.gbUserAccount.Controls.Add(this.tbDBUsername);
            this.gbUserAccount.Location = new System.Drawing.Point(276, 14);
            this.gbUserAccount.Name = "gbUserAccount";
            this.gbUserAccount.Size = new System.Drawing.Size(222, 105);
            this.gbUserAccount.TabIndex = 7;
            this.gbUserAccount.TabStop = false;
            this.gbUserAccount.Text = "User Credentials";
            // 
            // tbDBPassword
            // 
            this.tbDBPassword.Location = new System.Drawing.Point(84, 56);
            this.tbDBPassword.Name = "tbDBPassword";
            this.tbDBPassword.PasswordChar = '*';
            this.tbDBPassword.ReadOnly = true;
            this.tbDBPassword.Size = new System.Drawing.Size(107, 20);
            this.tbDBPassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "&User Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "&Password:";
            // 
            // tbDBUsername
            // 
            this.tbDBUsername.Location = new System.Drawing.Point(84, 30);
            this.tbDBUsername.Name = "tbDBUsername";
            this.tbDBUsername.ReadOnly = true;
            this.tbDBUsername.Size = new System.Drawing.Size(109, 20);
            this.tbDBUsername.TabIndex = 11;
            // 
            // cbWinAuth
            // 
            this.cbWinAuth.AutoSize = true;
            this.cbWinAuth.Checked = true;
            this.cbWinAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWinAuth.Location = new System.Drawing.Point(99, 77);
            this.cbWinAuth.Name = "cbWinAuth";
            this.cbWinAuth.Size = new System.Drawing.Size(141, 17);
            this.cbWinAuth.TabIndex = 6;
            this.cbWinAuth.Text = "Windows Authentication";
            this.cbWinAuth.UseVisualStyleBackColor = true;
            this.cbWinAuth.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Database Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Server Name:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(84, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 155);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbUserAccount.ResumeLayout(false);
            this.gbUserAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssDateTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbWinAuth;
        private System.Windows.Forms.GroupBox gbUserAccount;
        private System.Windows.Forms.TextBox tbDBPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDBUsername;
        private System.Windows.Forms.ComboBox cmbDatabaseName;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripStatusLabel tssDBStatus;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}