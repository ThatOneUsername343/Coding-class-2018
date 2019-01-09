using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Stack
    {
        List<int> holder = new List<int>();

        public Stack()
        {

        }

        //Push
        public void Push(int val)
        {
            holder.Add(val);
        }

        //Pop
        public int Pop()
        {
            if (holder.Count > 0)
            {
                int myInt;
                myInt = holder.Last();
                holder.RemoveAt(holder.Count() - 1);
                return myInt;
            }

            else
            {
                Console.WriteLine("STACK UNDERFLOW BIACH!!!!");
                return 0;
            }
        }

        //Peek
        public int Peek()
        {
            int myInt;
            myInt = holder.Last();
            return myInt;
        }

        //Print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.WriteLine(holder[i] + ",");
            }
        }
    }
}
