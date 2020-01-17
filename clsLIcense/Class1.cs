using System;


namespace clsLIcense
{
    public class License
    {
        public string GetMachineCode()
        {
            string result = string.Empty;
            try
            {
                string cpuInfo = string.Empty;
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    if (cpuInfo == "")
                    {
                        //Get only the first CPU's ID
                        cpuInfo = mo.Properties["processorID"].Value.ToString();
                        break;
                    }
                }
                
            }
            catch
            {
            }
            return result;
        }
        public bool checklicense(string LicenseCode)
        {
            bool result = false;
            try
            {
            }

            catch
            {

            }
            return result;
        }
    }
}
