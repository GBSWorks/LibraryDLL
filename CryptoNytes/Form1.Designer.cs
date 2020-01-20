namespace CryptoNytes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbLicenseCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEndDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomDays = new System.Windows.Forms.TextBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMachineCode = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbEndValid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbLicCode = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbMacCode = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 257);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbLicenseCode);
            this.groupBox3.Location = new System.Drawing.Point(6, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 46);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "License Code";
            // 
            // tbLicenseCode
            // 
            this.tbLicenseCode.Location = new System.Drawing.Point(7, 18);
            this.tbLicenseCode.Name = "tbLicenseCode";
            this.tbLicenseCode.ReadOnly = true;
            this.tbLicenseCode.Size = new System.Drawing.Size(464, 20);
            this.tbLicenseCode.TabIndex = 8;
            this.tbLicenseCode.Click += new System.EventHandler(this.tbLicenseCode_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEndDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbCustomDays);
            this.groupBox2.Controls.Add(this.cmbDays);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Validity";
            // 
            // tbEndDate
            // 
            this.tbEndDate.Location = new System.Drawing.Point(222, 43);
            this.tbEndDate.Name = "tbEndDate";
            this.tbEndDate.ReadOnly = true;
            this.tbEndDate.Size = new System.Drawing.Size(200, 20);
            this.tbEndDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Custom:";
            // 
            // tbCustomDays
            // 
            this.tbCustomDays.Location = new System.Drawing.Point(57, 45);
            this.tbCustomDays.Name = "tbCustomDays";
            this.tbCustomDays.ReadOnly = true;
            this.tbCustomDays.Size = new System.Drawing.Size(76, 20);
            this.tbCustomDays.TabIndex = 2;
            this.tbCustomDays.Text = "0";
            this.tbCustomDays.Click += new System.EventHandler(this.tbCustomDays_Click);
            this.tbCustomDays.TextChanged += new System.EventHandler(this.tbCustomDays_TextChanged);
            this.tbCustomDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCustomDays_KeyDown);
            this.tbCustomDays.Leave += new System.EventHandler(this.tbCustomDays_Leave);
            // 
            // cmbDays
            // 
            this.cmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Items.AddRange(new object[] {
            "1",
            "30",
            "60",
            "180",
            "365",
            "CUSTOM"});
            this.cmbDays.Location = new System.Drawing.Point(57, 20);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(75, 21);
            this.cmbDays.TabIndex = 1;
            this.cmbDays.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day(s):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMachineCode);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Machine Code here";
            // 
            // tbMachineCode
            // 
            this.tbMachineCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMachineCode.Location = new System.Drawing.Point(6, 19);
            this.tbMachineCode.Name = "tbMachineCode";
            this.tbMachineCode.Size = new System.Drawing.Size(464, 26);
            this.tbMachineCode.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Check Now";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbEndValid);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(7, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(476, 54);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date Validity";
            // 
            // tbEndValid
            // 
            this.tbEndValid.Location = new System.Drawing.Point(69, 19);
            this.tbEndValid.Name = "tbEndValid";
            this.tbEndValid.ReadOnly = true;
            this.tbEndValid.Size = new System.Drawing.Size(200, 20);
            this.tbEndValid.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "End Date:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.tbLicCode);
            this.groupBox5.Location = new System.Drawing.Point(7, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(476, 86);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Enter License Code here";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // tbLicCode
            // 
            this.tbLicCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLicCode.Location = new System.Drawing.Point(6, 19);
            this.tbLicCode.Name = "tbLicCode";
            this.tbLicCode.Size = new System.Drawing.Size(464, 26);
            this.tbLicCode.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbMacCode);
            this.groupBox6.Location = new System.Drawing.Point(7, 103);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(476, 44);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Machine Code";
            // 
            // tbMacCode
            // 
            this.tbMacCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMacCode.Location = new System.Drawing.Point(6, 14);
            this.tbMacCode.Name = "tbMacCode";
            this.tbMacCode.ReadOnly = true;
            this.tbMacCode.Size = new System.Drawing.Size(464, 26);
            this.tbMacCode.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 272);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GBS License Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMachineCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbEndDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLicenseCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbEndValid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbLicCode;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbMacCode;
    }
}

