using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySelfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = ProductExceptSelf(new int[] { 1,2,3,4});
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length == 0)
                return null;

            int[] productExceptSelf = new int[nums.Length];   //Output Array

            productExceptSelf[0] = 1;
            for (int i = 1; i < nums.Length; i++)
                productExceptSelf[i] = productExceptSelf[i - 1] * nums[i - 1];

            int backwardRunningProd = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                productExceptSelf[i] = productExceptSelf[i] * backwardRunningProd;
                backwardRunningProd = backwardRunningProd * nums[i];
            }
               return productExceptSelf;

        }
    }
}
