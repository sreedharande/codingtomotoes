using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 10, 4, 8, 6, 3, 9, 20 };

            List<int[]> result = TwoSum(nums, 12);
            List<int[]> results = TwoSumDict(nums, 12);
            List<int[]> res = TwoSumHashTable(nums, 12);
        }

        // order of nlogn because we are sorting array
        public static List<int[]> TwoSum(int[] a, int target)
        {           
            int i, j;
            Array.Sort(a);
            List<int[]> results = new List<int[]>();
            for (i = 0, j = a.Length-1; i < (a.Length-1)/2;)
            {
                if (a[i] + a[j] == target)
                {
                    results.Add(new int[] { i, j});
                    i++;
                    j--;
                }
                else if (a[i] + a[j] > target)
                {
                    j--;
                }
                else if (a[i] + a[j] < target)
                {
                    i++;
                }
            }
            return results;
        }

        public static List<int[]> TwoSumDict(int[] a, int target)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            List<int[]> results = new List<int[]>();
            for (int i=0;i<a.Length;i++)
            {
                int diff = target - a[i];
                if(pairs.ContainsKey(diff))
                {
                    results.Add(new int[] { pairs[diff], a[i]});
                }
                else
                {
                    pairs.Add(a[i], a[i]);
                }
            }
            return results;
        }

        //Throw everything in the array into the hash table.Then, to look up if x + k or x - k exist in the array, we
        //just look it up in the hash table.We can do this in O(N) time.

        public static List<int[]> TwoSumHashTable(int[] a, int target)
        {
            List<int[]> results = new List<int[]>();
            Hashtable ht = new Hashtable();
            for (int i = 0; i < a.Length; i++)
            {
                ht.Add(a[i], a[i]);
            }
            for (int i = 0; i < a.Length; i++)
            {
                int diff = target - a[i];
                if(ht.ContainsKey(diff))
                    {
                    results.Add(new int[] { diff, a[i] });
                }
            }

            return results;
        }
    }

}