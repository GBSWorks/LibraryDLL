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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            tssDateTime.Text = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");
        }

        private void databaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Height == 194)
            {
                this.Height = 357;
            }else
            {
                this.Height = 194;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
                gbUserAccount.Visible = !checkBox1.Checked;            
        }
    }
}
