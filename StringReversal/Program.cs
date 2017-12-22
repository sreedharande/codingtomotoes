using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "SreedharAnde";
            string substr = "eed";
            string result = string.Empty;            
            bool match;

            for (int i = 0; i < str.Length - substr.Length + 1; ++i)
            {
                match = true;
                for (int j = 0; j < substr.Length; ++j)
                {
                    if (str[i + j] != substr[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                    Console.WriteLine(i);
            }
            Console.WriteLine(result);
        }
    }
}
