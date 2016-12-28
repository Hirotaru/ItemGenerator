using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    
    public class Noun : Word
    {
        private WordKind kind;

        public WordKind Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
