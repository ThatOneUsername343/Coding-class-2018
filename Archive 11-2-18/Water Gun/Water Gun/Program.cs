using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Gun
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Watergun
    {
        float capacity = 1f;
        Random rand = new Random();
        double refill = .25;
        bool iswet = false;

        public Watergun()
        {

        }

        public bool Shoot(float amount)
        {
            if (capacity > 0)
            {
                capacity -= amount;
                float percentChance = (amount * .2f) + .2f;
                if (rand.NextDouble() < percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
