using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your weapon type:");
            Console.ReadKey();
            Console.WriteLine("\n");
            List<Guns> weapons = new List<Guns>();
            weapons.Add(new Rifles("For combat at any range.", 40, 20, 30, true, false));
            weapons.Add(new Pistols("Use as a last resort.", 30, 5, 12, true));
            weapons.Add(new SniperRifles("WARNING: AUTHORIZED QU1KSCOPERS ONLY!", 85, 35, 5, 100, true));
            weapons.Add(new Shotguns("For close-quarters combat only. Do NOT try to snipe people with it.", 60, 20, 8, false, 1));
            weapons.Add(new SubmachineGuns("For close to medium range combat.", 30, 15, 40, true));

            for (int i = 0; i < weapons.Count; i++)
            {
                weapons[i].ActivateItem();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
                Console.WriteLine("\n");
            }

            Console.WriteLine("You have used every gun in your inventory. Now you will use your melee weapons.");
            Console.ReadKey();
            Console.WriteLine("\n");

            List<Melee> weapons2 = new List<Melee>();
            weapons2.Add(new Blunt("A blunt weapon. Cool... I guess.", 50, 15));
            weapons2.Add(new Bladed("Your very own bipod knife, no bucket required. Rumored to be the favorite weapon of the greatest soldier on the battlefield.", 9000, 0, true));

            for (int i = 0; i < 2; i++)
            {
                weapons2[i].ActivateItem();
            }

            Console.WriteLine("End of testing. Press any key to terminate program");
            Console.ReadKey();
        }
    }
}
