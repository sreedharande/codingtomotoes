using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneAwayEdit
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.The length difference between two input strings should not be more than 1.
            //2.When the length of the strings is same, the number of different chars should not be more than 1.
            //3.If the length difference is 1, then either one char can be inserted in the short string or deleted from the longer string.Considering that, the number of different char should not be more than 1.
            isOneEdit("pale", "bale");
        }

        static Boolean isOneEdit(string fs, string ss)
        {
//            #region Method 1
//            int len1 = firstString.Length;
//            int len2 = secondString.Length;

//            if((len1 - len2) > 1 || (len2-len1) > 1)
//            {
//                return false;
//            }


//            char[] firstStringChars = firstString.ToCharArray();
//            char[] secondStringchars = secondString.ToCharArray();
//            int count = 0;
//            if (len1 == len2) //oneEdit Replace
//            {          
//                for(int i=0;i<len1;i++)
//                {
//                    if(firstStringChars[i] != secondStringchars[i])
//                    {
//                        count++;
//                    }
//                }
//                if(count ==1)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            else
//            {                
//                int bigger = len1 > len2 ? len1 : len2;
//                for (int i = 0; i < bigger; i++)
//                {
//                    if (firstStringChars[i] != secondStringchars[i])
//                    {
//                        count++;
//                    }
//                }
//                if(count == 1)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
////#endregion

            if((fs.Length - ss.Length) > 1 || (ss.Length - fs.Length) > 1)
            {
                return false;
            }
            int i = 0, j = 0, count = 0;

            while(i<fs.Length && j<ss.Length)
            {
                if(fs[i] != ss[j])
                {
                    count++;
                    if(fs.Length > ss.Length)
                    {
                        i++;
                    }
                    if(ss.Length > fs.Length)
                    {
                        j++;
                    }
                    if(fs.Length == ss.Length)
                    {
                        i++;
                        j++;
                    }
                }
                else
                {
                    i++;
                    j++;
                }
            }

            if(count ==1)
            {
                Console.WriteLine("OneAway Edit");
                return true;
            }

            return false;
        }
    }
}
