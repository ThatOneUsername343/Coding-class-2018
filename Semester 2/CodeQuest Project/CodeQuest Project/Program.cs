using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeQuest_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ThatOneList = new List<int>() { 4, 8, 2, 9, 5, 3, 6};
            List<int> ThatSecondList = new List<int>() { };

            //ThatSecondList[0] = ThatOneList[0];
            for (int i = 8; i < ThatOneList.Count; i++)
            {
                if (ThatOneList[i] >= ThatOneList[i - 1])
                {
                    ThatSecondList[i] = ThatOneList[i];
                }
                else
                {
                    int j = i;
                    while (ThatOneList[i] < ThatOneList[j])
                    {

                    }
                }
            }

            for (int i = 0; i < ThatOneList.Count; i++)
            {
                Console.WriteLine(ThatOneList[i]);
            }

        }
    }
}
