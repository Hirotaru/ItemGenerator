using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class Util
    {
        private static Random rand = new Random();

        public static readonly int basicDamage = 20;
        public static readonly int basicDamageSpread = 5;

        public static int CalculateDamage(int rank)
        {
            return basicDamage + (int)Math.Round(basicDamage * rank / 5f) + rand.Next(-rank * 2, rank * 2);
        }

        public static int CalculateDamageSpread(int rank)
        {
            return basicDamageSpread + (int)Math.Round(basicDamageSpread * rank / 2f) + rand.Next(-rank, rank);
        }
    }
}
