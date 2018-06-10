using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    class Program
    {
        /// <summary>
        /// //Binary Addition Rules:
        //0 + 0 = 0     1 + 0 = 1       0 + 1 = 1       1 + 1 = 10      1 + 1 + 1 = 11
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string res = AddBinary("11", "1");
        }

        public static string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int i = a.Length - 1;
            int j = b.Length - 1;
            int sum = 0;
            while (i >= 0 || j >= 0)
            {
                if (i >= 0) sum += a[i--] - '0';
                if (j >= 0) sum += b[j--] - '0';
                sb.Append(sum % 2);
                sum /= 2;
            }
            if (sum != 0) sb.Append(sum);
            //Reverse
            char[] result = sb.ToString().ToArray();
            Array.Reverse(result);

            return new string(result);
        }
    }
}
