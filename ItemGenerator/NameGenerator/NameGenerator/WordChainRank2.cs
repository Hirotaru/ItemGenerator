using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public class WordChainRank2 : WordChain
    {
        public new const int chance = 75;

        private static Random rand = new Random(DateTime.Now.Millisecond);

        public WordChainRank2()
        {
            chain = new List<Word>();

            pattern = new List<PatternParts>()
            {
                PatternParts.Adjective,
                PatternParts.Subject
                
            };
        }

        public override WordChain Create()
        {
            if (rand.Next(0, 100) < chance)
            {
                WordChainRank3 chain = new WordChainRank3();
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
