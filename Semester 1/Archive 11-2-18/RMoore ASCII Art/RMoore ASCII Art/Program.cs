using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMoore_ASCII_Art
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 0;
            int M = 0;
            for (I = 0; I < 1; I++)
            {
                {
                    Console.Write("X");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            for (I = 0; I < 3; I++)
            {
                for (M = 0; M < 3; M++)
                {
                    Console.Write("X");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            for (I = 0; I < 4; I++)
            {
                for (M = 0; M < 5; M++)
                {
                    Console.Write("X");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            for (I = 0; I < 5; I++)
            {
                for (M = 4 - I; M < 5; M++)
                {
                    Console.Write("X");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            for (I = 0; I < 5; I++)
            {
                for (M = 0; M < 5; M++)
                {
                    if (I == M || M == I)
                        Console.Write(" ");

                    else
                        Console.Write("X");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            for (I = 0; I < 5; I++)
            {
                for (M = 0; M < 5; M++)
                {
                    if (I == M || 4 - M == I)
                        Console.Write(" ");

                    else
                        Console.Write("X");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            for (I = 0; I < 5; I++)
            {
                for (M = 0; M < 5; M++)
                {
                    if (4 - I == M)
                        Console.Write(" ");

                    else
                        Console.Write("X");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine(" ");
            for (I = 0; I < 5; I++)
            {
                for (M = 0; M < 5; M++)
                {
                    if (4 - M <= I)
                    {
                        Console.Write("X");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            for (I = 0; I < 3; I++)
            {
                for (M = 0; M < 5; M++)
                {
                    if (4 - M <= I)
                    {
                        Console.Write("X");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
