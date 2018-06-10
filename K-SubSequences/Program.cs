using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_SubSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,1 };
            int seqs = GetSubSequencesOfSumK(arr, 3);
        }

        public static int GetSubSequencesOfSumK(int[] arr, int k)
        {
            var lst = new List<int[]>();
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                var l1 = new List<int>();
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += arr[j];
                    l1.Add(arr[j]);
                    if (sum % k == 0)
                    {
                        var l2 = new int[l1.Count];
                        l1.CopyTo(l2);
                        lst.Add(l2);
                    }
                }
            }
            return lst.Count;
        }
    }
}