using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Run Length Encoding - https://en.wikipedia.org/wiki/Run-length_encoding

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aabcccccaaa";//"WWWWWWWWWWWWBWWWWWWWWWWWWBBBWWWWWWWWWWWWWWWWWWWWWWWWBWWWWWWWWWWWWWW";           


            //Method 2 - Santhoshi 
            //s = santhoshiMethod(s);
            //Console.WriteLine(s);
            s = PracticeMethod(s);
            Console.Write(s.ToString());

        }

        private static string sreedharMehod(string s)
        {
            string result = string.Empty;
            Dictionary<char, int> d = new Dictionary<char, int>();
            char[] str = s.ToCharArray();

            foreach(char c in str)
            {
                if(d.ContainsKey(c))
                {
                    d[c] = d[c] + 1;
                }
                else
                {
                    d.Add(c, 1);
                }
            }
           
          
            return result;
        }

        private static string santhoshiMethod(string s)
        {
            int count = 1;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                    if (i != s.Length - 1)
                    {
                        if (s[i] != s[i + 1])
                        {
                            sb.Append(string.Concat(s[i], count));
                            count = 0;
                        }
                    }
                    else
                    {
                        sb.Append(string.Concat(s[i], count));
                    }


                }
                else if (s[i] != s[i + 1])
                {
                    count++;
                    sb.Append(string.Concat(s[i], count));
                    count = 0;
                }
                else if (s[i] == s[i + 1])
                {
                    count++;
                }
            }
            return sb.ToString();
        }

        private static string PracticeMethod(string s)
        {
            StringBuilder sb = new StringBuilder();
            //SREEEDDHHAAR
            //01234567891011
            char[] charArray = s.ToCharArray();
            int count = 1;
            char c = charArray[0];
            for (int i=1; i<=charArray.Length; i++)
            {
                if (i!= charArray.Length && c== s[i])
                {
                    count++;
                }
                else
                {
                    sb.Append(string.Concat(c, count));
                    if (i != charArray.Length)
                        c = s[i];
                    count = 1;
                }                
            }

            return sb.ToString();
            
        }
    }
}
