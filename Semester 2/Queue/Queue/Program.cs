using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program : IPrintable, IEmptyable, ICountable
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int myInt;
            int Input;
            Queue myQueue = new Queue();

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Add something to the queue");
                Console.WriteLine("2. Remove the first element of the queue");
                Console.WriteLine("3. return the first element of the queue");
                Console.WriteLine("4. Search for dat thing");
                Console.WriteLine("5. Exit this thing.");
                Console.WriteLine();
                Input = int.Parse(Console.ReadLine());

                if (Input == 1)
                {
                    Console.WriteLine("Type the value you would like to add.");
                    myInt = int.Parse(Console.ReadLine());
                    myQueue.EnQueue(myInt);
                }

                if (Input == 2)
                {
                    myInt = myQueue.DeQueue();
                    Console.WriteLine(myInt + " is the new top value.");
                }

                if (Input == 3)
                {
                    myInt = myQueue.Peek();
                    Console.WriteLine(myInt + " is the new top value.");
                }

                if (Input == 3)
                {
                    List<int> foundValues;
                    Console.WriteLine("What values are you looking for");
                    foundValues = myQueue.Search(int.Parse(Console.ReadLine()));
                    Console.WriteLine("The value you searched for is located at ");
                    for (int i = 0; i < foundValues.Count; i++)
                    {
                        Console.WriteLine(foundValues[i]);
                    }
                }
            } while (Input != 5);

            Console.WriteLine();

            QueueGeneric<Currencies> currencies = new QueueGeneric<Currencies>();

            for (int i = 0; i < 10; i++)
            {
                currencies.Enqueue(new Currencies(rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100)));
            }
            Console.WriteLine("Printing currencies queue");
            currencies.Print();
            Console.ReadLine();
        }
    }
}
