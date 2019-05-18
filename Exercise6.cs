using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                OrderService.meun();
                Console.WriteLine("是否继续");
                string id = Console.ReadLine();
                if (id.Equals("n"))
                {
                    break;
                }
            }
        }
    }
}
