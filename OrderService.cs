using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class OrderService
    {
        public static void meun()
        {
     
            Console.WriteLine("1.添加");
            Console.WriteLine("2.修改");
            Console.WriteLine("3.删除");
            Console.WriteLine("4.查看");
            string i = Console.ReadLine();
            int num = int.Parse(i);
            switch (num)
            {
                case 1:
                    select();
                    OrderDetails.adds(order());
                    break;
                case 2:
                    select();
                    OrderDetails.edits(order());
                    break;
                case 3:
                    Console.WriteLine("请输入编号");
                    string id = Console.ReadLine();
                    int Id = int.Parse(id);
                    OrderDetails.dels(Id);
                    break;
                case 4:
                    select();
                    break;
                default:
                    Console.WriteLine("谢谢使用");
                    break;
            }
        }
        private static Order order()
        {
            Console.WriteLine("请输入编号");
            string id = Console.ReadLine();
            Console.WriteLine("请输入名称");
            string name = Console.ReadLine();
            Console.WriteLine("请输入价格");
            string price = Console.ReadLine();
            Console.WriteLine("请输入数量");
            string nums = Console.ReadLine();
            int Id = int.Parse(id);
            int prices = int.Parse(price);
            int Nums = int.Parse(nums);
            Order orders = new Order();
            orders.name = name;
            orders.Id = Id;
            orders.num = Nums;
            orders.price = prices;
            orders.sum = prices * Nums;
            orders.date = DateTime.Now.ToLongDateString();
            return orders;
        }
        public static void select()
        {
            for (int i = 0; i < OrderDetails.orders.Count; i++)
            {
                Console.Write("编号");
                Console.Write("名称");
                Console.Write("数量");
                Console.Write("价格");
                Console.Write("总价");
                Console.WriteLine("时间");
                Console.Write(OrderDetails.orders[i].Id);
                Console.Write(OrderDetails.orders[i].name);
                Console.Write(OrderDetails.orders[i].num);
                Console.Write(OrderDetails.orders[i].price);
                Console.Write(OrderDetails.orders[i].sum);
                Console.WriteLine(OrderDetails.orders[i].date);
            }
        }





    }
}
