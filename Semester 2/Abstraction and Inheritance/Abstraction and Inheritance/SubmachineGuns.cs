using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class SubmachineGuns : Guns
    {
        public bool isAkimbo;

        public SubmachineGuns (float damage, float weight)
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
