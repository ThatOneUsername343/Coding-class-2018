using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using LINQ, develop a program that you would otherwise do with for loops or other techniques that you have learned
            List<int> L1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> L2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            List<int> L3 = new List<int>();

            L3 = L1.Intersect(L2).ToList();

            List<int> list1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> list2 = new List<int>();
            list2 = list1.Where(t => t >= 5 == true).ToList();
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);
            }

            
            list1.Where
        }
    }
}
