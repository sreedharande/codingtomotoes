using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/string-to-integer-atoi/discuss/4654/My-simple-solution?page=1

            string str = "-12345";

            long result = 0;
            int i = 0;
            int sign = 1;

            while (str[i] == ' ') i++;

            if (str[i] == '-' || str[i] == '+')
            {
                if (str[i] == '+') sign = 1;
                else sign = -1;
                i++;
            }


            while (str[i] >= '0' && str[i] <= '9')
            {


                result = result * 10 + str[i] - '0';
                if (result > MAX)
                {
                    if (sign == -1) return INT_MIN;
                    else return INT_MAX;
                }

                i++;
            }

            return sign * result;
            char[] charStr = str.ToCharArray();
            int result = 0;

            foreach(char c in charStr)
            {
                result = result * 10 + (c - '0');
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
