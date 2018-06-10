using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindKthSmallestin2SortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 8, 16, 32, 64 };
            int[] b = { 3, 6, 10, 18, 25, 30 };
            int findKth = findSmallest(a,b,7);
            
        }
        public static int findSmallest(int[] a, int[] b, int num)
        {
            int i, j, count = 0;
            int currentSmall= 0;
            for (i = 0, j = 0; i < a.Length + b.Length;)
            {
                if (a[i] < b[j])
                {
                    currentSmall = a[i];
                    i++;
                    count++;
                    if (count == num)
                    {
                        break;
                    }
                }
                else
                {
                    currentSmall = b[j];
                    j++;
                    count++;
                    if (count == num)
                    {
                        break;
                    }
                }
            }
            return currentSmall;
        }
    }
 }

