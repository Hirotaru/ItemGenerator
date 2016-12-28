using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class WordChainRank7 : WordChain
    {
        public new const int chance = 75;

        private static Random rand = new Random(DateTime.Now.Millisecond);

        public WordChainRank7()
        {
            chain = new List<Word>();

            pattern = new List<PatternParts>()
            {
                PatternParts.Adjective,
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
                WordChainRank8 chain = new WordChainRank8();
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
