using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree Tree = new BinaryTree();
            Tree.Insert('a');
            Tree.Insert('s');
            Tree.Insert('v');
            Tree.Insert('n');
            Tree.Insert('h');
            Tree.Insert('b');
            Tree.Print();
        }
        
    }
}
