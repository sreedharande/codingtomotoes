using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ArrayList al = FindAllPermulations();
        }

        static void Permute(char[] arry, int i, int n)
        {
            int j;
            if (i == n)
            {

            }  
            else
            {
                for (j = i; j <= n; j++)
                {
                    Swap(ref arry[i], ref arry[j]);
                    Permute(arry, i + 1, n);
                    Swap(ref arry[i], ref arry[j]); //backtrack
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            char tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        static ArrayList FindAllPermulations()
        {
            string str = "abc";
            ArrayList arrayList = new ArrayList();
            Permutations("", str, arrayList);
            return arrayList;
        }

        private static void GetAllPerms(string str, string prefix, ArrayList arrayList)
        {
            if(str.Length == 0)
            {
                arrayList.Add(prefix);
            }
            else
            {
                for(int i=0;i<str.Length; i++)
                {
                    GetAllPerms(str.Substring(0, i) + str.Substring(i + 1), prefix + str[i], arrayList);
                }
            }            
        }

        private static void Permutations(string prefix, string str, ArrayList results)
        {
            if (str.Length == 0)
            {
                results.Add(prefix);
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string rem = str.Substring(0, i) + str.Substring(i + 1);
                    Permutations(prefix + str[i], rem, results);
                }
            }
        }

    }
}
