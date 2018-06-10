using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 9, 99, 99, };
            int[] result = PlusOneAllCases(nums);
        }

        public static int[] PlusOne(int[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] < 9)
                {
                    nums[i]++;
                    return nums;
                }

                nums[i] = 0;
            }
            int[] newNumber = new int[nums.Length + 1];
            newNumber[0] = 1;

            return newNumber;
        }

        public static int[] PlusOneAllCases(int[] digits)
        {
            if (digits.Length == 0) return new int[0];
            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int total = digits[i] + carry;
                digits[i] = total % 10;
                carry = total / 10;
            }
            if (carry == 0)
                return digits;
            else
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                Array.Copy(digits, 0, result, 1, digits.Length);
                return result;
            }
        }
    }
}
