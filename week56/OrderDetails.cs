using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5
{
    public class OrderDetails
    {
        private Goods goods;
        private int num;
        public Goods Goods_ { get; set; }
        public int Num { get; set; }
        public OrderDetails() { }
        public OrderDetails(Goods goods,int num)
        {
            this.goods = goods;
            this.num = num;
            Goods_ = goods;
            Num = num;
        }
        public override bool Equals(object obj)
        {
            return obj is OrderDetails detail &&
                    EqualityComparer<Goods>.Default.Equals(goods, detail.goods) &&
                    num == detail.num;
        }
        public override string ToString()
        {
            return "\nGoodsname:" + goods.Name + "\ngoodsNum:" + num + "\nGoodsPrice:" + goods. Price + "\n";
        }
    }
}
