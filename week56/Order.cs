using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5
{
    public class Order
    {
        private int order_num;
        private Client client;
        private OrderDetails[] orderdetails;
        private double sum;
        public int Order_num { get; set; }
        public Client Client_ { get; set; }
        public OrderDetails[] Orderdetails { get; set; }
        public double Sum { get; set; }
        public Order() { }
        public Order(int order_num,Client client,OrderDetails[] orderdetails)
        {
            this.order_num = order_num;
            this.client = client;
            this.orderdetails = orderdetails;
            Order_num = order_num;
            Client_ = client;
            Orderdetails = orderdetails;


        }
        public void Calculate() { 
            foreach(OrderDetails _orderDetails in orderdetails)
            {
                sum += (_orderDetails.Goods_.Price) * (_orderDetails.Num);
            }
        }
        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            foreach (OrderDetails orderDetails in Orderdetails)
            {
                details.Append(orderDetails.ToString());
            }
            return "\norderNum:" + order_num + "     ClientName:" + client.Name + "     Sum:￥" + sum + details;
        }
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                    order_num == order.order_num &&
                    EqualityComparer<Client>.Default.Equals(client, order.client) &&
                    EqualityComparer<OrderDetails[]>.Default.Equals(orderdetails, order.orderdetails) &&
                    sum == order.sum;
        }


    }
}
