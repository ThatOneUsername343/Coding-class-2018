using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algorithm_Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Decrypt();
        }
        static void Decrypt()
        {
            List<string> ThatOneCypher = new List<string>();
            List<char> ThatCodedText = new List<char>();
            string line;
            int ThatOneHolder;
            Console.WriteLine("Input the shift number from -25 to 25");
            Console.WriteLine("Input yo phrase");
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_.txt";
            using (StreamReader Strem = new StreamReader(path))
            {
                while ((line = Strem.ReadLine()) != null)
                {
                    ThatOneCypher.Add(line);
                }
            }
            for (int i = 1; i <= ThatOneCypher.Count - 1; i++)
            {
                string[] ThatOneArray = ThatOneCypher[i].Split('-', ' ');
                for (int k = 0; k < ThatOneArray.Length; k++)
                {
                    ThatCodedText.Add(ThatOneCypher[0][int.Parse(ThatOneArray[k]) - 1]);
                }
                for (int p = 0; p <= ThatCodedText.Count - 1; p++)
                {
                    Console.Write(ThatCodedText[p]);
                }
                ThatCodedText.Clear();
                Console.WriteLine();
            }
        }
    }
}
