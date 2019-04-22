using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob13.out.txt";
            List<string> lines = new List<string>();
            using (StreamReader SR = new StreamReader(path))
            {
                string line = " ";
                while ((line = SR.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            //At this point, lines is a list of every line in the File

            for (int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine(lines);
            }
        }
    }
}
