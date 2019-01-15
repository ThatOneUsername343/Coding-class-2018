using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Bladed : Melee
    {
        protected bool isBipodKnife;

        public Bladed(string description, float damage, float weight, bool isBipodKnife)
            : base(description, damage, weight)
        {
            isMelee = true;
            this.isBipodKnife = isBipodKnife;
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void ActivateItem()
        {
            Console.WriteLine("You just did " + damage + " damage to your opponent.");
        }
    }
}
