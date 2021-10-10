using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5
{
   public class Goods
    {
        private string name;
        private double price;
        public string Name { get; set; }
        public double Price { get; set; }
        public Goods() { }
        public Goods(string name, double price) {
            this.name = name;
            this.price = price;
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return "goodsName:" + name + " goodsPrice:" + price;
        }
    }
}
