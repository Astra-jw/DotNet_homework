using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp4_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    
    public class GeneericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GeneericList()
        {
            tail = head = null;
        }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else { tail.Next = n;
                   tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> n = this.head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GeneericList<int> intlist = new GeneericList<int>();
            for(int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }

            intlist.ForEach(m => Console.WriteLine(m));
            int sum = 0;
            int max = 0;
            int min = 0;
            Action<int> act = (m => sum += m);
            act += (m => { if (max < m) max = m; });
            act += (m => { if (min > m) min = m; });
            intlist.ForEach(act);
            Console.WriteLine("总和：" + sum);
            Console.WriteLine("最大值：" + max);
            Console.WriteLine("最小值：" + min);
            Console.ReadLine();

        }
    }
}
