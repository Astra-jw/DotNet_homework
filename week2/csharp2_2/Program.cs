using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度：");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);
            int[] a = new int[n];
            int sum=0;
            Console.WriteLine("请输入数组元素：");
            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.WriteLine("该数组为：");
            foreach (int m in a)
            {
                Console.Write(m+" ");
                sum += m;
            }
            Console.WriteLine();
            Console.WriteLine("数组的最大值为：" + a.Max());
            Console.WriteLine("数组的最小值为：" + a.Min());
            Console.WriteLine("数组的平均值为：" + a.Average());
            Console.WriteLine("数组的总和为：" + sum);
            Console.ReadLine();

        }
    }
}
