using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyamPro.Arraypro
{
    internal class study2D21
    {
        //to calculate sum of row in 2D array
        static void Main(string[] args)
        {
            int[,] ar = { { 1, 2, 3 }, { 6, 7, 8 }, { 9, 5, 4 } };

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    sum = sum + ar[i, j];
                    Console.Write(ar[i, j] + " ");
                }
                Console.Write(" sum=" + sum);
                Console.WriteLine();
            }
        }
    }
    class fourbyfour
    {
            //4*4
            static void Main(string[] args)
            {
                int i, j;
                int[,] ary = { { 1, 2, 3, 4 }, { 8, 7, 6, 5 }, { 1, 8, 2, 7 }, { 3, 6, 4, 5 } };
                for (i = 0; i < ary.GetUpperBound(0); i++)
                {
                    for (j = 0; j < ary.GetUpperBound(1); j++)
                    {
                        Console.Write(ary[i, j] + " ");
                    }
                    Console.WriteLine();

                    if (i == 0 || j == 0 || i == ary.GetUpperBound(0) || j == ary.GetUpperBound(1))
                    {
                        Console.Write(ary[i, j]);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
    }
    class p1
    {
        //patturn
        static void Main(string[] args)
        {
            char[,] arr = new char[3, 3];
            for (int i = 0; i < arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1); j++)
                {
                    if (i == 0 || j == 0 || i == arr.GetUpperBound(0) || j == arr.GetUpperBound(1))
                    {
                        arr[i, j] = '*';
                    }
                    else
                    {
                        arr[i, j] = ' ';
                    }
                    for (i = 0; i < arr.GetUpperBound(0); i++)
                    {
                        for (j = 0; j < arr.GetUpperBound(1); j++)
                        {
                            Console.Write(arr[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
     class avr2D
    {
        //find out avarage of each row 
        static void Main(string[] args)
        {
            int[,] ar = { { 1, 2, 3 }, { 6, 7, 8 }, { 9, 5, 4 } };
            int i,j, avr;

            for ( i = 0; i < ar.GetLength(0); i++)
            {
                int sum = 0;
                for ( j = 0; j < ar.GetLength(1); j++)
                {
                    sum = sum + ar[i, j];
                    Console.Write(ar[i, j] + " ");
                }
                avr = sum/(i * j);
                Console.Write(" avarage="+avr);
                Console.WriteLine();
            }
        }
    }
    class colsum
    {
        //coloum sum
        static void Main(string[] args)
        {
            int[,] ar = { { 1, 2, 3 }, { 6, 7, 8 }, { 9, 5, 4 } };
            for (int i = 0; i < ar.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    sum = sum + ar[i, j];
                    Console.Write(ar[i, j] + " ");
                }
                Console.Write(" sum=" + sum);
                Console.WriteLine();
            }
        }
    }

    class add2matrix
    {
        //adition of two matrices
        static void Main(string[] args)
        {
            int[,] ar = { { 1, 2, 3 }, { 6, 7, 8 }, { 9, 5, 4 } };
            int[,] br = { { 1, 2, 3 }, { 6, 7, 8 }, { 9, 5, 4 } };
            int r = ar.GetLength(0), c = ar.GetLength(1);
            int[,] sum = new int[r, c];
            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    sum[i, j] = ar[i, j] + br[i, j];
                }
            }
            Console.WriteLine("addition of 2 matrices");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(sum[i,j]+" ");
                }
                Console.WriteLine();
            }
           
        }
    }
    class patturnN
    {
        static void Main(string[] args)
        {

        }
    }
}
