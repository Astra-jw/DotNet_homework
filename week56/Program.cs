using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods goods1 = new Goods("football", 100);                                          
            Goods goods2 = new Goods("basketball", 150);
            Goods goods3 = new Goods("volleyball", 80);
            Goods goods4 = new Goods("water", 4);
            Goods goods5 = new Goods("chocolate", 5);

            Client client1 = new Client("小明");
            Client client2 = new Client("小华");
            Client client3 = new Client("小兰");

            OrderDetails orderDetail1 = new OrderDetails(goods1, 1);
            OrderDetails orderDetail2 = new OrderDetails(goods2, 2);
            OrderDetails orderDetail3 = new OrderDetails(goods3, 3);
            OrderDetails orderDetail4 = new OrderDetails(goods4, 4);
            OrderDetails orderDetail5 = new OrderDetails(goods5, 5);

            OrderDetails[] orderItems1 = { orderDetail1, orderDetail5 };
            OrderDetails[] orderItems2 = { orderDetail2, orderDetail3 };
            OrderDetails[] orderItems3 = { orderDetail2, orderDetail3, orderDetail4 };

            Order order1 = new Order(1, client1, orderItems1);
            order1.Calculate();
            Order order2 = new Order(2, client2, orderItems2);
            order2.Calculate();
            Order order3 = new Order(3, client3, orderItems3);
            order3.Calculate();

            OrderService orderService = new OrderService();
            orderService.Add(order2);
            orderService.Add(order1);
            orderService.Add(order3);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine();
            Console.Write("默认排序后的订单编号序列: ");
            orderService.Sort();
            orderService.showID();
            Console.WriteLine();
            Console.WriteLine("删除订单编号为3的订单");
            orderService.sub(003);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine("\n");
            Console.WriteLine("查询小华的订单");
            List<Order> porders = orderService.querybyClient("小华");
            foreach (Order order in porders)
            {
                Console.Write(order);
            }
            orderService.Export();
            orderService.Import();
            Console.ReadKey();
        }
    }
}
