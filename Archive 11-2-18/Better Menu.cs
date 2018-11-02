using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coaster = new int[10];
            Random rand = new Random();
            int input = 0;

            do
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("1. Add a rider to a random spot in the coaster.");
                Console.WriteLine("2. List available seats.");
                Console.WriteLine("3. Start the ride. List how many riders.");
                Console.WriteLine("4. Exit Program.");
                Console.WriteLine("**************************************************");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    int count = 0;
                    for (int i = 0; i< coaster.Length; i++)
                    {
                        if (coaster[i] == 1)
                        {
                            count++;
                        }
                    }

                    if (count == coaster.Length)
                    {
                        Console.WriteLine("Coaster is full. No one can get in.");
                    }
                    else
                    {
                        do
                        {
                            int SelectedChair = rand.Next(0, 10);
                            if (coaster[SelectedChair] == 0)
                            {
                                coaster[SelectedChair] = 1;
                                Console.WriteLine("")
                                break;
                            }
                        }
                    }
                }
                else if (input == 2)
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("| ");
                    for (int i = 0; i < coaster.Length; i++)
                    {
                        Console.Write(coaster[i] + " | ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("**************************************************");
                }

                else if (input == 3)
                {
                    int count = 0;
                    for (int i = 0; i < coaster.Length)
                }
            }
        }
    }
}
