using System;
using System.Collections.Generic;
using System.IO;
using BusinessLogic;
using DatabaeTransactions;
namespace BusinessLogic
{
    public class Process
    {
        SQLHELPERS dtrans = new SQLHELPERS();   
        string IniFilePath = Environment.CurrentDirectory + "\\Settings.ini";


        BussinessLogic.clsINI ci;

        public List<clsMethods> AvailableMethod()
        {
            List<clsMethods> Result = new List<clsMethods>();
            try
            {
                clsMethods CMethod_CheckMyIni = new clsMethods();
                CMethod_CheckMyIni.MethodName = "CheckMyIniFile";
                List<Parameters> MyParam = new List<Parameters>();
                Parameters Param1 = new Parameters();
                Param1.FieldName = "test";
                Param1.DataType = "bok";
                Param1.Length = 0;
                MyParam.Add(Param1);
                CMethod_CheckMyIni.Parameters = MyParam;
                CMethod_CheckMyIni.Description = "This is to Check Ini File on the system\nDefault Path was on application path, using .ini extension\nSampele: Settings.ini";
                Result.Add(CMethod_CheckMyIni);
            }
            catch
            { 
            }
            return Result;
        }

        //************************

        public bool CheckMyIniFile(ref string ErrMsg)
        {
            bool result = false;    
            try
            {
                if (!File.Exists(IniFilePath))
                {
                    ErrMsg = "Error: Ini file not found. Please check \nFile : " + IniFilePath;
                    return result;
                }
                else
                {
                    result = true;
                }
            }
            catch
            {
            }
            return result;
        }
        public string GetConnectionStringIni()
        {
            string result = string.Empty;
            try
            {
                bool WinAuth = false;
                string WindowsAuthen = ReadMyINI("WindowsAuthentication", "Database");

                string ServerName = ReadMyINI("Servername", "Database");
                string DatabaseName = ReadMyINI("Database", "Database");
                string DBUsername = ReadMyINI("Username", "Database");
                string DBPassword = ReadMyINI("Password", "Database");

                if (!string.IsNullOrEmpty(WindowsAuthen))
                {
                    WinAuth = WindowsAuthen.ToLower() == "true" ? true : false;
                }
                if (WinAuth)
                {
                    result = "data source = " + ServerName + "; " +
                                       "initial catalog = " + DatabaseName + "; persist security info = True; " +
                                       "Integrated Security = SSPI; ";
                }
                else
                {
                    result = "Server=" + ServerName + ";Database=" + DatabaseName + ";User Id=" + DBUsername + ";Password=" + DBPassword + ";";
                }
            }
            catch
            {
            }
            return result;
        }
        public bool CheckMyConnection(string ConnectionString,ref string ErrMsg)
        {
            bool result = false;
            try
            {
                dtrans.ConnectionString = ConnectionString;
                result = dtrans.CheckConnection(dtrans.ConnectionString,ref ErrMsg);
            }
            catch
            {
            }
            return result;
        }
        public bool CheckMyConnection(string Servername,string Databasename,string DBUsername,string DBPassword,ref string ErrMsg)
        {
            bool result = false;

            try
            {
                if(string.IsNullOrEmpty(Servername))
                {
                    ErrMsg = "No Server Define. Cannot connect to database.";
                    return false;
                }
                else if (string.IsNullOrEmpty(Databasename))
                {
                    ErrMsg = "No Database Define. Cannot connect to database.";
                    return false;
                }
                else if (string.IsNullOrEmpty(DBUsername))
                {
                    ErrMsg = "No Database-Username Define. Cannot connect to database.";
                    return false;
                }
                else if (string.IsNullOrEmpty(DBPassword))
                {
                    ErrMsg = "No Database-Password Define. Cannot connect to database.";
                    return false;
                }



                result = dtrans.CheckConnection(dtrans.ConnectionString,ref ErrMsg);

            }
            catch
            {
            }
            return result;
        }

        public bool SaveMyIni(string Fields,string Section,string Value)
        {
            bool result = false;
            try
            {
                ci = new BussinessLogic.clsINI(IniFilePath);
                ci.IniWriteValue(Section, Fields, Value);
                result = true;
            }
            catch (Exception)
            {
                
            }
            return result;
        }
        public string ReadMyINI(string fields,string section)
        {
            ci = new BussinessLogic.clsINI(IniFilePath);
            string result = string.Empty;
            try
            {
                result = ci.IniReadValue(section, fields);
            }
            catch
            {
            }
            return result;
        }
        public bool ValidateLicense(string LicenseCode)
        {
            bool result = false;
            try
            {
                //lic.checklicensefile();
            }
            catch
            { }
            return result;
        }
        public void SaveDatabaseCredentials(string ServerName, string Databasename, string Username, string Password)
        {
            try
            {
                SaveMyIni("Servername", "Database", ServerName);
                SaveMyIni("Databasename", "Database", Databasename);
                SaveMyIni("Username", "Database", Username);
                SaveMyIni("Password", "Database", Password);
            }
            catch
            {
            }
        }
    }
}
