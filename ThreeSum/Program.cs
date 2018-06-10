using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -1, 0, 1, 2, -1, -4 };
            List<int[]> triplets = GenerateTriplets(a, 0);
        }

        private static List<int[]> GenerateTriplets(int[] a, int target)
        {
            List<int[]> triplets = new List<int[]>();
            Array.Sort(a);
            //Why num.length - 2 ? can someone please explain? cause you're looking at 3 possible elements!
            for (int i=0; i<a.Length-2; i++)
            {                
                int start = i + 1;
                int end = a.Length - 1;
                
                while(start < end)
                {
                    int sum = a[i] + a[start] + a[end];

                    if(sum == target)
                    {                        
                        triplets.Add(new int[] { a[i], a[start], a[end] });
                        start++;
                        end--;
                    }
                    else if(sum < target)
                    {
                        start++;
                    }
                    else if (sum > target)
                    {
                        end--;
                    }

                }
            }
            return triplets;
        }
    }
}
