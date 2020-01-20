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
using BusinessLogic;
namespace Projects.Screens
{
    public partial class frmLogin : Form
    {
        Process proc = new Process();

        public bool isDatabaseConnection;

        string ConnectionString = string.Empty;
        string Servername = string.Empty;
        string Username = string.Empty;
        string Password = string.Empty;
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
            tbDBUsername.ReadOnly = tbDBPassword.ReadOnly = cbWinAuth.Checked;
            if (cbWinAuth.Checked)
            {
                tbDBUsername.Text = tbDBPassword.Text = string.Empty;
                proc.SaveMyIni("WindowsAuthentication", "Database", "true");
            }
            else
            {
                proc.SaveMyIni("WindowsAuthentication", "Database", "false");
                LoadDefaults();
            }
        }

        private void LoadDefaults()
        {
            try
            {
                cmbServerName.Text = proc.ReadMyINI("Servername", "Database");
                cmbDatabaseName.Text = proc.ReadMyINI("Database", "Database");
                tbDBUsername.Text =  proc.ReadMyINI("Username", "Database");
                tbDBPassword.Text =  proc.ReadMyINI("Password", "Database");
                if (string.IsNullOrEmpty(proc.ReadMyINI("WindowsAuthentication", "Database")))
                {
                    cbWinAuth.Checked = false;
                }
                else
                {
                    cbWinAuth.Checked = proc.ReadMyINI("WindowsAuthentication", "Database").ToLower()=="true" ? true:false;
                }

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
            if(!isDatabaseConnection)                
                {                    
                    this.Height = 357;
                    tssDBStatus.Text = "STATUS: Database Disconnected";
                }
                else
                {
                    this.Height = 194;
                    tssDBStatus.Text = "STATUS: Database Connected";
                }
            //CheckConnection();
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

        private void button2_Click(object sender, EventArgs e)
        {
            proc.SaveDatabaseCredentials(cmbServerName.Text, cmbDatabaseName.Text, tbDBUsername.Text, tbDBPassword.Text);
            CheckConnection();
        }

        public void CheckConnection()
        {
            string ErrMsg = string.Empty;
            if (cbWinAuth.Checked)
            {
                ConnectionString = "data source = " + cmbServerName.Text + "; " +
                                   "initial catalog = " + cmbDatabaseName.Text + "; persist security info = True; " +
                                   "Integrated Security = SSPI; ";             
            }
            else
            {
                ConnectionString = "Server=" + cmbServerName.Text + ";Database=" + cmbDatabaseName.Text + ";User Id=" + tbDBUsername.Text + ";Password=" + tbDBPassword.Text + ";";
            }

            if (!proc.CheckMyConnection(ConnectionString, ref ErrMsg))
            {
                MessageBox.Show(ErrMsg, "Problem in Database Connection. Please check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Height = 357;
                tssDBStatus.Text = "STATUS: Database Disconnected";
            }
            else
            {
                this.Height = 194;
                tssDBStatus.Text = "STATUS: Database Connected";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tssDBStatus.Text.ToLower().Contains("disconnected"))
            {
                MessageBox.Show("Error: Cannot Login. Database is not connected","Disconnected to Database",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbDBPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
            }
        }
    }
}
