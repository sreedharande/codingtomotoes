using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneAwayEditPalendrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOneAwayEditPalendrome = OneAwayEditPalendrome("RacerCar");
        }

        public static bool OneAwayEditPalendrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;
            bool flag = false;
            for (int i = 0, j = s.Length - 1; i < s.Length/2; )
            {
                if(s[i].ToString().Equals(s[j].ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    i++;
                    j--;
                    flag = true;
                }
                else
                {
                    if(IsValidPalindrome(string.Concat(s.Substring(0, i), s.Substring(j))))
                    {
                        return true;
                    }
                    else if (IsValidPalindrome(string.Concat(s.Substring(0, i+1), s.Substring(j+1))))
                    {
                        return true;
                    }
                }
            }

            return flag;

        }
        public static bool IsValidPalindrome(string s)
        {
            bool flag = true;
            for(int i=0; i<s.Length/2; i++)
            {
                int otherEnd = s.Length - 1 - i;
                if(!s[i].ToString().Equals(s[otherEnd].ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    flag = false;
                }
                
            }
            return flag;
        }
    }
}
