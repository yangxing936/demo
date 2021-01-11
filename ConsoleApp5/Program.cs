using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
              new Product(){ Number=2, ProductId=1000, Type=1 },
              new Product(){ Number=3, ProductId=1001, Type=5 },
              new Product(){ Number=1, ProductId=1002, Type=10 }
            };

            List<Product> ProductList = new List<Product>();
            foreach (var item in list)
            {
                int a = item.Number;
                for (int i = 0; i < a; i++)
                {
                    item.Number = 1;
                    ProductList.Add(item);
                }
            }


            //var ccc = HttpUtility.UrlEncode("qFrUQs2xKgYfnGsY9MYID0DwEM8OOk0fOTO1pWPPJd5Wiz5DrEjCgy3oHjafdgn0UYoXZys1ViATZLR/zJI/z/hsKic+tfAU", Encoding.UTF8);
            //var cc = get_uft8("qFrUQs2xKgYfnGsY9MYID0DwEM8OOk0fOTO1pWPPJd5Wiz5DrEjCgy3oHjafdgn0UYoXZys1ViATZLR/zJI/z/hsKic+tfAU");
            //var c = Range.GetDistance(123.1, 31.0635, 120.99, 31.0635) / 1000;
            Console.Read();
        }
        public static string get_uft8(string unicodeString)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            Byte[] encodedBytes = utf8.GetBytes(unicodeString);
            String decodedString = utf8.GetString(encodedBytes);
            return decodedString;
        }
    }


}
