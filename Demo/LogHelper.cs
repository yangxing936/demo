using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class LogHelper
    {
        /// <summary>
        /// 记录log
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="folderName"></param>
        /// <param name="fileName"></param>
        /// <param name="isDateFolder">表示目录下按日期分</param>
        public static void Log(string msg, string folderName = "Log", string fileName = null, bool isDateFolder = false)
        {
            try
            {
                List<manjiEnum> manjiEnums = new List<manjiEnum>();
                var date = DateTime.Now.ToString("yyyyMMdd");
                var dir = AppDomain.CurrentDomain.BaseDirectory + "\\" + folderName;
                if (isDateFolder) //表示目录下按日期分
                {
                    dir += $"\\{date}";
                }
                var a = manjiEnums[1].GetType();
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                if (string.IsNullOrEmpty(fileName))
                {
                    fileName = date;
                }
                string strPath = $"{dir}\\{fileName}.txt";
                var content = $"时间：{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\r\n信息：{msg}\r\n\r\n";
                //FileHelper.ShareWrite(strPath, content);
                using (var fs = new FileStream(strPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                {
                    byte[] bty = Encoding.UTF8.GetBytes(content);
                    fs.Write(bty, 0, bty.Length);
                    fs.Close();
                }
            }
            catch (Exception)
            {

              
            }
         

        }
    }
}
