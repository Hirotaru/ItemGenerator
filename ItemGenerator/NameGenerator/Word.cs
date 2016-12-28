using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public enum WordKind
    {
        M,
        F,
        N
    }

    public class Word
    {
        private string root;

        public string Root
        {
            get { return root; }
            set { root = value; }
        }


        private bool plural;

        public bool Plural
        {
            get { return plural; }
            set { plural = value; }
        }

        public override string ToString()
        {
            return root;
        }

    }
}
