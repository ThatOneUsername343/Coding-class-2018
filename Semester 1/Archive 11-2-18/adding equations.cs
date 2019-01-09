using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("1. Add 5 + 6");
            Console.WriteLine("2. Add 11 + 13");
            Console.WriteLine("3. Add 3 + 9");
            Console.WriteLine("4. Exit program");
            Console.WriteLine("*********************************************");

            int input = 0;

            do
            {
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    equation1();
                }
                if (input == 2)
                {
                    equation2();
                }
                if (input ==3)
                {
                    equation3();
                }
            } while (input != 4);
        }

        static void equation1()
        {
            int number1 = 5;
            int number2 = 6;
            int numbertotal;
            numbertotal = number1 + number2;
                Console.WriteLine("The answer is " + numbertotal);
        }

        static void equation2()
        {
            int number1 = 11;
            int number2 = 13;
            int numbertotal;
            numbertotal = number1 + number2;
                Console.WriteLine("The answer is " + numbertotal);
        }

        static void equation3()
        {
            int number1 = 3;
            int number2 = 9;
            int numbertotal;
            numbertotal = number1 + number2;
                Console.WriteLine("The answer is " + numbertotal);
        }   
    }
}
