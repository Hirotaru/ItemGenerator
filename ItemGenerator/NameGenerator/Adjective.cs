using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public class Adjective : Word
    {
        private Noun wordAfter;

        public Noun WordAfter
        {
            get { return wordAfter; }
            set { wordAfter = value; }
        }       


        public override string ToString()
        {
            if (Util.ExceptionalAdjectiveRoots.Contains(Root))
            {
                switch (Root)
                {

                    case "Демоническ":
                    case "Эпическ":
                    case "Магическ":
                        {
                            if (wordAfter is Subject)
                            {
                                if (wordAfter.Plural)
                                {
                                    return base.ToString() + "ие";
                                }

                                switch (wordAfter.Kind)
                                {
                                    case WordKind.F:
                                        {
                                            return base.ToString() + "ая";
                                        }
                                    case WordKind.M:
                                        {
                                            return base.ToString() + "ий";
                                        }
                                    default:
                                        {
                                            return base.ToString() + "ое";
                                        }
                                }
                            }
                            else
                            {
                                if (wordAfter.Plural)
                                {
                                    return base.ToString() + "их";
                                }

                                switch (wordAfter.Kind)
                                {
                                    case WordKind.F:
                                        {
                                            return base.ToString() + "ой";
                                        }
                                    default:
                                        {
                                            return base.ToString() + "ого";
                                        }
                                }
                            }
                        }
                    case "Древн":
                        {
                            if (wordAfter is Subject)
                            {
                                if (wordAfter.Plural)
                                {
                                    return base.ToString() + "ие";
                                }

                                switch (wordAfter.Kind)
                                {
                                    case WordKind.F:
                                        {
                                            return base.ToString() + "яя";
                                        }
                                    case WordKind.M:
                                        {
                                            return base.ToString() + "ий";
                                        }
                                    default:
                                        {
                                            return base.ToString() + "ее";
                                        }
                                }
                            }
                            else
                            {
                                if (wordAfter.Plural)
                                {
                                    return base.ToString() + "их";
                                }

                                switch (wordAfter.Kind)
                                {
                                    case WordKind.F:
                                        {
                                            return base.ToString() + "ей";
                                        }
                                    default:
                                        {
                                            return base.ToString() + "его";
                                        }
                                }
                            }
                        }

                    
                }
            }

            if (wordAfter is Subject)
            {
                if (wordAfter.Plural)
                {
                    return base.ToString() + "ые";
                }

                switch (wordAfter.Kind)
                {
                    case WordKind.F:
                        {
                            return base.ToString() + "ая";
                        }
                    case WordKind.M:
                        {
                            return base.ToString() + "ый";
                        }
                    default:
                        {
                            return base.ToString() + "ое";
                        }
                }
            }
            else
            {
                if (wordAfter.Plural)
                {
                    return base.ToString() + "ых";
                }

                switch (wordAfter.Kind)
                {
                    case WordKind.F:
                        {
                            return base.ToString() + "ой";
                        }
                    default:
                        {
                            return base.ToString() + "ого";
                        }
                }
            }
        }
    }
}
