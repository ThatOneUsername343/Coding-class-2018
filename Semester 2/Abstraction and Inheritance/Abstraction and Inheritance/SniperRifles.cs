using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class SniperRifles : Guns
    {
        protected float Accuracy;
        protected bool isBoltAction;

        public SniperRifles(string description, float damage, float weight, int ammoCapacityMax, float Accuracy, bool isBoltAction)
            : base(description, damage, weight, ammoCapacityMax)
        {
            isGun = true;
            this.Accuracy = Accuracy;
            this.isBoltAction = isBoltAction;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void ActivateItem()
        {
            if (ammoCapacityCur > 0)
            {
                Console.WriteLine("You just did " + damage + " damage to your opponent. You have " + ammoCapacityCur + " remaining ammo.");
                ammoCapacityCur--;
            }

            else
            {
                Console.WriteLine("No ammo!");
            }
        }
    }
}
