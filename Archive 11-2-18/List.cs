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
            int X = 0;
            Console.WriteLine("INPUT SOME STUFF YOU SCRUB");
            while (X != 10)
            {
                AnInputIGuess = int.Parse(Console.ReadLine());
                ThatBetterList.Add(AnInputIGuess);
                X++;
            }
            Console.WriteLine("IM GONNA ADD ALL THAT STUFF YOU JUST WROTE ON ME TO THAT LIST! MUAHAHAHAHAHAHAAAAAAAAA");
            for (int I = 0; I < 10; I++)
            {
                Console.WriteLine(ThatBetterList[I]);
                Console.ReadKey();
            }
        }
    }
}
