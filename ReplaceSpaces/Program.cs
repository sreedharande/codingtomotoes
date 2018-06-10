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
            string str = "Mr John Smith ";

            string replacedString = removeSpaces(str, 13);
        }

        static string removeSpaces(string str, int givenLength)
        {
            char[] charArray = str.ToCharArray();
            int newLength, spaceCount = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 32)
                    spaceCount++;
            }
            newLength = givenLength + spaceCount * 2;
            char[] result = new char[newLength];
            for(int i = givenLength; i >0; i --)
            {
                if(charArray[i] == 32)
                {
                    result[newLength - 1] = '0';
                    result[newLength - 2] = '2';
                    result[newLength - 3] = '%';
                    newLength = newLength - 3;
                }
                else
                {
                    result[newLength-1] = charArray[i];
                    newLength--;
                }
            }
            return new string(result);
        }
    }
}
