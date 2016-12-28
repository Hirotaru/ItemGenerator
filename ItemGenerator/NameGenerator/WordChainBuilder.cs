using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public static class WordChainBuilder
    {
        private static readonly int chance = 70;

        private static Random rand = new Random(DateTime.Now.Millisecond);

        //private static List<Word> chain = new List<Word>();

        private static List<PatternParts> pattern;


        private static int currentRank;

        public static int Rank
        {
            get { return currentRank; }
            set { currentRank = value; }
        }

        public static WordChain Build()
        {
            currentRank = 0;

            while (rand.Next(0, 100) < chance)
            {
                currentRank++;

                if (currentRank == PatternPack.Count - 1)
                {
                    break;
                }
            }

            pattern = PatternPack.Patterns[currentRank];

            WordChain chain = new WordChain(pattern, currentRank);

            BuildChain(chain);

            return chain;   
        }



        private static void BuildChain(WordChain chain)
        {
            foreach (var item in pattern)
            {
                switch (item)
                {
                    case PatternParts.Subject:
                        {
                            Word w = WordManager.GetRandomSubject();

                            chain.AddWord(w);
                            chain.Subj = w.Root;

                            break;
                        }

                    case PatternParts.Object:
                        {
                            chain.AddWord(WordManager.GetRandomObject());
                            break;
                        }

                    case PatternParts.SubObject:
                        {
                            chain.AddWord(WordManager.GetRandomSubObject());
                            break;
                        }

                    case PatternParts.Adjective:
                    case PatternParts.ObjAdjective:
                        {
                            chain.AddWord(WordManager.GetRandomObjAdj());
                            break;
                        }

                    case PatternParts.Adverb:
                        {
                            chain.AddWord(WordManager.GetRandomAdv());
                            break;
                        }

                    case PatternParts.ItemAdjective:
                        {
                            chain.AddWord(WordManager.GetRandomItemAdj());
                            break;
                        }

                    case PatternParts.LegendaryItemAdjective:
                        {
                            chain.AddWord(WordManager.GetRandomLegendaryItemAdj());
                            break;
                        }

                    case PatternParts.LegendaryObjectAdjective:
                        {
                            chain.AddWord(WordManager.GetRandomLegendaryObjectAdj());
                            break;
                        }
                }
            }
        }
    }
}
