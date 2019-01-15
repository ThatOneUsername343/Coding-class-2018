using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class SubmachineGuns : Guns
    {
        protected bool isAkimbo;

        public SubmachineGuns (string description, float damage, float weight, int ammoCapacityMax, bool isAkimbo)
            : base(description, damage, weight, ammoCapacityMax)
        {
            isGun = true;
            this.isAkimbo = isAkimbo;
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
