using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "Dam Am";
            //char[] charArray = s.ToLower().Replace(" ","").ToCharArray();
            //Array.Sort(charArray);
            //int count = 0;
            //for (int j = 0; j < charArray.Length; j += 2)
            //{
            //    if (j != charArray.Length - 1)
            //    {
            //        if (charArray[j] != charArray[j + 1])
            //        {
            //            count++;
            //            j++;
            //        }
            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}
            //if (count > 1) Console.WriteLine(false);
            //else Console.WriteLine(true);

            string s = "Tact Cooa";
            s = s.Replace(" ", "").ToLower();
            char[] str = s.ToCharArray();
            Array.Sort(str);
            int count = 0;
            for(int i=0; i<str.Length-1; i+=2)
            {
                if(str[i] != str[i+1])
                {
                    count++;
                }
            }
            if(count>1)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }

        }
    }
}
