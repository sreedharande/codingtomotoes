using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            int[] nums2 = { 1, 2, 2 };
            int[] result = MergeSorted2(nums1, nums1.Length - nums2.Length, nums2, nums2.Length);
        }

        public static int[] MergeSorted(int[] nums1, int[] nums2)
        {
            if (nums1.Length > 1 && nums2.Length > 1)
            {

                int j = 0;
                for (int i = 0; i < nums1.Length - 1; i++)
                {
                    if (nums1[i] != 0)
                    {
                        if (nums1[i] > nums2[j])
                        {
                            int temp = nums1[i];
                            nums1[i] = nums2[j];
                            nums2[j] = temp;
                        }

                    }
                    else
                    {
                        nums1[i] = nums2[j];
                        if (j < nums2.Length)
                            j++;
                    }
                }
            }

            return nums1;
        }

        public static int[] MergeSorted2(int[] nums1, int nums1ElementLength, int[] nums2, int nums2ElementLength)
        {
            int resultIndex = nums1ElementLength + nums2ElementLength - 1;
            int i = nums1ElementLength - 1;
            int j = nums2ElementLength - 1;

            while (i >= 0 && j >= 0)
            {
                if (nums1[i] >= nums2[j])
                {
                    nums1[resultIndex] = nums1[i];
                    resultIndex--;
                    i--;
                }
                else
                {
                    nums1[resultIndex] = nums2[j];
                    resultIndex--;
                    j--;
                }
            }

            while (j >= 0)
            {
                nums1[resultIndex] = nums2[j];
                resultIndex--;
                j--;
            }

            return nums1;
        }
    }
}
