using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i, fact = 1, number;
            //Console.Write("Enter any Number: ");
            //number = int.Parse(Console.ReadLine());
            //for (i = 1; i <= number; i++)
            //{
            //    fact = fact * i;
            //}

            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob04.in_.txt";
            using (StreamReader Strem = new StreamReader(path))
            {
                string line;
                int i;
                float ThatOneFloat = 1;
                while ((line = Strem.ReadLine()) != null)
                {
                    int number = int.Parse(line);
                    for (i = 1; i <= number; i++)
                    {
                        ThatOneFloat = ThatOneFloat * i;
                    }
                    Console.WriteLine("Factorial of " + number + " is: " + ThatOneFloat);
                    ThatOneFloat = 1;
                }
                Console.ReadLine();
            }
        }
    }
}
