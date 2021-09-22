using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = "";
            char c;
            double a, b, d;
            Console.WriteLine("请输入一个数字：");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.WriteLine("请输入运算符：");
            s = Console.ReadLine();
            c = Char.Parse(s);
            Console.WriteLine("请输入另一个数字：");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.Write("结果为：");
            switch (c)
            {
                case '+':
                    d = a + b;
                    Console.WriteLine(d);
                    break;
                case '-':
                    d = a - b;
                    Console.WriteLine(d);
                    break;
                case '*':
                    d = a * b;
                    Console.WriteLine(d);
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("分母不能为零！");
                    }
                    else
                    {
                        d = a / b;
                        Console.WriteLine(d);
                    }
                    break;
                default:
                    Console.WriteLine("运算符无效！");
                    break;
            }
            Console.WriteLine("计算结束！");
            Console.ReadLine();



        }
    }
}
