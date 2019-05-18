using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
       
        static void Main(string[] args)
        {
            primenumberprint();
        }


        /**
         * 该方法利用埃氏筛法查找并输出1--100以内的素数
         * 把不大于根号100的所有素数的倍数剔除，剩下的就是素数。
         * 创建一个数组，将数组标号为合数的值置为1，将数组值为0的数存入primenumber数组，并用foreach遍历输出
         */
        static void primenumberprint()
        {
            int[] number = new int[101];
            int num = 0;
            for (int i = 2; i <= Math.Sqrt(100); i++)
            {
                if (isprimenumber(i))
                    for (int j = 2; j <= 50; j++)
                        if (i * j <= 100)
                            if (number[i * j] == 0)
                            {
                                number[i * j] = 1;
                                num++;
                            }
            }
            int[] primenumber = new int[100 - num];
            int d = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (number[i] == 0)
                {
                    primenumber[d] = i;
                    d++;
                }
            }
            Console.WriteLine("总数：" + (primenumber.Length));
            for (int i = 1; i < primenumber.Length; i++)
            {
                Console.WriteLine(primenumber[i]);
            }
        }


        /**
         * 该方法判断一个数是否是素数
         * @param n 传入一个整数
         * @return
         */
        private static bool isprimenumber(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
