using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace clsLicensing
{
    public class License
    {

        public static string EncryptionKeys()
        {
            return "GBSWorks@123";
        }
        public string encrypt(string clearText)
        {
            string EncryptionKey = EncryptionKeys();
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public string decrypt(string cipherText)
        {
            string EncryptionKey = EncryptionKeys();
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        
        public bool CheckLicensing()
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
                result = cpuInfo;
            }
            catch
            {
            }
            return result;
        }

        private bool CheckDateFormat(string datevalue)
        {
            bool result = false;
            try
            {
                DateTime dateValue = DateTime.Parse(datevalue);
                result = true;
            }
            catch
            {
            }
            return result;
        }

        public string GetLicenseCode(string MachineCode, DateTime dateTime)
        {
            string result = string.Empty;
            try
            {
                string CodeToEncrypt = MachineCode + "_" + dateTime.ToString("MMDDyyyy");
                result = encrypt(CodeToEncrypt);
            }
            catch
            {
            }
            return result;
        }        
        public bool checklicense(string LicenseCode,ref string ErrMsg,bool GetDate,ref DateTime DtEndLicense,ref string MachineCode)
        {
            bool result = false;
            try
            {
                string LicenseValue = decrypt(LicenseCode);
                
                if (!LicenseValue.Contains("_"))                
                {
                    ErrMsg = "Invalid License Code. Please check first";
                    return result;
                }
                else
                {
                    if (LicenseValue.Split('_').Count() > 2)
                    {
                        ErrMsg = "Invalid License Code. Please check first";
                        return result;
                    }
                    string DateValue = LicenseValue.Split('_')[1];
                    MachineCode = LicenseValue.Split('_')[0];

                    DtEndLicense = DateTime.Parse(DateValue);

                    if (MachineCode != GetMachineCode())
                    {
                        ErrMsg = "Machine Code doesn't Match. \nMachineCode:" + GetMachineCode();
                        return result;
                    }
                    else
                    {
                        if (!CheckDateFormat(DateValue))
                        {
                            ErrMsg = "Invalid Date Format. \nDate Value:" + DateValue;
                            return result;
                        }
                        else
                        {
                            if (DateTime.Now > DateTime.Parse(DateValue).AddDays(1))
                            {
                                ErrMsg = "License Expired. \nDate Value:" + DateValue;
                                return result;
                            }else
                            {
                                DtEndLicense = DateTime.Parse(DateValue);
                                result = true;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                ErrMsg = ex.Message;
            }
            return result;
        }
    }
}
