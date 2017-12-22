using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1	Implement an algorithm to determine if a string has all unique characters  What if you can not use additional data structures? 
namespace UniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region Method 1
            //string str = "sre";
            //bool flag = true;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for(int j=i+1; j<str.Length; j++)
            //    if (str[i] == str[j])
            //    {
            //        flag = false;
            //    }
            //}
            //#endregion

            #region Method 2
            string str = "ddhaar";
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            bool isUnique;
            for (int i = 0; i < charArray.Length - 1; i++)
            {
                if (charArray[i] == charArray[i + 1])
                {
                    isUnique = false;
                }
            }
            #endregion
        }
    }
}
