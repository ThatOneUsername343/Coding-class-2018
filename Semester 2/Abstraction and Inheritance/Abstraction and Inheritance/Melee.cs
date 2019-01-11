using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Melee : Weapons
    {
        public Melee(float damage, float weight)
            : base (damage, weight)
        {
            isMelee = true;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
