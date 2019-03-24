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
                while ((line = Strem.ReadLine()) != null)
                {
                    int number = int.Parse(line);
                    for (int i = 1; i < number; i++)
                    {
                        if (line[i - 1] > line[i])
                        {
                            Console.WriteLine("Ordered by descending");
                        }
                    }

                    ////for (int i = 0; i < number; i++)
                    ////{
                    ////Check if in ascending order
                    //var result = line.OrderBy(a => a);
                    //if (line.SequenceEqual(result))
                    //{
                    //    Console.WriteLine("Ordered by Asc");
                    //    return;
                    //}
                    ////}
                }
                Console.ReadLine();
            }
        }
    }
}
