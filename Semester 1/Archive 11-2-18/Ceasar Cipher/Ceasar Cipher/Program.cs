using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceasar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ThatOneCipher = new List<int>();
            List<char> SuperSecretText = new List<char>();
            List<char> AngryBrute = new List<char>();
            int Input;
            string Message;
            int PreCypher;
            char shifted;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Encrypt a message");
                Console.WriteLine("2. Decrypt a message");
                Console.WriteLine("3. ANGRY BRUTE FORCE AAAAAAAAAAAAAAAAAAAAAAAAAA");
                Console.WriteLine("3. Exit");
                Console.WriteLine("**********************************");
                Input = int.Parse(Console.ReadLine());

                if (Input != 4)
                {
                    //for (int i = Message.Length; i < 25; i++)
                    //{
                    //Encrypting a message
                    if (Input == 1)
                    {
                        int Shift;
                        Console.WriteLine("Enter a shift value:");
                        Shift = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a message to encrypt:");
                        Message = Console.ReadLine();

                        for (int i = 0; i < Message.Length; i++)
                        {
                            int e = Message[i];
                            PreCypher = Message[i];
                            ThatOneCipher.Add(e + Shift);


                            //Console.WriteLine("Your encrypted code is: ");

                        }
                        for (int k = 0; k <= Message.Length - 1; k++)
                        {
                            if (ThatOneCipher[k] >= 123)
                            {
                                ThatOneCipher[k] = ThatOneCipher[k] - 26;

                            }

                            else if (ThatOneCipher[k] <= 96)
                            {
                                ThatOneCipher[k] = ThatOneCipher[k] + 26;
                            }
                        }

                        for (int l = 0; l <= Message.Length - 1; l++)
                        {
                            shifted = (char)ThatOneCipher[l];
                            SuperSecretText.Add(shifted);
                        }

                        Console.WriteLine("Un-translating message... plese stand by... done. Your encrypted message is: ");

                        for (int o = 0; o <= Message.Length - 1; o++)
                        {
                            Console.Write(SuperSecretText[o]);
                        }

                        Console.WriteLine();

                        //for (int I = 0; I < 25; I--)
                        //{
                        //    Console.WriteLine("Your encrypted code is:");
                        //    Console.WriteLine(Shifted);
                        //}
                    }

                    //Decrypting a message
                    if (Input == 2)
                    {
                        int Shift;
                        Console.WriteLine("Enter a shift value:");
                        Shift = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a message to decrypt:");
                        Message = Console.ReadLine();

                        for (int i = 0; i < Message.Length; i++)
                        {
                            int e = Message[i];
                            PreCypher = Message[i];
                            ThatOneCipher.Add(e - Shift);


                            //Console.WriteLine("Your encrypted code is: ");

                        }
                        for (int k = 0; k <= Message.Length - 1; k++)
                        {
                            if (ThatOneCipher[k] >= 123)
                            {
                                ThatOneCipher[k] = ThatOneCipher[k] - 26;

                            }

                            else if (ThatOneCipher[k] <= 96)
                            {
                                ThatOneCipher[k] = ThatOneCipher[k] + 26;
                            }
                        }

                        for (int l = 0; l <= Message.Length - 1; l++)
                        {
                            shifted = (char)ThatOneCipher[l];
                            SuperSecretText.Add(shifted);
                        }

                        Console.WriteLine("Translating message... please stand by... done. Your message is: ");

                        for (int o = 0; o <= Message.Length - 1; o++)
                        {
                            Console.Write(SuperSecretText[o]);
                        }

                        Console.WriteLine();
                    }

                    //ANGRY BRUTE FORCE
                    if (Input == 3)
                    {
                        Console.WriteLine("Enter a message to brute force:");
                        Message = Console.ReadLine();

                        for (int i = 0; i < Message.Length; i++)
                        {
                            for (int j = 0; j < 26; j++)
                            {
                                int e = Message[i];
                                PreCypher = Message[i];
                                ThatOneCipher.Add(e - j); //How do I get it to print the message 26 times? 
                                
                            }
                        }

                        for (int k = 0; k <= Message.Length - 1; k++)
                        {
                            if (ThatOneCipher[k] >= 123)
                            {
                                ThatOneCipher[k] = ThatOneCipher[k] - 26;

                            }

                            else if (ThatOneCipher[k] <= 96)
                            {
                                ThatOneCipher[k] = ThatOneCipher[k] + 26;
                            }
                        }

                        for (int l = 0; l <= Message.Length - 1; l++)
                        {
                            shifted = (char)ThatOneCipher[l];
                            SuperSecretText.Add(shifted);
                        }

                        for (int o = 0; o <= Message.Length - 1; o++)
                        {
                            Console.Write(SuperSecretText[o]);
                        }

                        Console.WriteLine();
                    }
                }

                //Exit
                if (Input == 4)
                {
                    Console.ReadKey();
                }
            } while (Input != 4);
        }
    }
}
