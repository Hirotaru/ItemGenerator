using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public class WordChain
    {
        private List<Word> chain;

        private List<PatternParts> pattern;

        private int currentRank;

        private string subj;

        public string Subj
        {
            get { return subj; }
            internal set { subj = value; }
        }


        public int Rank
        {
            get { return currentRank; }
            internal set { currentRank = value; }
        }

        public WordChain(List<PatternParts> pattern, int rank)
        {
            chain = new List<Word>();

            this.pattern = pattern;

            Rank = rank;
        }

        internal void AddWord(Word word)
        {
            chain.Add(word);

            if (word is Noun)
            {
                if (chain.Count > 1)
                {
                    if (chain.Count == 3)
                    {
                        if (chain[chain.Count - 3] is Adjective && chain[chain.Count - 2] is Adjective)
                        {
                            (chain[chain.Count - 3] as Adjective).WordAfter = word as Noun;
                        }

                    }

                    if (chain[chain.Count - 2] is Adjective)
                    {
                        (chain[chain.Count - 2] as Adjective).WordAfter = word as Noun;
                    }
                }
            }
        }

        public string GetName(bool rank = false)
        {
            StringBuilder sb = new StringBuilder();

            if (rank)
            {
                sb.Append("Rank ");
                sb.Append((currentRank + 1).ToString());
                sb.Append(": ");

            }

            foreach (var item in chain)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }

            return sb.ToString();
        }

    }
}
