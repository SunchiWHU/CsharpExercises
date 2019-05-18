using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("线程实现5秒休眠");
            Thread t = new Thread(PrintNumbers);
            Thread.Sleep(5000);
            Console.WriteLine("休眠结束，事件开启");
            t.Start();

        }
        static void PrintNumbers()
        {

            Console.WriteLine("{0}Starting...",DateTime.Now.ToLongDateString());
           
        }
    }
}
