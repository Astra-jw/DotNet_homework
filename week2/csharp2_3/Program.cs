﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];
            for (int i = 0; i < 99; i++)
            {
                a[i] = i + 2;
            }
            int m = 2;
            while (m *m < 100)
            {
                for (int j = 0; j < 99; j++)
                {
                    if (a[j] != 0 && a[j] % m == 0 && a[j] != m)
                    {
                        a[j] = 0;
                    }
                }
                for (int j = 0; j < 99; j++)
                {
                    if (a[j] != 0 && a[j] > m)
                    {
                        m = a[j];
                        break;
                    }
                }
            }
            for (int j = 0; j < 99; j++)
            {
                if (a[j] != 0)
                {
                    Console.WriteLine(a[j]);
                }
            }
            Console.ReadLine();
        }
    }
}
