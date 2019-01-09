using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will tell the computer to pick a number between 0 and 1000
            Random rand = new Random();
            int ThatOneGuessingGame = 0;
            ThatOneGuessingGame = rand.Next(0, 1000);
            int Input = 0;
            int Count = 0;
            Console.WriteLine("Guess my number.");

            //This will ask the user for input and tell whether it is too high or too low
            do
            {
                Input = int.Parse(Console.ReadLine());

                if (Input < ThatOneGuessingGame)
                {
                    Console.WriteLine("YOU ARE BENEATH ME! MUAHAHAHAHAHAAAAAA!!");

                }
                else if (Input > ThatOneGuessingGame)
                {
                    Console.WriteLine("You're suuuper high, man.");
                }
                Count++;
            } while (Input != ThatOneGuessingGame);
            Console.WriteLine("It took you " + Count + " tries to figure this out. Wow. How depressing. My number was " + ThatOneGuessingGame);
            Console.WriteLine("Press a key. Any key. I dare you. See what happens >F)");
            Console.ReadKey();

            //This will keep the program running until the user has guessed the right number
            

            //using an if statement, if the input is correct, this causes the computer to say "you guessed it right" and close the program
                //using an else if statement, if the input is incorrect, this causes the computer to say "Guess again."
        }
    }
}
