using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Guns : Weapons
    {
        public bool isOverheated;
        public float ammoCount;
        public float damageDropOff;
        public float fireRate;

        public Guns(float damage, float weight)
            : base (damage, weight)
        {
            isGun = true;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
