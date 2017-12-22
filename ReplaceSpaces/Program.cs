using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Mr John Smith      ";

            string replacedString = removeSpaces(str);
        }

        static string removeSpaces(string Str)
        {
            char[] charArray = Str.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i=0; i<charArray.Length; i++)
            {
                if(charArray[i] == 32)
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(charArray[i]);
                }             
           
            }
            return sb.ToString();
        }
    }
}
