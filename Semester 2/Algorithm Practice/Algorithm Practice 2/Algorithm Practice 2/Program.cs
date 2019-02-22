using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";
            using (StreamReader Strem = new StreamReader(path))
            {
                string line;
                int i;
                float thatOneFloat;
                while ((line = Strem.ReadLine()) != null)
                {
                    IEnumerable<line> 
                }

                Console.ReadLine();
            }
        }
    }
}
