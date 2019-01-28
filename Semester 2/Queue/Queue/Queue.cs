using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        List<int> holder = new List<int>();

        public Queue()
        {

        }

        //EnQueue
        public void EnQueue(int val)
        {
            holder.Add(val);
        }

        //DeQueue
        public int DeQueue()
        {
            if (holder.Count != 0)
            {
                int myInt = holder[0];
                holder.RemoveAt(0);
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
            if(holder.Count != 0)
            {
                return holder[0];
            }
            else
            {
                return 0;
            }
        }

        //Print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.WriteLine(holder[i] + ",");
            }
        }

        //Search
        public List<int> Search (int val)
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < holder.Count; i++)
            {
                if (val == holder[i])
                {
                    positions.Add(i);
                }
            }
            return positions;
        }
    }
}
