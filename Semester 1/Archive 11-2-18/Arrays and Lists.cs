using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] ThatBetterArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 10; i > 0; i--)
            //{
            //  ThatBetterArray[i] = 0;
            //}

            //List<int> ThatOneList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int I = 0; I < 10; I++)
            //{
            //    ThatOneList.Add(I);
            //    Console.WriteLine(ThatOneList);
            //}

            //for (int I = ThatOneList.Count - 1; I > 0; I--)
            //{
            //    ThatOneList.RemoveAt(I);
            //}
            //Console.WriteLine(ThatOneList);
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
            for (int i = ThatOneList.Count - 1; i > 0; i--)
            {
                ThatOneList.RemoveAt(i);
            }

            int[] ThatBetterArray = new int[10];
            for (int I = 0; I < 10; I++)
            {
                ThatBetterArray[I] = 0;
            }
        }
    }
}
