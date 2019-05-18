using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入数值A：");
                String num = Console.ReadLine();
                Console.WriteLine("请输入数值B：");
                String nums = Console.ReadLine();
                Console.WriteLine("数值A为{0}，数值B为{1},相乘结果为{2}",num,nums,long.Parse(num)*long.Parse(nums));
            }
            catch (Exception ex)
            {

                throw new NotFiniteNumberException("该数值不是数字！"+ex.Message);
            }
        }
    }
}
