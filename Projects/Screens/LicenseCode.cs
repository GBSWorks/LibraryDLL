using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Projects.Screens
{
    public partial class LicenseCode : Form
    {
        public string licenseCode;
        public bool licensePassed;

        clsLicensing.License lic = new clsLicensing.License();
        public LicenseCode()
        {
            InitializeComponent();
        }

        private void LicenseCode_Load(object sender, EventArgs e)
        {
            tbMachineCode.Text = lic.GetMachineCode();
            if(!string.IsNullOrEmpty(licenseCode))
            {
                tbLicenseCode.Text = licenseCode;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLicenseCode.Text))
            {
                MessageBox.Show("Error: Invalid License Code. Please check your administrator on this matter","Invalid Code",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            string ErrMsg = string.Empty;
            DateTime dtEndLicense = DateTime.Now;
            string MachineCode = string.Empty;
            if (!lic.checklicense(tbLicenseCode.Text, ref ErrMsg,false,ref dtEndLicense,ref MachineCode))
            {
                MessageBox.Show("Error: "+ ErrMsg,". Please check your administrator on this matter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(DateTime.Now.Subtract(dtEndLicense).Days <= 30)
            {
                ErrMsg = "Your software copy is nearly expire. Please renew it before time lapse.";
                MessageBox.Show("Warning: " + ErrMsg, ". Please check your administrator on this matter", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            BusinessLogic.Process proc = new BusinessLogic.Process();
            if (!proc.SaveMyIni("LicenseCode", "Systems", tbLicenseCode.Text))
            {
                MessageBox.Show("Error: Cannot save your license.", "Please check your administrator on this matter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }
    }
}
