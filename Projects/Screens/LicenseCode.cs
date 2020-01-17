using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects.Screens
{
    public partial class LicenseCode : Form
    {
        clsLicensing.License lic = new clsLicensing.License();
        public LicenseCode()
        {
            InitializeComponent();
        }

        private void LicenseCode_Load(object sender, EventArgs e)
        {
            tbMachineCode.Text = lic.GetMachineCode();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
