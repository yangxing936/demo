using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Class1
    {
        public async static Task<string> NTss()
        {
            Thread.Sleep(30000);
            return await Task.FromResult("111");
        }
       
    }
}
