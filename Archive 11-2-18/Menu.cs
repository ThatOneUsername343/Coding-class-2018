using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int PassengerSeat666;
            int Input = 0;
            List<int> Passengers = new List<int>(10);
            while (Input != 4)
            {
                {
                    Console.WriteLine("1. Put rider in a random seat. Chaos all around! :D");
                    Console.WriteLine("2. List all the available seats that haven't been taken by the people who got here before you did because you slept in late. Also, tell me how many people there are.");
                    Console.WriteLine("3. START THE RIDE ALREADY OMFG");
                    Console.WriteLine("4. Exit Program.");
                    Input = int.Parse(Console.ReadLine());
                }

                while (Input == 1)
                for (int i = 0; i < 1; i++)
                {
                    PassengerSeat666 = rand.Next(0, 10);
                    Console.WriteLine("Your seat number is " + PassengerSeat666);
                    Input = 0;
                }

                while (Input == 2)
                {
                    Console.WriteLine("The only available seat is number 666. Thank you for flying with us. Also, there are 7 billion people.");
                    Console.ReadLine();
                    Input = 0;
                }
                
                while (Input == 3)
                {
                    Console.WriteLine("OMFG OKAY I'LL START THE RIDE STAHP YELLING AT ME!!!!!!!!!");
                    Input = 0;
                }

                while (Input == 4)
                {
                    Console.WriteLine("Ok. I can tell when I'm unwanted.");
                    Input = 0;
                }
            }
        }
    }
}
