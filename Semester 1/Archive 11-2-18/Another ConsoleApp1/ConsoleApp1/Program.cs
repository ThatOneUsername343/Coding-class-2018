using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char e = 'e';
            int shift = -3;
            char shifted = (char)(e + shift);
            Console.WriteLine(shifted);
        }
    }
}
