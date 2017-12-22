using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "god";
            string t = "dog";
            bool res;
            char[] sChar = s.ToCharArray();
            char[] tChar = t.ToCharArray();

            Array.Sort(sChar);
            Array.Sort(tChar);

            if(sChar.Length != tChar.Length)
            {
                res = false;
            }
            else
            {
                for(int i=0;i<sChar.Length; i++)
                {
                    if(sChar[i]!=tChar[i])
                    {
                        res = false;
                    }
                }
            }
        }
    }
}
