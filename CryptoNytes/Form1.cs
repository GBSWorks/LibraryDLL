using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsLicensing;
namespace CryptoNytes
{
    public partial class Form1 : Form
    {
        clsLicensing.License lic = new clsLicensing.License();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MachineCode = tbMachineCode.Text;

            if (string.IsNullOrEmpty(tbEndDate.Text))
            {
                MessageBox.Show("Error: End-date is invalid. Please select day first.","Invalid End-date",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MachineCode = MachineCode + "_" + tbEndDate.Text;
            tbLicenseCode.Text = lic.encrypt(MachineCode);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            tbCustomDays.Text = "0";
            if (cmbDays.Text == "CUSTOM")
            {
                tbCustomDays.ReadOnly = false;
            }
            else
            {
                tbCustomDays.ReadOnly = true;
                tbEndDate.Text = GetEndDate(dateTimePicker1.Value);
            }
        }

        private void tbCustomDays_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool isInteger(string Value)
        {
            bool result = false;
            try
            {
                int Number = int.Parse(Value);
                result = true;
            }
            catch
            {
            }
            return result;
        }

        private void tbCustomDays_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCustomDays.Text))
            {
                MessageBox.Show("Invalid value. Please enter greater than 0","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tbCustomDays.Focus();
                return;
            }
            tbEndDate.Text = GetEndDate(dateTimePicker1.Value);
        }

        private string GetEndDate(DateTime StartdateTime)
        {
            string result = string.Empty;
            try
            {
                if (tbCustomDays.ReadOnly == false)
                {
                    result = StartdateTime.AddDays(double.Parse(tbCustomDays.Text)).ToString("MM-dd-yyyy");
                }else
                {
                    result = StartdateTime.AddDays(double.Parse(cmbDays.Text)).ToString("MM-dd-yyyy");
                }
            }
            catch
            {
            }
            return result;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tbEndDate.Text = GetEndDate(dateTimePicker1.Value);
        }

        private void tbCustomDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 39 || e.KeyValue == 8 || e.KeyValue == 37)
            {

            }
            else if (e.KeyValue > 59 || e.KeyValue < 48)
            {
                MessageBox.Show("Error: Please input number only.", "Invalid Value. Please check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCustomDays.Text = "";
                tbCustomDays.Focus();
                return;
            }
        }

        private void tbCustomDays_Click(object sender, EventArgs e)
        {
            tbCustomDays.Text = "";
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsLicensing.License lic = new clsLicensing.License();
            string ErrMsg = string.Empty;
            DateTime dtEndLicense = new DateTime();
            string MachineCode = string.Empty;
            if (!lic.checklicense(tbLicCode.Text, ref ErrMsg, true, ref dtEndLicense, ref MachineCode))
            {
                MessageBox.Show("Error: " + ErrMsg, "Error reading INI", MessageBoxButtons.OK, MessageBoxIcon.Error);                               
            }
            tbMacCode.Text = MachineCode;
            tbEndValid.Text = dtEndLicense.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbMachineCode.Text = lic.GetMachineCode();
        }

        private void tbLicenseCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbLicenseCode.Text))
            {
                Clipboard.SetText(tbLicenseCode.Text);
                MessageBox.Show("License Copied");
            }
        }
    }
}
