using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            var str1 = " Bad Gateway.";

            var index1 = str1.IndexOf("The remote server returned an error: (502) Bad Gateway.");
            if (str1.IndexOf("req:The remote server returned an error: (502) Bad Gateway.") >= 0)
            {

            }

            var aaa = "[{\"id\":\"2\",\"name\":\"星标组\",\"count\":0},{\"id\":\"100\",\"name\":\"测试\",\"count\":2}]";

            var data = JsonConvert.DeserializeObject<List<tags>>(aaa);

            var s = @"https://api.weixin.qq.com/cgi-bin/user/info?access_token='39_rEsmoVoh-kXbL9Hn4JvMXOha1Ti-q8rdlzsMCLezzXNQQ1sK0bKSun-2zf8ohqni4R27sgxikvRzB5At7QZBTfR6JUlEMQb5OG8N9g8itGFSTHHNgQ2WcprOrvbAzOu1mCS-ESgYIMChFCebUYGiACAPTB'&openid=oNbuVwPZ72WrorsZwMGQ6RaQic3I&lang=zh_CN".Replace("'", "");

            var cc = s;


            List<string> list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            var c = "";
            foreach (var item in list)
            {
                c += item + ",";
            }


            var a = c.Substring(0, c.Length - 1);

            var aa = "";


            Console.Read();
        }
        public static string GetUserInfo(List<GetUser> user)
        {
            return "";
        }
    }
    public class GetUser
    {
        public string openid { get; set; }
        public string lang { get; set; }
    }
    public class tags
    {
        public int id { get; set; }
        public string name { get; set; }
        public int count { get; set; }
    }

}
