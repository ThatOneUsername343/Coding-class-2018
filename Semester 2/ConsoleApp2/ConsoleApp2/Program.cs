using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ThatOneHolder = "Hello";
            for (int i = 0; i <= ThatOneHolder.Length; i++)
            {
                for (int f = 0; f < i + 1; f++)
                {
                    Console.Write(ThatOneHolder[f]);
                }

                
            }
            Console.ReadLine();
        }
    }
}
