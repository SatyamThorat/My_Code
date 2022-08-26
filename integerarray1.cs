using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatyamPro.Arraypro
{
    internal class integerarray1
    {
        static void Main(string[] args)
        {
            //array reverse print
            int[] a = new int[5];
            a[0] = 5;
            a[1] = 6;
            a[3] = 7;
            a[2] = 8;
            a[4] = 9;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]+"  ");

            }
        }

    }
    class arrayeven
    {   //display even elemeny from array 
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 ==0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
    class arrayevensum
    {   //sum of even element 
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("sum of even element  = "+sum);
        }
    }
    class sumarray
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                
                    sum = sum + a[i];
                
            }
            Console.WriteLine("sum of araay element  = " + sum);
        }
    }
    class oddposi1
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(i+"  "+a[i]);
            }
        }
    }
    

    class oddposi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any five elements....");
            int[] a = new int[5];
            a[0] = int.Parse(Console.ReadLine());
            a[1] = int.Parse(Console.ReadLine());
            a[2] = int.Parse(Console.ReadLine());
            a[3] = int.Parse(Console.ReadLine());
            a[4] = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 1)
                {
                    Console.WriteLine(i+"  "+a[i]);
                }
            }
        }
    }
}
