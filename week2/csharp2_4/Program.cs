using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2_4
{
    class Program
    {
        static bool IsTlp(int a,int b)
        {
           
            int[,] array = new int[a, b];
           
            Console.WriteLine("请输入每个数据：");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    string s2 = Console.ReadLine();
                    array[i, j] = Int32.Parse(s2);
                }
            }
            int sum = 0;
            for (int i = 0; i < a - 1; i++)
            {
                for (int j = 0; j < b - 1; j++)
                {
                    if (array[i, j] == array[i + 1, j + 1]) sum++;
                }
            }
            if (sum == a - 1) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组行数：");
            string s = Console.ReadLine();
            int m = Int32.Parse(s);
            Console.WriteLine("请输入数组列数：");
            string s1 = Console.ReadLine();
            int n = Int32.Parse(s1);
            IsTlp(m, n);
            Console.ReadLine();
        }
    }
}
