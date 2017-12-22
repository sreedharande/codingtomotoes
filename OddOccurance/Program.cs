using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 3, 1, 4, 5, 1, 4, 2, 5 };

            //for (int i = 0; i < a.Length; i++)
            //{
            //    int count = 1;
            //    for (int j = 1; j < a.Length; j++)
            //    {
            //        if (a[i] == a[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count % 2 == 1)
            //    {
            //        Console.WriteLine(a[i]);
            //        break;
            //    }
            //}

            Array.Sort(a);
            for(int k=0;k<a.Length; k=k+2)
            {
                int kcount = 1;
                if (k < a.Length - 1)
                {
                    if (a[k] == a[k + 1])
                    {
                        kcount++;
                    }
                }

                if(kcount%2==1)
                {
                    Console.WriteLine(a[k]);
                }
            }
            // time complexity is O(n-Square)

            //int result = a[0];
            //for (int i=1;i<a.Length;i++)
            //{
            //    result = result ^ a[i];
            //}
            //Console.WriteLine(result);

        }
    }
}
