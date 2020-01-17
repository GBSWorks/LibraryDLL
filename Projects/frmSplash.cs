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
using BusinessTransactions;
using Projects.Class;
using Projects.Screens;

namespace Projects
{
    public partial class frmSplash : Form
    {
        clsIni ci;
        Process BussProc = new Process();

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
                    lc.ShowDialog();
                }
                else
                {

                }
            }
            else if (TimerCount == 90)
            {
                lblMessage.Text = "Program Starts...";
            }
        }
    }
}
