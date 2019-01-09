using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routine
{
    class Program
    {
        static void Main(string[] args)
        {
            int Radix = int.Parse(Console.ReadLine());
            int I = int.Parse(Console.ReadLine());
            RadixClass(Radix, I);

        }
        static void RadixClass(int Radix, int I)
        {
            int Remainder = I % Radix;
            int Quotient = I / Radix;
            if (Quotient != 0)
            {
                RadixClass(Quotient, Radix);
            }
            Remainder = Remainder + 94;
            if (Remainder >= 0)
            {
                char Y = (char)Remainder;
                Console.Write(Y);
                Console.ReadKey();
            }
            else if(Remainder >= 0)
            {
                Remainder = Remainder * -1;
                I = (char)Remainder;
                Console.Write("-" + I);
                Console.ReadKey();
            }
        }
    }
}
