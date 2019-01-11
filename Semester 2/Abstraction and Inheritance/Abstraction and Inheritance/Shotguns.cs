using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Shotguns : Guns
    {
        public bool hasChoke;
        public float barrelCount;

        public Shotguns(float damage, float weight)
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
