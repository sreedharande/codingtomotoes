using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tasks = { 'A', 'A', 'A', 'B', 'B', 'B' };
            int interval = LeastInterval(tasks, 2);
        }

        public static int LeastInterval(char[] tasks, int n)
        {
            // Early return if the n is 0
            if (n == 0) return tasks.Length;

            // Create a dictionary
            Dictionary<char, int> d = new Dictionary<char, int>();

            // Add values into dictionary
            foreach (char c in tasks)
            {
                if (!d.ContainsKey(c))
                    d.Add(c, 0);
                d[c]++;
            }
            // Sort them
            d = d.OrderByDescending(c => c.Value).ToDictionary(c => c.Key, c => c.Value);

            // Get the max count 
            int max = d.First().Value;

            // All max count 
            int count = d.Count(c => c.Value == max);
            // expected iteraiton
            int iteration = (n + 1) * (max - 1) + count;

            // iteration should be greater than task length
            return (iteration >= tasks.Length) ? iteration : tasks.Length;
        }

    }
}
