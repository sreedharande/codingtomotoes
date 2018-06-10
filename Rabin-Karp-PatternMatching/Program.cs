using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabin_Karp_PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cbabadebbabbcbabaabcebabe";
            string p = "abbc";

            int lengthS = s.Length;
            int lengthP = p.Length;
            int i;

            int max = lengthS - lengthP + 1;
            bool flag = true;
            for(i=0; i<max;i++)
            {
                for(int j=0; j<lengthP; j++)
                {
                    if(s[i+j] != p[j])
                    {
                        flag = false;
                        break;
                    }                    
                }
                if (flag)
                {
                    Console.WriteLine("Pattern found @ : ", i);
                }
            }
        }


    }
}
