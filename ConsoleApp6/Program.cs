using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //var d = Class1.NTss().Result;
            //Console.WriteLine(d);

            //double a = 29.9;
            //int b = 100;
            //for (int i = 0; i < 100; i++)
            //{
            //    var c = a * b;
            //    Console.WriteLine(c);
            //    Thread.Sleep(500);
            //}

            MyClass my = new MyClass();

            my.MyClassA();

            Console.Read();
        }
    }
    public class MyClass
    {
        public string MyClassA()
        {
            Console.WriteLine("111");
            //异步调用

            Task task1 = new Task(() =>
            {
                this.MyClassC();
            });

            Task task2 = new Task(() =>
            {
                this.MyClassD();
            });

            Task.WaitAll(task1, task2);
            Console.WriteLine("222");
            Console.WriteLine("444");
            Console.WriteLine("555");
            Console.WriteLine("666");
            return "";
        }
        public async void MyClassB()
        {
            await MyClassC();
        }
        public Task<string> MyClassC()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 1000; i++)
                {
                    if (i == 1000)
                    {
                        Console.WriteLine("777");
                    }
                }
                Console.WriteLine("333");
                return "";
            });
        }
        public async void MyClassD()
        {
            await MyClassE();
        }
        public Task<string> MyClassE()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 1000; i++)
                {
                    if (i == 1000)
                    {
                        Console.WriteLine("888");
                    }
                }
                Console.WriteLine("999");
                return "";
            });
        }
    }

}
