using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MDC = new int[10, 5];
            for (int i = 0; i < MDC.GetLength(0);i++)
            {
                for (int j = 0; j < MDC.GetLength(1);j++)
                {
                    MDC[i, j] = i * j;
                }
            }
            Print2DArray(MDC);
        }
        static void Print2DArray(int [,] MDC)
        {
            for (int i = 0; i < MDC.GetLength(0); i++)
            {
                for (int j = 0; j < MDC.GetLength(1); j++)
                {
                    Console.Write(MDC[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
