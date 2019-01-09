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
            int[] ThatOneArray = new int[10];
            Random rand = new Random();
            ThatOneArray = rand.Next(10);

            for (int i = 0; i < ThatOneArray.Length; i++)
            {
                Console.WriteLine(ThatOneArray[i]);
            }
        }
    }
}
