using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadane_sAlgorithm_MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -2, -3, 4, -1, -2, 1, 5, -90, 30, 25 };
            int sum=0, maxSum = 0;
            for(int i=0;i<a.Length; i++)
            {
                sum = sum + a[i];
                if(sum < 0)
                {
                    sum = 0;
                }
                else if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            Console.Write(maxSum);
        }
    }
}
