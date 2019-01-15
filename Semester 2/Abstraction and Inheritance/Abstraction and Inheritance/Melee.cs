﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    class Melee : Weapons
    {
        public Melee(string description, float damage, float weight)
            : base (description, damage, weight)
        {
            isMelee = true;
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
