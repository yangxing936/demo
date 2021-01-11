using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramThread
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskClass task = new TaskClass();
            //task.TaskClass1(100);







            Console.Read();
        }
    }
    public class DataRequest
    {
        public int RequestCount { get; set; }
        public int RequestThreadCount { get; set; }
    }

    public class TaskClass
    {
        public void TaskClass1(int Count)
        {
            for (int i = 0; i < Count; i++)
            {
                Task task1 = Task.Run(() =>
                {
                    Console.WriteLine("1:" + Thread.CurrentThread.ManagedThreadId);
                });
                Task task2 = Task.Run(() =>
                {
                    Console.WriteLine("2:" + Thread.CurrentThread.ManagedThreadId);
                });
                Task.WaitAll(task1, task2);
            }

        }
        public void TaskRun(DataRequest item)
        {
            Task.Run(delegate
            {
                if (item.RequestCount > 0 && item.RequestThreadCount > 0 )
                {
                    for (int i = 0; i < item.RequestCount; i++)
                    {
                        Task[] array = new Task[10];
                        for (int j = 0; j < item.RequestThreadCount; j++)
                        {
                            array[j] = Task.Factory.StartNew(delegate
                            {

                            });
                        }
                        Task.WaitAll(array);
                    }
                }
            });
        }
    }
}
