using System;
using System.Collections.Generic;
using System.IO;
using BusinessTransactions.Entity;

namespace BusinessTransactions
{
    public class Process
    {
        string IniFilePath = Environment.CurrentDirectory + "\\Settings.ini";
       
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
        public bool CheckMyConnection(ref string ConnectionString)
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
