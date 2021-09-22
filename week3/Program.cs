using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3
{
    public class Rectangle
    {
        public int length;
        public int width;
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public void Judge()
        {
            if (length > 0 && width > 0) Console.WriteLine("形状合法");
            else
            {
                Console.WriteLine("形状不合法");
            }
        }
        public void Area()
        {
            Console.WriteLine("面积为：" + length * width);
        }
    }
    public class Square : Rectangle
    {

        public Square(int length, int width) : base(length, width) { }
        public void Judge()
        {
            if (length > 0 && width > 0 && length == width) Console.WriteLine("形状合法");
            else
            {
                Console.WriteLine("形状不合法");
            }
        }
    }
    public class Triangular
    {
        public double edge1;
        public double edge2;
        public double edge3;
        public Triangular(int edge1,int edge2,int edge3)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
            this.edge3 = edge3;
                
        }
        public void doJudge()
        {
            if (edge1 > 0 && edge2 > 0 && edge3 > 0)
            {
                if (edge1 + edge2 > edge3 && edge1 + edge3 > edge2 && 3 + edge2 > edge1) Console.WriteLine("合法");
                else
                {
                    Console.WriteLine("不合法");
                }
            }
            else
            {
                Console.WriteLine("不合法");
            }
        }
        public void getArea()
        {
            double p = (edge1 + edge2 + edge3) / 2;
            double s = Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
            Console.WriteLine("面积为："+s);
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            r.Judge();
            r.Area();
            Square s = new Square(5, 5);
            s.Judge();
            s.Area();
            Triangular t = new Triangular(3, 4, 5);
            t.doJudge();
            t.getArea();
            Console.ReadKey();
               
        }
    }
}
