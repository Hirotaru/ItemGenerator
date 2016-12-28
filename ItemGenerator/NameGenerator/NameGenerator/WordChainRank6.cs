using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class WordChainRank6 : WordChain
    {
        public new const int chance = 75;

        private static Random rand = new Random(DateTime.Now.Millisecond);

        public WordChainRank6()
        {
            chain = new List<Word>();

            pattern = new List<PatternParts>()
            {
                PatternParts.Adjective,
                PatternParts.Subject,
                PatternParts.Adjective,
                PatternParts.Object

            };
        }

        public override WordChain Create()
        {
            if (rand.Next(0, 100) < chance)
            {
                WordChainRank7 chain = new WordChainRank7();
                return chain.Create();
            }
            else
            {
                BuildChain();

                return this;
            }
        }
    }
}
