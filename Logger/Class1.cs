using System;
using System.IO;

namespace Logger
{
    public class clsLogger
    {
        public string GetLogFilePath(string MsgType)
        {
            return Environment.CurrentDirectory + "\\Logs\\" + MsgType + "_" + DateTime.Now.ToString("yyyyddmm") + ".log";
        }
        public bool CheckLogFile(string MsgType)
        {
            bool result = false;
            try
            {
                result = File.Exists(GetLogFilePath(MsgType));
            }
            catch(Exception ex)
            {
                WriteLogs("Unexpected", ex.Message);
            }
            return result;
        }
        public void WriteLogs(string MessageType, string Message)
        {
            string Logfile = GetLogFilePath(MessageType);
            
                using (StreamWriter sw = new StreamWriter(Logfile, true))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-dd-MM hh:mm:ss") + "\t" + Message);
                }
        }
    }
}
