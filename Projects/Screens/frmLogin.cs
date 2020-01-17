using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaeTransactions;

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
            tbDBUsername.ReadOnly = tbDBPassword.ReadOnly = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                tbDBUsername.Text = tbDBPassword.Text = string.Empty;
            }
        }

        private void LoadDefaults()
        {
            try
            {
                string myServer = Environment.MachineName;

                DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
                for (int i = 0; i < servers.Rows.Count; i++)
                {
                    if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                    {
                        if ((servers.Rows[i]["InstanceName"] as string) != null)
                            cmbServerName.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                        else
                            cmbServerName.Items.Add(servers.Rows[i]["ServerName"].ToString());
                    }
                }        
            }
            catch
            {
            }
        }

        private void LoadDatabaseAvailable()
        {
            try
            {
                SQLHELPERS SQLHelp = new SQLHELPERS();

                List<string> GetAvailableDatabase = new List<string>();

                GetAvailableDatabase = SQLHelp.GetDatabaseList(cmbServerName.Text);

                cmbDatabaseName.Items.Clear();

                if (GetAvailableDatabase.Count() > 0)
                {
                    foreach (string DatabaseName in GetAvailableDatabase)
                    {
                        cmbDatabaseName.Items.Add(DatabaseName);
                    }
                }
            }
            catch
            {
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbDBUsername.Text = tbDBPassword.Text = string.Empty;
            LoadDefaults();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDefaults();
        }

        private void cmbServerName_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDatabaseAvailable();
        }

        private void cmbServerName_Validating(object sender, CancelEventArgs e)
        {
            LoadDatabaseAvailable();
        }
    }
}
