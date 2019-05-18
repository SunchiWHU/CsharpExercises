using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 101;//素数的开始
            int count = 0;//素数的个数
            for (i = 101; i <= 200; i++)
            {
                int j = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (j == i)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
           
        }
    }
}
