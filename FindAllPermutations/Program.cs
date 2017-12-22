using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            //char[] charArry = str.ToCharArray();
            Permute(nums, 0, nums.Length - 1);
            Console.ReadKey();
        }

        static void Permute(int[] arry, int i, int n)
        {
            int j;
            if (i == n)
                Console.WriteLine(new int);
            else
            {
                for (j = i; j <= n; j++)
                {
                    Swap(ref arry[i], ref arry[j]);
                    Permute(arry, i + 1, n);
                    Swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
    }
}
