using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[4, 4]
                {
                    {1,2,3,4 },
                    {5,6,7,8 },
                    {9,10,11,12 },
                    {13,14,15,16 }
                };
            

            Console.Write("\n\nRead a 2D array of size 4X4 and print the matrix :\n");
            Console.Write("------------------------------------------------------\n");

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < arr1.Length; i++)
            {
                Console.Write("\n");
                for (j = 0; j < arr1.Length; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
         

            Console.Write("Rotated Matrix");
            int k = 0;
            for(int l=0; l<arr1.Length; l++)
            {
                for(int m=3;m>=0;m--)
                {                    
                    arr1[l, k] = arr1[k, m];                    
                }
                k++;
            }

            Console.Write("Rotated Matrix");
            for (i = 0; i < 4; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 4; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
