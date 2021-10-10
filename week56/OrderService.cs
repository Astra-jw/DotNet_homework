using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Csharp5
{
    public class OrderService
    {
        private List<Order> _orders = new List<Order>();
        public List<Order> Orders {  get; }

        public OrderService() { }
        public OrderService(List<Order> orders) {
            this._orders = orders;
            Orders = orders;
        }
        public void Sort()
        {
            _orders.Sort((p1, p2) => p1.Order_num - p2.Order_num);
        }
        public void Add(Order order)
        {
            _orders.Add(order);
        }
        public void sub(int id)                                           //根据订单号删除订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in _orders)
                {
                    i++;
                    if (order.Order_num == id)
                    {
                        j = i;
                    }
                }
                _orders.RemoveAt(j);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单删除失败，请检查输入的订单号!");
            }
        }
        public void modify(int id, Order neworder)                           //根据订单号修改订单
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order in _orders)
                {
                    i++;
                    if (order.Order_num == id)
                    {
                        j = i;
                    }
                }
                _orders[j] = neworder;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单修改失败，请检查输入的订单号!");
            }
        }
        public Order getOrder(int id)                                              //按照订单号查询
        {
            var query = from o in _orders
                        where o.Order_num == id
                        select o;
            Order order = query.FirstOrDefault();
            return order;
        }
        public List<Order> querybyClient(String name)                              //按照客户名查询
        {
            var query = _orders.Where(o => o.Client_.Name == name).OrderBy(o => o.Sum);
            return query.ToList();
        }
        public void showID()                                                       //输出订单编号
        {
            foreach (Order order in _orders)
            {
                Console.Write(order.Order_num + " ");
            }
        }
        public void Export()                                                       //序列化为XML
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, _orders);
            }
            Console.WriteLine("\nSerialized as xml");
            Console.WriteLine(File.ReadAllText("orderlist.xml"));
        }
        public void Import()                                                     //XML反序列化
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orderlist.xml", FileMode.Open))
            {
                _orders = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("\nDeserialized from orderlist.xml");
            }
        }
    }
}
