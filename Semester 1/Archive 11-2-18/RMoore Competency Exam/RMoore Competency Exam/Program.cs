using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMoore_Competency_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int Input;
            int[] ThatOneArray = new int[10];

            //ThatOneArray[0] = ;
            //ThatOneArray[1] = ;
            //ThatOneArray[2] = ;
            //ThatOneArray[3] = ;
            //ThatOneArray[4] = ;
            //ThatOneArray[5] = ;
            //ThatOneArray[6] = ;
            //ThatOneArray[7] = ;
            //ThatOneArray[8] = ;
            //ThatOneArray[9] = ;

            do
            {
                Console.WriteLine("*****************************************************");
                Console.WriteLine("1. Conditionals");
                Console.WriteLine("2. For loops");
                Console.WriteLine("3. While loops");
                Console.WriteLine("4. Arrays");
                Console.WriteLine("5. Lists");
                Console.WriteLine("-1. Exit");
                Console.WriteLine("*****************************************************");
                Input = int.Parse(Console.ReadLine());
                
                //Grade level and reading level
                if (Input == 1)
                {
                    string grade = "What is your current grade level:";
                    int gradeinput;
                    gradeinput = int.Parse(Console.ReadLine());
                    string readgrade = "What is your current reading level:";
                    int readgradeinput;
                    readgradeinput = int.Parse(Console.ReadLine());
                    string proficient = "you are proficient in reading.";
                    int proficiency = 0;
                    Console.WriteLine(grade);
                    Console.ReadLine();
                    if (gradeinput <= 5 && readgradeinput <= 5)
                    {
                        Console.WriteLine("You are in elementary school and " + proficient);
                    }

                    if (gradeinput > 10 && readgradeinput > 5)
                    {
                        Console.WriteLine("You are in middle school and " + proficient);
                    }

                    if (gradeinput >= 14 && readgradeinput > 5)
                    {
                        Console.WriteLine("You are in high school and " + proficient);
                    }
                }
                
                //asks for a number
                else if (Input == 2)
                {
                    Console.WriteLine("Pick a number to count by:");
                    int CountByInput;
                    int CountToInput;
                    CountByInput = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pick a number to count to:");
                    CountToInput = int.Parse(Console.ReadLine());
                    for (int i = 0; i < CountToInput; i += CountByInput)
                    {
                        Console.WriteLine(i);
                    }
                }
                
                //enters integer values to add to, and print the sum
                else if (Input == 3)
                {
                    Console.WriteLine("Our sum starts at 0. Enter integer values to add to, and print the sum. Enter 0 to stop adding.");
                    Console.WriteLine("Enter a value:");
                    int userinput;
                    userinput = int.Parse(Console.ReadLine());
                    while (userinput != 0)
                    {
                        Console.WriteLine("new sum: " + userinput);
                        Console.WriteLine("Enter a value:");
                    }
                    if (userinput == 0)
                    {
                        
                    }
                }
                
                //
                else if (Input == 4)
                {

                }
                
                //Create a list
                else if (Input == 5)
                {
                    List<string> ThatOneList = new List<string>() {"hello there", "I am awesome", "Massive explosion" };
                    for (int i = ThatOneList.Count + 1; i > 3; i++)
                    {
                        ThatOneList.Add(i);
                        Console.WriteLine(i);

                        if (ThatOneList = "end")
                        {
                            Console.WriteLine(ThatOneList[i]);

                        }
                    }
                }
                
                //exits the program
                else if (Input == -1)
                {
                    Console.ReadLine();
                }
            } while (Input != -1);
        }
    }
}
