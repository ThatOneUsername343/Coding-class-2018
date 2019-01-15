using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Guns : Weapons
    {
        protected bool isOverheated;
        protected int ammoCapacityMax;
        protected int ammoCapacityCur;
        protected float damageDropOff;
        protected float fireRate;

        public Guns(string description, float damage, float weight, int ammoCapacityMax)
            : base (description, damage, weight)
        {
            isGun = true;
            this.ammoCapacityMax = ammoCapacityMax;
            ammoCapacityCur = ammoCapacityMax;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void ActivateItem()
        {

        }
    }
}
