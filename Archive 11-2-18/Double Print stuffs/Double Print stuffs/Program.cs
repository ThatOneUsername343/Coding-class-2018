using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Print_stuffs
{
    class Program
    {
        static void Main(string[] args)
        {
            double f = Math.PI;
            PDO(f);
        }

        static void PDO(double x, int y = 2)
        {
            string s = "0.";
            int precisionVar = y;
            for (int i = 0; i < y - 1; i++)
            {
                s = s + "#";
            }
            //Expected output = 3.14
            string printVal = x.ToString(s);
            Console.WriteLine(printVal);
        }
    }
}
