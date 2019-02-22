using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringTimes("Hello There. ", 5));
        }

        public static string StringTimes(string ThatOneString, int n)
        {
            return new StringBuilder(ThatOneString.Length * n).Insert(0, ThatOneString, n).ToString();
        }
    }
}
