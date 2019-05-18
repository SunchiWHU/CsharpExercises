using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class OrderDetails
    {
        public static List<Order> orders = new List<Order>();
        public static List<Order> adds(Order order)
        {
            orders.Add(order);
            return orders;
        }
        public static List<Order> edits(Order order)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].Id == order.Id)
                {
                    orders[i] = order;
                }
               
            }
            return orders;
        }
        public static List<Order> dels(int Id)
        {
            for (int i = 0; i<orders.Count; i++)
            {
                if (orders[i].Id == Id)
                {
                    orders.Remove(orders[i]);
                }

}
            return orders;
        }

        public static List<Order> select(int Id) => orders.Where(m => m.Id == Id).ToList();

        public static List<Order> list() => orders;
    }
}
