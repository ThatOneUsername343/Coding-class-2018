using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMoore_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //        public static bool IsPalindrome(string value)
            //    {
            //        int min = 0;
            //        int max = value.Length - 1;
            //        while (true)
            //        {
            //            if (min > max)
            //            {
            //                return true;
            //            }
            //            char a = value[min];
            //            char b = value[max];
            //            if (char.ToLower(a) != char.ToLower(b))
            //            {
            //                return false;
            //            }
            //            min++;
            //            max--;
            //        }
            //    }

            //    static void Main()
            //    {
            //        string[] array =
            //        {
            //            "civic",
            //            "deified",
            //            "deleveled",
            //            "devoved",
            //            "dewed",
            //            "Hannah",
            //            "kayak",
            //            "level",
            //            "madam",
            //            "racecar",
            //            "radar",
            //            "redder",
            //            "refer",
            //            "repaper",
            //            "reviver",
            //            "rotator",
            //            "rotor",
            //            "sagas",
            //            "solos",
            //            "stats",
            //            "tenet",

            //            "Dot",
            //            "Net",
            //            "Perls",
            //            "Is",
            //            "Not",
            //            "A",
            //            "Palindrome",
            //            ""
            //        };

            //        foreach (string value in array)
            //        {
            //            Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            //        }
            //    }
            //}

            //bool IsPalindrome(string Palindrome)
            //{
            //    int i = 0;
            //    int j = Palindrome.Length - 1;

            //    while (i < j)
            //    {
            //        if (Palindrome[i] != Palindrome[j])
            //            return false;

            //        i++;
            //        j--;
            //    }
            //    return true;
            //}
            //string ThatOnePalindrome = ;
            //int[] OppPalindrome = new int[ThatOnePalindrome.Length];
            //int[] OppPalindrome = new int[ThatOnePalindrome.Length];

            //for (int i = 0; i > 0; i++)

            //bool IsPalindrome(string ThatOnePalindrome)
            Console.WriteLine("Write something and this bad boy here will test to see if it is a palindrome.");
            string ThatOnePalindrome = "";
            for (int i = 0; i == ThatOnePalindrome.Length; i++)
            {
                string ThatOneString = "";
                for (int N = 0; N == ThatOneString.Length; N++)
                {
                    for (int j = 0; j == i; j--)
                    {
                        int Length;
                        Console.Write("Enter A String: ");
                        ThatOneString = Console.ReadLine();
                        Length = ThatOneString.Length - 1;
                        while (Length >= 0)
                        {
                            ThatOnePalindrome = ThatOnePalindrome + ThatOneString[Length];
                            Length--;
                        }

                        if (ThatOnePalindrome == ThatOneString)
                        {
                            Console.WriteLine("This is a palindrome. Yay? I guess?");
                            Console.WriteLine();
                        }

                        else if (ThatOnePalindrome != ThatOneString)
                        {
                            Console.WriteLine("This is not a palindrome. So sad.");
                            Console.ReadLine();
                        }
                    }
                }
                //ThatOnePalindrome = Console.ReadLine();

                //char[] ThatOneArray = ThatOnePalindrome.ToCharArray();
                //Array.Reverse(ThatOneArray);
                //string OppPalindrome = new string(ThatOneArray);
                //return ThatOnePalindrome == OppPalindrome;
                //for (int i = 0, j = ThatOnePalindrome.Length - 1; i < j; i++, j--)
                //{
                //    if (ThatOnePalindrome[i] != ThatOnePalindrome[j])
                //    {
                //        return false;
                //    }
                //}
                //return true;
                //int i = ThatOnePalindrome.Length - 1;
                //int j = 0;
                //while (j < i)
                //{
                //    if (ThatOnePalindrome[j] != ThatOnePalindrome[i])
                //        return false;

                //    j++;
                //    i--;
                //    //Console.WriteLine(ThatOnePalindrome[i]);
                //}
                //return true;

                //if (i == OppPalindrome.Length)
                //{
                //    Console.WriteLine("This is a palindrome. Yay? I guess?");
                //    Console.ReadLine();
                //}

                //else if (i != OppPalindrome.Length)
                //{
                //    Console.WriteLine("This is not a palindrome. So sad.");
                //    Console.ReadLine();
                //}
            }
        }
    }
}