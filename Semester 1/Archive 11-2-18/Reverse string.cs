using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string MASSIVEXPLOSION = Console.ReadLine();
            int[] EvilStringFam = new int[MASSIVEXPLOSION.Length];
            for (int i = MASSIVEXPLOSION.Length; i > 0; i--)
            {
                Console.WriteLine(MASSIVEXPLOSION[i - 1] + " ");
            }
        }
    }
}
