using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            int Input;
            Stack myStack = new Stack();

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Add something to the top of the stack");
                Console.WriteLine("2. Remove the top element of the stack");
                Console.WriteLine("3. return the top element of the stack");
                Console.WriteLine("4. Exit this thing.");
                Input = int.Parse(Console.ReadLine());

                if (Input == 1)
                {
                    Console.WriteLine("Type the value you would like to add.");
                    myInt = int.Parse(Console.ReadLine());
                    myStack.Push(myInt);
                }

                if (Input == 2)
                {
                    myInt = myStack.Pop();
                    Console.WriteLine(myInt + " is the new top value.");
                }

                if (Input == 3)
                {
                    myInt = myStack.Peek();
                    Console.WriteLine(myInt + " is the new top value.");
                }
            } while (Input != 4);
        }
    }
}
