using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 56, 861, 45, 68, 48, 52, 45, 96, 42, 454 };
            Console.WriteLine("--------------Array自身方法-----------------");
            Console.WriteLine("Min:{0}", array.Min());
            Console.WriteLine("Max:{0}", array.Max());
            Console.WriteLine("Average:{0}", array.Average());
            Console.WriteLine("sum:{0}", array.Sum());
            Console.WriteLine("---------------内部实现方法------------------");
            int min = Program.Min(array);
            int max = Program.Max(array);
            double? average = Program.Average(array);
            Console.WriteLine("Min:" + min);
            Console.WriteLine("Max:" + max);
            Console.WriteLine("Average:" + average);
            Console.Read();
           
        }
        /// <summary>
        /// 最小值
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Min(int[] array)
        {
            if (array == null) throw new Exception("数组空异常");
            int value = 0;
            bool hasValue = false;
            foreach (int x in array)
            {
                if (hasValue)
                {
                    if (x < value) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw new Exception("没找到");
        }
        /// <summary>
        /// 最大值
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Max(int[] array)
        {
            if (array == null) throw new Exception("数组空异常");
            int value = 0;
            bool hasValue = false;
            foreach (int x in array)
            {
                if (hasValue)
                {
                    if (x > value)
                        value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) return value;
            throw new Exception("没找到");
        }
        /// <summary>
        /// 平均值
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static double? Average(int[] array)
        {
            if (array == null) throw new Exception("数组空异常");
            long sum = 0;
            long count = 0;
            checked
            {
                foreach (int? v in array)
                {
                    if (v != null)
                    {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) return (double)sum / count;
            return null;
        }
    }
}
