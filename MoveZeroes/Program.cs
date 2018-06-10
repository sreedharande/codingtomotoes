using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeroes
{
    class Program
    {
        /// <summary>
        /// Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        /// You must do this in-place without making a copy of the array.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] nums = { 2, 1, 0, 3, 12, 5, 0, 4, 6, 7,0, 9 };
            
            if (nums.Length != 0)
            {
                int[] results = MoveZerosSanthu(nums);
            }
        }
        /// <summary>
        /// Move all non-zero entries to the left in the array and once you are done with moving 
        /// all non-zero entries to the left, all that are remaining are zero entries in the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] MoveZeros2(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                    j++;
                }
            }
            return nums;
        }

        public static int[] MoveZerosSanthu(int[] nums)
        {            
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j=i;j<nums.Length-1;j++)
                {
                    if(nums[j] == 0 && nums[j+1]!=0)
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
