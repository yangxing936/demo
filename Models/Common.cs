using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Common
    {
        public static string data(object obj)
        {
            try
            {
                string str = "";
                Dictionary<string, object> dic = new Dictionary<string, object>();
                var list = obj.GetType().GetFields();
                foreach (var item in list)
                {
                    var value = item.GetValue(obj);
                    if (value == null)
                    {
                        continue;
                    }
                    else
                    {
                        dic.Add(item.Name, value);
                    }
                }
                dic.OrderBy(s => s.Key);

                foreach (var item in dic)
                {
                    str += item.Key + "=" + item.Value;
                    str += "&";
                }
                if (string.IsNullOrEmpty(str))
                {
                    return "";
                }
                str = str.Trim('&');
                return str;
            }
            catch (Exception)
            {

                return "";
            }

        }
        public static string Create(string str)
        {
            MD5 md5 = MD5.Create();
            //需要将字符串转成字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择
            byte[] md5buffer = md5.ComputeHash(buffer);
            string strs = null;
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            foreach (byte b in md5buffer)
            {
                //得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                //但是在和对方测试过程中，发现我这边的MD5加密编码，经常出现少一位或几位的问题；
                //后来分析发现是 字符串格式符的问题， X 表示大写， x 表示小写， 
                //X2和x2表示不省略首位为0的十六进制数字；
                strs += b.ToString("x2");
            }
            //MD5类是抽象类
            return strs;
        }

    }
}
