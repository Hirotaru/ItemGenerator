using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    
    public class Adjective : Word
    {
        #region StringArgument
        struct StringArgument
        {
            public readonly string subjMsingle;
            public readonly string subjFsingle;
            public readonly string subjNsingle;
            public readonly string subjPlural;
            public readonly string objMsingle;
            public readonly string objFsingle;
            public readonly string objNsingle;
            public readonly string objPlural;

            public StringArgument(string subjMsingle, string subjFsingle, string subjNsingle, string subjPlural,
                                           string objMsingle, string objFsingle, string objNsingle, string objPlural)
            {
                this.subjMsingle = subjMsingle;
                this.subjFsingle = subjFsingle;
                this.subjNsingle = subjNsingle;
                this.subjPlural = subjPlural;
                this.objMsingle = objMsingle;
                this.objFsingle = objFsingle;
                this.objNsingle = objNsingle;
                this.objPlural = objPlural;
            }
        }

        private StringArgument exception1 = new StringArgument("ий", "ая", "ое", "ие", "ого", "ой", "ого", "их");
        private StringArgument exception2 = new StringArgument("ий", "яя", "ее", "ие", "его", "ей", "его", "их");
        private StringArgument exception3 = new StringArgument("ой", "ая", "ое", "ие", "ого", "ой", "ого", "их");
        private StringArgument regular = new StringArgument("ый", "ая", "ое", "ые", "ого", "ой", "ого", "ых");

        #endregion

        private Noun wordAfter;

        public Noun WordAfter
        {
            get { return wordAfter; }
            set { wordAfter = value; }
        }       

        private string SetAdjectiveEndings(StringArgument arg)
        {
            return SetAdjectiveEndings(arg.subjMsingle, arg.subjFsingle, arg.subjNsingle, arg.subjPlural, arg.objMsingle, arg.objFsingle, arg.objNsingle, arg.objPlural);
        }

        private string SetAdjectiveEndings(string subjMsingle, string subjFsingle, string subjNsingle, string subjPlural, 
                                           string objMsingle, string objFsingle, string objNsingle, string objPlural)
        {
            if (wordAfter is Subject)
            {
                if (wordAfter.Plural)
                {
                    return base.ToString() + subjPlural;
                }

                switch (wordAfter.Kind)
                {
                    case WordKind.F:
                        {
                            return base.ToString() + subjFsingle;
                        }
                    case WordKind.M:
                        {
                            return base.ToString() + subjMsingle;
                        }
                    default:
                        {
                            return base.ToString() + subjNsingle;
                        }
                }
            }
            else
            {
                if (wordAfter.Plural)
                {
                    return base.ToString() + objPlural;
                }

                switch (wordAfter.Kind)
                {
                    case WordKind.F:
                        {
                            return base.ToString() + objFsingle;
                        }
                    case WordKind.M:
                        {
                            return base.ToString() + objMsingle;
                        }
                    default:
                        {
                            return base.ToString() + objNsingle;
                        }
                }
            }
        }

        public override string ToString()
        {
            if (WordManager.ExceptionalAdjectiveRoots.Contains(Root))
            {
                switch (Root)
                {

                    case "Демоническ":
                    case "Эпическ":
                    case "Магическ":
                        {
                            return SetAdjectiveEndings(exception1);
                        }

                    case "Древн":
                    case "Средн":
                        {
                            return SetAdjectiveEndings(exception2);
                        }

                    case "Больш":
                        {
                            return SetAdjectiveEndings(exception3);
                        }
                    }
            }

            return SetAdjectiveEndings(regular);
        }
    }
}
