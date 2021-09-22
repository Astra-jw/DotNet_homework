using System;

namespace csharp2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数据：");
            string s = Console.ReadLine();
            int a = Int32.Parse(s);
            
            Console.WriteLine("所有素数因子为：");
            for (int i = 1; i <= a; i++)
            {
                
                if (a% i == 0)
                {
                    int n = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0) n++;
                    }
                    if (n == 2) { Console.WriteLine(i); }
                }
 
            }
            Console.ReadLine();
        }
    }
}
