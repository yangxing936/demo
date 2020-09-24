using Newtonsoft.Json;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SetStr.Str());
            Console.WriteLine(SetStr.Stt().Result);
            Console.Read();
        }

    }
    public class SetStr
    {
        public static string Str()
        {
            Console.WriteLine("str开始");
            Console.WriteLine();
            var json = "{\"status\":\"1\",\"errorMsg\":\"Sueesss\"}";
            if (string.IsNullOrEmpty(json))
            {
                Console.WriteLine("返回空值");
            }
            try
            {
                var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                if (!(dic["status"].ToString() == "0" && dic["errorMsg"].ToString() == "Success"))
                {
                    Console.WriteLine($"调用接口失败,线程睡眠1分钟继续调用{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
                    Thread.Sleep(1000 * 5);
                    Console.WriteLine($"准备执行作业{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
                    QuartzTimer.Run();
                    return "异步执行";
                }
            }
            catch (Exception)
            {
                Console.WriteLine("解析错误");
            }
            return "";

        }

        public static async Task<string> Stt()
        {
            Console.WriteLine("stt开始");
            for (int i = 100; i < 200; i++)
            {
                Console.Write($"{i}");
            }
            Console.WriteLine();
            return await Task.FromResult("123");
        }
    }


}
