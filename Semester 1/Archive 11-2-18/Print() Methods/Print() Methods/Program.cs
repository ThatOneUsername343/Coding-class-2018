using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Printa(Rand.Next(1, 10));
            Printb(array);
            int[,] c = new int[10, 5];
            for (int i = 0; i < c.GetLength(0); i++)
            {

                for (int k = 0; k < c.GetLength(1); k++)
                {
                    c[i,k] = Rand.Next(1, 10);
                }
            }
            Printc(c);
            int[][] d = new int[10][];
            for (int i = 0; i < d.GetLength(0);i++)
            {
                d[i] = new int[i + 1];
                for (int k = 0; k < d[i].Length; k++)
                {
                    d[i][k] = i * k;
                }
            }
            Printd(d);
        }
        static void Printa(int a)
        {
            Console.WriteLine(a);
            Console.WriteLine();
        }
        
        static void Printb(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {

                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        static void Printc(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
            }
            Console.WriteLine();
        }
        static void Printd(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
