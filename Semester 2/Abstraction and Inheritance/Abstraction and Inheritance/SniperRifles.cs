using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class SniperRifles : Guns
    {
        public float Accuracy;
        public bool isBoltAction;

        public SniperRifles(float damage, float weight)
            : base(damage, weight)
        {
            isGun = true;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
