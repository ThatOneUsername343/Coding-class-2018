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
            Random rand = new Random();
            int ThatOneRandomThing;
            List<int> ThatOneList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                ThatOneRandomThing = rand.Next(0, 10);
                ThatOneList.Add(ThatOneRandomThing);
                Console.WriteLine(ThatOneList[i]);
                Console.ReadKey();
            }

            List<int> ThatBetterList = new List<int>();
            int AnInputIGuess = 0;
            Console.WriteLine("INPUT SOME STUFF YOU SCRUB");
            while (AnInputIGuess != 10)
            {
                AnInputIGuess = int.Parse(Console.ReadLine());
                ThatBetterList.Add(AnInputIGuess);
            }

        }
    }
}
