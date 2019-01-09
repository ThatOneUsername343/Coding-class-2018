using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i  = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 30; j+= i)
                {
                    Console.WriteLine(j + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
