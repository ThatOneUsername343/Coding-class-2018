using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_and_Inheritance
{
    abstract class Weapons
    {
        protected float weight;
        protected float damage;
        protected bool isMelee;
        protected bool isGun;
        protected bool isTooHeavy;

        public Weapons(string description, float damage, float weight)
        {
            this.weight = weight;
            this.damage = damage;
        }

        public abstract void MakeSound();

        public abstract void ActivateItem();
    }
}
