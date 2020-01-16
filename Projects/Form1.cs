using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsLIcense;
using BusinessTransactions;
using BusinessTransactions.Entity;


namespace Projects
{
    public partial class Form1 : Form
    {
        Logger.clsLogger logs = new Logger.clsLogger();
        Process procAvailable = new Process();
        List<clsMethods> ListMethods;

        public Form1()
        {
            InitializeComponent();
        }


        private void LoadMyMethod(ref List<clsMethods>Methods)
        {
            try
            {
                var BindinSourceMethod = new BindingSource();
                Methods = procAvailable.AvailableMethod();
                BindinSourceMethod.DataSource = Methods;
                cmbMethods.DataSource = BindinSourceMethod.DataSource;
                cmbMethods.DisplayMember = "MethodName";
                cmbMethods.ValueMember = "MethodName";
            }
            catch
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListMethods = new List<clsMethods>();
            ListMethods = procAvailable.AvailableMethod();
            clsLIcense.License lic = new clsLIcense.License();
            if (!lic.checklicensefile())
            {
                string filePath = Assembly.GetExecutingAssembly().Location;
                //if No License File, a 30 days trial will apply
                DateTime dtApplicationModDate = new FileInfo(filePath).LastWriteTime; 

                if(DateTime.Now.Subtract(dtApplicationModDate).Days > 30)
                    logs.WriteLogs("Application", "Your 30-days Trial starts");

            }
            LoadMyMethod(ref ListMethods);
        }
        private void ClearControl()
        {
            tbDescription.Text = string.Empty;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearControl();
            
            if (ListMethods.Count > 0)
            {
                var SelectMethod = ListMethods.Where(x => x.MethodName == cmbMethods.SelectedValue.ToString()).FirstOrDefault();
                if (SelectMethod != null)
                {
                    tbDescription.Text = SelectMethod.Description;
                    if (SelectMethod != null)
                    {
                        BindingSource bsParam = new BindingSource();
                        bsParam.DataSource = SelectMethod.Parameters;
                        dgParams.DataSource = bsParam;
                        dgParams.Refresh(); 
                    }
                }
            }
        }
    }
}
