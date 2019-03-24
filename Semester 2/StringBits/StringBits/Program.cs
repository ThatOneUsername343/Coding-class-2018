using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string ThatOneString = "Heeololoo";
            for (int i = 0; i < ThatOneString.Length + 1/2; i++)
            {
                Console.Write(ThatOneString[counter]);
                counter = counter + 2;
            }
        }
    }
}
