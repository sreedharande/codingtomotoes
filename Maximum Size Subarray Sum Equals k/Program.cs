using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Size_Subarray_Sum_Equals_k
{
    class Program
    {
        /// <summary>
        /// Given an array nums and a target value k, find the maximum length of a subarray that sums to k. If there isn't one, return 0 instead.
        /// Note:
        /// The sum of the entire nums array is guaranteed to fit within the 32-bit signed integer range.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] nums = { 1, -1, 5, -2, 3 };
            int maxSizeSubArray = FindMaximunSizeSubArray(nums, 3);
        }

        private static int FindMaximunSizeSubArray(int[] nums, int target)
        {
            if (nums.Length <= 1) return nums.Length;
            int runningSum = 0;
            int subArrayLength = 0;
            Dictionary<int, int> runningSumIndex = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                runningSum = runningSum + nums[i];
                if(runningSum == target)
                {
                    subArrayLength = i + 1;
                }
                else
                {
                    int val = 0; 
                    if(runningSumIndex.TryGetValue(runningSum - target, out val))
                    {
                        subArrayLength = Math.Max(subArrayLength, i - val);
                    }
                }
                if (!runningSumIndex.ContainsKey(runningSum))
                {
                    runningSumIndex.Add(runningSum, i);
                }
            }
            return subArrayLength;
        }
    }
}
