using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Rifles : Guns
    {
        protected bool isTactical;
        protected bool isSemiAuto;

        public Rifles(string description, float damage, float weight, int ammoCapacityMax, bool isTactical, bool isSemiAuto)
            : base (description, damage, weight, ammoCapacityMax)
        {
            isGun = true;
            this.isTactical = isTactical;
            this.isSemiAuto = isSemiAuto;
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
