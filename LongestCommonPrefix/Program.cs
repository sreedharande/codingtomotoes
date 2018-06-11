using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };

            string prefix = strs[0];

            for(int i=1;i<strs.Length;i++)
            {
                while(strs[i].IndexOf(prefix) != 0)
                {
                    if(!string.IsNullOrEmpty(prefix))
                        prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }
            Console.WriteLine(prefix);
        }
    }
}
