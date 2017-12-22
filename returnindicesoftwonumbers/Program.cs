using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnindicesoftwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 5,5,11 };
            int [] result = TwoSum(a, 10);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return null;
        }
    }
}
