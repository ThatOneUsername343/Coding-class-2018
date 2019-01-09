using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Square(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
        static void Square(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; i < size; j++)
                {
                    Console.Write("X");

                }
                Console.WriteLine();
            }
        }
    }
}
