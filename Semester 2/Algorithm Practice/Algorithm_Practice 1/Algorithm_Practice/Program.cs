using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";
            using (StreamReader Strem = new StreamReader(path))
            {
                string line;
                float ThatOneFloat = 0;
                while ((line = Strem.ReadLine()) != null)
                {
                    if (line.Contains("QUARTER"))
                    {
                        line = line.Substring(8);
                        ThatOneFloat += float.Parse(line) * .25f;
                    }

                    if (line.Contains("DIME"))
                    {
                        line = line.Substring(5);
                        ThatOneFloat += float.Parse(line) * .1f;
                    }

                    if (line.Contains("NICKEL"))
                    {
                        line = line.Substring(7);
                        ThatOneFloat += float.Parse(line) * .05f;
                    }

                    if (line.Contains("HALFDOLLAR"))
                    {
                        line = line.Substring(11);
                        ThatOneFloat += float.Parse(line) * .5f;
                    }

                    if (line.Contains("PENNY"))
                    {
                        line = line.Substring(6);
                        ThatOneFloat += float.Parse(line) * .01f;
                    }
                }

                Console.WriteLine("$" + ThatOneFloat + " USD");
                Console.ReadLine();
            }
        }
    }
}
