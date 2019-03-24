using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Queue
{
    class Queue<T> : IEmptyable, IComparable, ICountable where T : IComparable
    {

    }
}
