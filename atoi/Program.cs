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
            string str = "-12345";
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
