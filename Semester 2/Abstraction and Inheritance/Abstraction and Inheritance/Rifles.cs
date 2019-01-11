using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Rifles : Guns
    {
        public bool isTactical;
        public bool isSemiAuto;

        public Rifles(float damage, float weight)
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
