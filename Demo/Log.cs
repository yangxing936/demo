using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //记录本地日志
    public class Log
    {
        public static void SetLog(string msg, string folderName = "Log", string fileName = null, bool isDateFolder = false)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var path = AppDomain.CurrentDomain.BaseDirectory + "\\" + folderName;
            if (isDateFolder)
            {
                path += $"\\{datetime}";
            }
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = datetime;
            }
            string strPath = $"{path}\\{fileName}.txt";
            var contene = $"{datetime}:\t\n\r{msg}";
            using (var fs = new FileStream(strPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                var bytes = Convert.ToByte(msg);
                fs.WriteByte(bytes);
                fs.Close();
            }


        }
    }
}
