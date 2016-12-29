using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class Damage
    {
        private static Random rand = new Random();
        private static double basicDamage = 20;
        private static double basicSpread = 5;
        public double AvgDamage { get; private set; }

        public double DamageSpread { get; private set; }

        public double MinDamage
        {
            get { return AvgDamage - (int)DamageSpread / 2; }
        }

        public double MaxDamage
        {
            get { return AvgDamage + (int)DamageSpread / 2; }
        }

        public Damage(int rank)
        {
            AvgDamage = basicDamage;
            DamageSpread = basicSpread;

            for (int i = 0; i < rank; i++)
            {
                AvgDamage = (int)Math.Round(AvgDamage * 1.2 + rand.Next(-(int)AvgDamage / 10, (int)AvgDamage / 10), 1);
                DamageSpread = (int)Math.Round(DamageSpread * 1.2 + rand.Next(-(int)DamageSpread / 2, (int)DamageSpread / 2), 1);
            }
        }

    }
}
