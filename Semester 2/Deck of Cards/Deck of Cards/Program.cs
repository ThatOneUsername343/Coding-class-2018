using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input;
            Deck thatOneDeck = new Deck();
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Shuffle the deck");
                Console.WriteLine("2. Shuffle it better");
                Console.WriteLine("3. Show yah deck");
                Console.WriteLine("4. Discard a card into the fiery pits of hell");
                Console.WriteLine("5. Show that there discard pile");
                Console.WriteLine("6. Shuffle the draw deck yet again because you STILL didn't shuffle it well");
                Console.WriteLine("7. Draw a card");
                Console.WriteLine("8. Exit this thang");
                Console.WriteLine();
                Input = int.Parse(Console.ReadLine());

                if (Input == 1)
                {
                    thatOneDeck.Shuffle();
                }

                if (Input == 2)
                {
                    thatOneDeck.Shuffle();
                }

                if (Input == 3)
                {
                    thatOneDeck.PrintDeck();
                }

                if (Input == 4)
                {
                    thatOneDeck.Discard();
                }

                if (Input == 5)
                {
                    thatOneDeck.PrintDiscard();
                }

                if (Input == 6)
                {
                    thatOneDeck.Shuffle();
                }

                if (Input == 7)
                {
                    thatOneDeck.Draw();
                }
            } while (Input != 8);

            //if (Input == 8)
            //{
            //    Console.ReadLine();
            //}
        }
    }
}
