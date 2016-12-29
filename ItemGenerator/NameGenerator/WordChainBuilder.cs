using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public static class WordChainBuilder
    {
        private static int chance = 70;

        private static Random rand = new Random(DateTime.Now.Millisecond);

        //private static List<Word> chain = new List<Word>();

        private static List<PatternParts> pattern;


        private static int currentRank;

        public static int Rank
        {
            get { return currentRank; }
            set { currentRank = value; }
        }

        public static WordChain Build(int rank = -1)
        {
            currentRank = (rank == -1) ? 0 : rank;

            while (rand.Next(0, 100) < chance)
            {
                currentRank++;

                if (currentRank == PatternPack.ItemCount - 1)
                {
                    break;
                }
            }

            pattern = PatternPack.ItemPatterns[currentRank];

            WordChain chain = new WordChain(pattern, currentRank);

            BuildChain(chain);

            return chain;   
        }

        public static WordChain BuildPotion(int rank = -1)
        {
            currentRank = (rank == -1) ? 0 : rank;

            while (rand.Next(0, 100) < chance)
            {
                currentRank++;

                if (currentRank == PatternPack.PotionCount - 1)
                {
                    break;
                }
            }

            pattern = PatternPack.PotionPatterns[currentRank];

            WordChain chain = new WordChain(pattern, currentRank);

            BuildChain(chain);

            return chain;
        }

        public static WordChain Build(ItemType type)
        {
            switch (type)
            {
                case ItemType.Potion:
                    {
                        return BuildPotion();
                    }

                case ItemType.Equipment:
                case ItemType.Spell:
                case ItemType.Weapon:
                    {
                        return Build();
                    }

                default:
                    return null;
            }
        }

        public static bool SetUpgradeChance(int chance)
        {
            if (chance > 99) return false;

            if (chance < 1) return false;

            WordChainBuilder.chance = chance;

            return true;
        }

        private static void BuildChain(WordChain chain)
        {
            foreach (var item in pattern)
            {
                if (item is PatternParts.Subject || item is PatternParts.Potion)
                {
                    Word w = WordManager.GetAWord(item);
                    chain.Subj = w.Root;
                    chain.AddWord(w);
                }
                else
                chain.AddWord(WordManager.GetAWord(item));
            }
        }
    }
}
