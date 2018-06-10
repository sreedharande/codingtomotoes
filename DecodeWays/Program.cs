using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeWays
{
    class Program
    {
        /// <summary>
        /// A message containing letters from A-Z is being encoded to numbers using the following mapping:
        /// 'A' -> 1
        /// 'B' -> 2
        /// 'Z' -> 26
        /// Given a non-empty string containing only digits, determine the total number of ways to decode it.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string s = "123411";
            int decodeWays1 = DecodeNumbers(s);
            int decodeWays2 = numDecodings(s);
            
        }
        public static int numDecodings(string s)
        {
            if (s.Length == 0) return 0;
            int pre = 26, digit, answer = 0, first = 1, second = 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                digit = s[i] - '0';
                if (digit == 0)
                    answer = 0;
                else
                    answer = first + (digit * 10 + pre < 26 ? second : 0);
                second = first;
                first = answer;
                pre = digit;
            }
            return answer;
        }

        public static int DecodeNumbers(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int noofpossibleways = 0, digit, alphaLength = 27, first = 1, second = 1;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                digit = s[i] - '0';
                if (digit == 0)
                    noofpossibleways = 0;
                else
                    noofpossibleways = first + (digit * 10 + alphaLength < 27 ? second : 0);

                second = first;
                first = noofpossibleways;
                alphaLength = digit;
        
            }
            return noofpossibleways;
        }
    }
}
