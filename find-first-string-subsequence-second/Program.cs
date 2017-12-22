using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_first_string_subsequence_second
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "gksrek";
            string s2 = "geeksforgeeks";

            int l1 = s1.Length;
            int l2 = s2.Length;


            char[] chars1 = s1.ToCharArray();
            char[] chars2 = s2.ToCharArray();

            

            int i = 0, j = 0, count = 0;

            while(i<l1 && j<l2)
            {
                if(chars1[i] != chars2[j])
                {                    
                    if (l1 > l2)
                    {
                        i++;
                    }
                    if (l2 > l1)
                    {
                        j++;
                    }
                    if (l1 == l2)
                    {
                        i++;
                        j++;
                    }
                }
                else
                {
                    count++;
                }
            }
            if(count == l1)
            {

            }
        }
    }
}
