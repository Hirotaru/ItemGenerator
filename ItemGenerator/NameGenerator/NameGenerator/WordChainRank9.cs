using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class WordChainRank9 : WordChain
    {
        public new const int chance = 75;

        private static Random rand = new Random(DateTime.Now.Millisecond);

        public WordChainRank9()
        {
            chain = new List<Word>();

            pattern = new List<PatternParts>()
            {
                //PatternParts.Adverb,
                PatternParts.Adjective,
                PatternParts.Subject,
                PatternParts.Adjective,
                PatternParts.Object,
                PatternParts.Object
            };
        }

        public override WordChain Create()
        {
            BuildChain();

            return this;
        }
    }
}
