using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class WordChainRank8 : WordChain
    {
        public new const int chance = 75;

        private static Random rand = new Random(DateTime.Now.Millisecond);

        public WordChainRank8()
        {
            chain = new List<Word>();

            pattern = new List<PatternParts>()
            {
                PatternParts.Adverb,
                PatternParts.Adjective,
                PatternParts.Subject,
                PatternParts.Adjective,
                PatternParts.Object,
                //PatternParts.Object
            };
        }

        public override WordChain Create()
        {
            if (rand.Next(0, 100) < chance)
            {
                WordChainRank9 chain = new WordChainRank9();
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
