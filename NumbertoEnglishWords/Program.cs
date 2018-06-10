using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbertoEnglishWords
{
    class Program
    {
        static string[] LESS_THAN_20 = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        static string[] TENS = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
        static string[] THOUSANDS = {"Billion", "Million", "Thousand", ""};
        static int[] radix = { 1000000000, 1000000, 1000, 1 };
        static void Main(string[] args)
        {
            string s = numberToWords(23);
        }

        public static string numberToWords(int num)
        {
            if (num == 0) return "Zero";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < radix.Length; i++)
            {
                if (num / radix[i] == 0) continue;
                sb.Append(trans(num / radix[i])).Append(THOUSANDS[i]).Append(' ');
                num %= radix[i];
            }
            return sb.ToString().Trim();
        }

        private static string trans(int num)
        {
            if (num == 0) return "";
            if (num < 20) return LESS_THAN_20[num] + " ";
            if (num < 100) return TENS[num / 10] + " " + trans(num % 10);
            return LESS_THAN_20[num / 100] + " Hundred " + trans(num % 100);
        }
    }
}
