using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Projects.Class;
using Projects.Screens;

namespace Projects
{
    public partial class frmSplash : Form
    {
        clsIni ci;
        Process BussProc = new Process();
        string licenseCode = string.Empty;

        bool isDatabaseConnected = false;
        string IniPath = Environment.CurrentDirectory + "\\Settings.ini";
        int TimerCount = 0;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void LoadBackgroundPicture()
        {
            try
            {
                ci = new clsIni(IniPath);
                string ImageBGPath = ci.IniReadValue("SplashBackground", "System");

                if (string.IsNullOrEmpty(ImageBGPath))
                {
                    ImageBGPath = Environment.CurrentDirectory + "\\Resources\\Background.jpg";
                }

                if (File.Exists(ImageBGPath))
                {
                    pictureBox1.Image = Image.FromFile(ImageBGPath);
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }catch
            {

            }
        }

        private void Initialize()
        {
            LoadBackgroundPicture();
        }
        private void frmSplash_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            TimerCount = TimerCount + 10;
            pbLoadingBar.Value = TimerCount;
            if (TimerCount == 100)
            {
                pbLoadingBar.Value = 100;
                frmLogin Login = new frmLogin();
                Login.isDatabaseConnection = isDatabaseConnected;
                tmrSplash.Enabled = false;
                Login.Show();
                this.Hide();
            }
            else if (TimerCount == 10)
            {
                lblMessage.Text = "Checking Ini File";
                if (!File.Exists(IniPath))
                {
                    lblMessage.Text = "Ini File is Missing";
                    tmrSplash.Enabled = false;
                    MessageBox.Show("Setting File was not found. Please ask your administrator\n" + IniPath, "Error: Please check your Ini First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (TimerCount == 20)
            {
                lblMessage.Text = "Reading Settings File";
                ReadSettings();
            }
            else if (TimerCount == 40)
            {
                lblMessage.Text = "Checking License";
                Process proc = new Process();
                string LicenseCode = proc.ReadMyINI("LicenseCode", "Systems");
                if (string.IsNullOrEmpty(LicenseCode))
                {
                    lblMessage.Text = "License Code is Invalid";
                    tmrSplash.Enabled = false;
                    MessageBox.Show("License Code was not found. Please ask your administrator\n" + IniPath, "Error: Please check your Ini First", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LicenseCode lc = new LicenseCode();
                    lc.licenseCode = licenseCode;
                    lc.ShowDialog();
                    if (lc.licensePassed)
                    {
                        tmrSplash.Enabled = true;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    tmrSplash.Enabled = false;
                    clsLicensing.License lic = new clsLicensing.License();
                    string ErrMsg = string.Empty;
                    DateTime dtEndLicense = DateTime.Now;
                    string MachineCode = string.Empty;
                    if (!lic.checklicense(LicenseCode, ref ErrMsg, true, ref dtEndLicense, ref MachineCode))
                    {
                        MessageBox.Show("Error: " + ErrMsg, "Please ask your administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    else
                    {
                        if (DateTime.Now.Subtract(dtEndLicense).Days <= 30)
                        {
                            int Lapse_day = dtEndLicense.Subtract(DateTime.Now).Days;
                            ErrMsg = "You still have " + Lapse_day + " day(s) to use the software and your copy is nearly to expire. Please renew it before time lapse.";
                            MessageBox.Show("Warning: " + ErrMsg, ". Please check your administrator on this matter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (!proc.SaveMyIni("LicenseCode", "Systems", licenseCode))
                        {
                            MessageBox.Show("Error: Cannot save your license.", "Please check your administrator on this matter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                        tmrSplash.Enabled = true;
                        lblMessage.Text = "License Valid";
                    }
                }
            }
            else if (TimerCount == 60)
            {
                lblMessage.Text = "Checking Database Connection";
                BusinessLogic.Process proc = new BusinessLogic.Process();
                string ErrMsg = string.Empty;
                string ConnectionString = proc.GetConnectionStringIni();
                proc.CheckMyConnection(ConnectionString, ref ErrMsg);
                if (!string.IsNullOrEmpty(ErrMsg))
                {
                    lblMessage.Text = ErrMsg;
                }
                else
                {
                    lblMessage.Text = "Connected to Database : Sucess";
                    isDatabaseConnected = true;
                }
            }
            else if (TimerCount == 70)
            {
                lblMessage.Text = "Preparing Resources";
            }
            else if (TimerCount == 85)
            {
                lblMessage.Text = "Initializing...s";
            }
            else if (TimerCount == 90)
            {
                lblMessage.Text = "Program Starts...";                
            }
        }
        private void ReadSettings()
        {
            try
            {
                Process proc = new Process();
                licenseCode = proc.ReadMyINI("LicenseCode", "Systems");
            }
            catch
            {
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
