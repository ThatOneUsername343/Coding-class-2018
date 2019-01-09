using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                x = menu();
                if (x == 1)
                {
                    Square(int.Parse(Console.ReadLine()));
                    Console.ReadKey();
                    Console.Clear();
                }
                if (x == 2)
                {
                    Rectangle((int.Parse(Console.ReadLine())), (int.Parse(Console.ReadLine())));
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (x != 3);
        }
        static void Rectangle(int length, int width)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                Console.WriteLine();
            }
        }
        static void Square(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("X");

                }
                Console.WriteLine();
            }
        }
        static int menu()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("1. input square");
            Console.WriteLine("2. input rectangle");
            Console.WriteLine("3. exit");
            Console.WriteLine("***********************");
            int x;
            x = int.Parse(Console.ReadLine());
            return x; 
        }
    }
}
