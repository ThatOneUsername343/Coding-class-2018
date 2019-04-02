using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("1. Print 'Hello World!'");
                Console.WriteLine("2. Add two numbers together");
                Console.WriteLine("3. Calulcate the area of a circle");
                Console.WriteLine("4. Calculate the area of a triangle");
                Console.WriteLine("5. Draw a square using the ASCII character 'X'");
                Console.WriteLine("6. Draw a hollow square using the ASCII character 'X'");
                Console.WriteLine("7. Given two integer variables from user input, swap their values");
                Console.WriteLine("8. Reverse a string from user input using a for loop");
                Console.WriteLine("9. Exit the program");
                Console.WriteLine("****************************************");
                Menu(input = int.Parse(Console.ReadLine()));
            } while (input != 0);
            
            if(input == 9)
            {
                Console.ReadLine();
            }
        }

        static void Menu (int input)
        {
            if (input == 1)
            {
                Console.WriteLine("Hello world!");
            }
            if (input == 2)
            {
                Console.WriteLine("First number:");
                int input2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Second number:");
                int input3 = int.Parse(Console.ReadLine());
                int result = input2 + input3;
                Console.WriteLine("The sum of " + input2 + " and " + input3 + " is " + result);

            }
            if (input == 3)
            {
                Console.WriteLine("What is the radius of the circle?");
                int radius = int.Parse(Console.ReadLine());
                double area = Math.PI * (Math.Pow(radius, 2));
                Console.WriteLine("The area of the circle is " + area);
            }
            if(input == 4)
            {
                Console.WriteLine("What is the length of side 1?");
                int side1 = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of side 2?");
                int side2 = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of side 3?");
                int side3 = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the perimeter of the triangle?");
                int perimeter = (side1 + side2 + side3) / 2;
                int areaholder = perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3);
                double area = Math.Sqrt(areaholder);
                Console.WriteLine("The area of the triangle is " + area);
            }
            if(input == 5)
            {
                Console.WriteLine("What is the width of the square?");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the length of the square?");
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                for (int I = 0; I < n; I++)
                {
                    for (int M = 0; M < l; M++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine(" ");
                }
            }
            if(input == 6)
            {
                Console.WriteLine("What is the width of the square?");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                for (int I = 0; I < n; I++)
                {
                    for (int M = 0; M < n; M++)
                    {
                        if (M == 0 || I <= 0 || I == n - 1 || M == n - 1)
                        {
                            Console.Write("X");
                        }

                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine(" ");
                }
            }
            if (input == 7)
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int ThatOneHolder = x;
                x = y;
                y = ThatOneHolder;
            }
            if(input == 8)
            {
                List<char> ThatOneRevString = new List<char>();
                Console.WriteLine("Enter the string you want to reverse:");
                string holder = Console.ReadLine();
                for (int i = holder.Length - 1; i > -1; i--)
                {
                    ThatOneRevString.Add(holder[i]);
                }
                for (int i = 0; i < ThatOneRevString.Count; i++)
                {
                    Console.Write(ThatOneRevString[i]);
                }
                Console.WriteLine("");
            }
        }
    }
}
