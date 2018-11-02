using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_sized_squares
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Print3x3Square();
                Console.WriteLine();
                Print3x6Square();
                Console.WriteLine();
                Print6x3Square();
                Console.WriteLine();
            }
        }
        static void Print3x3Square()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void Print3x6Square()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void Print6x3Square()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}
