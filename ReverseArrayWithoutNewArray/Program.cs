using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayWithoutNewArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 5, 7, 9, 10 };
            int midpoint = a.Length / 2;
            for(int i=0;i<midpoint;i++)
            {
                int otherend = a.Length - i - 1;

                int temp = a[otherend];
                a[otherend] = a[i];
                a[i] = temp;
            }

            for (int j = 0; j < a.Length; j++)
            {
                Console.Write($"{a[j]} ,");
                
            }
            Console.ReadLine();
        }
    }
}
