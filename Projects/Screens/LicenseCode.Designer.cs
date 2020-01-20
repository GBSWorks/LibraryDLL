namespace Projects.Screens
{
    partial class LicenseCode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMachineCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLicenseCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warning: You have seen this screen because your License is \"INVALID\". \r\nPlease se" +
    "nd the Machine Code on your administrator to have a new license code.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMachineCode);
            this.groupBox1.Location = new System.Drawing.Point(37, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Details";
            // 
            // tbMachineCode
            // 
            this.tbMachineCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbMachineCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMachineCode.Location = new System.Drawing.Point(6, 17);
            this.tbMachineCode.Name = "tbMachineCode";
            this.tbMachineCode.ReadOnly = true;
            this.tbMachineCode.Size = new System.Drawing.Size(582, 35);
            this.tbMachineCode.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLicenseCode);
            this.groupBox2.Location = new System.Drawing.Point(37, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter your License Code Here";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbLicenseCode
            // 
            this.tbLicenseCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbLicenseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLicenseCode.Location = new System.Drawing.Point(6, 16);
            this.tbLicenseCode.Name = "tbLicenseCode";
            this.tbLicenseCode.Size = new System.Drawing.Size(582, 40);
            this.tbLicenseCode.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LicenseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System : License";
            this.Load += new System.EventHandler(this.LicenseCode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMachineCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLicenseCode;
        private System.Windows.Forms.Button button1;
    }
}