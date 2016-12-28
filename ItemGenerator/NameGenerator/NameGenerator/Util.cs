using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public enum PatternParts
    {
        Adjective,
        Object,
        Subject,
        Adverb,
        ItemAdjective,
        ObjAdjective,
        SubObject,
        LegendaryItemAdjective,
        LegendaryObjectAdjective,
    }

    public static class Util
    {
        private static Random rand = new Random(DateTime.Now.Millisecond);

        internal static List<string> ObjAdjectiveRoots = new List<string>()
        {
            "Сильн",
            "Огненн",
            "Темн",
            "Светл",
            "Кровав",
        };

        internal static List<string> LegendaryObjectAdjectiveRoots = new List<string>()
        {
            "Забыт",
            "Легендарн",
            "Непобедим",
            "Бессмертн",
            "Безумн",

        };

        internal static List<string> ItemAdjectiveRoots = new List<string>()
        {
            "Опасн",
            "Огненн",
            "Пламенн",
            "Яростн",
            "Темн",
            "Светл",
            "Проклят",
            "Кровав",
            "Ядовит",
            "Магическ",
        };


        internal static List<string> LegendaryItemAdjectiveRoots = new List<string>()
        {
            "Легендарн",
            "Убийственн",
            "Смертельно-Опасн",
            "Огненн",
            "Яростн",
            "Темн",
            "Светл",
            "Кровав",
            "Ядовит",
            "Эпическ",
            "Демоническ",
            "Забыт",
            "Древн",
        };

        internal static List<string> ExceptionalAdjectiveRoots = new List<string>()
        {
            "Эпическ",
        };

        internal static List<string> Adverbs = new List<string>()
        {
            "Логично",
            "Критично",
            "Опасно",
            "Необоснованно",
            "Крайне",
            "Чрезмерно",
            "Слегка",
            "Достаточно",
            "Отбито",
            "По-своему",
            "Недостаточно",
            "Сильно",
            "Очень",
        };

        public static Dictionary<string, string> SubjectsFoldres = new Dictionary<string, string>()
        {
            { "Лук", "Bow" },
            { "Щит", "Shield" },
            { "Меч", "Sword" },
            { "Топор", "Axe" },
            { "Парные Мечи", "Twin Blades" },
            { "Шлем", "Helmet" },
            { "Капюшон", "Hood" },
            { "Очки", "Glasses" },
            { "Кинжал", "Dagger" },
            { "Свиток", "Scroll" },
            { "Проклятье", "Curse" },
            { "Заклинание", "Magic Spell" },
            { "Арбалет", "Crossbow" },
            { "Маска", "Mask" },
            { "Посох", "Staff" },
            { "Рука", "Hand" },
            { "Самурайский Меч", "Katana" },
            { "Кольцо", "Ring" },
            { "Коса", "Scythe" },
        };



        internal static List<string> Subjects = new List<string>()
        {
            "ЛукМ1",
            "ЩитМ1",
            "МечМ1",
            "ТопорМ1",
            "Парные Мечи2",
            "ШлемМ1",
            "КапюшонМ1",
            "Очки2",
            "КинжалМ1",
            "СвитокМ1",
            "ПроклятьеС1",
            "ЗаклинаниеС1",
            "АрбалетМ1",
            "МаскаЖ1",
            "ПосохМ1",
            "РукаЖ1",
            "Самурайский МечМ1",
            "КольцоС1",
            "КосаЖ1",
        };

        public static List<string> Objects = new List<string>()
        {
            "КороляМ1",
            "ДраконаМ1",
            "БогаМ1",
            "ПовелителяМ1",
        };

        public static List<string> SubObjects = new List<string>()
        {
            "ЯростиЖ1",
            "ГневаМ1",
            "БолиЖ1",
            "СтрахаМ1",
            "ЖизниЖ1",
            "СмертиЖ1",
            "СозиданияС1",
            "РазрушенияС1",
            "КровиЖ1",
            "ХаосаМ1",
            "РаздораМ1",
        };

        private static Word ConvertStringsToSubj(string s)
        {
            Subject w = new Subject();

            switch (s[s.Length - 1])
            {
                case '1':
                    {
                        w.Plural = false;
                        break;
                    }
                default:
                    {
                        w.Plural = true;
                        s = s.Remove(s.Length - 1);
                        w.Root = s;
                        return w;
                    }
            }

            s = s.Remove(s.Length - 1);

            switch (s[s.Length - 1])
            {
                case 'М':
                    {
                        w.Kind = WordKind.M;
                        break;
                    }
                case 'Ж':
                    {
                        w.Kind = WordKind.F;
                        break;
                    }
                default:
                    {
                        w.Kind = WordKind.N;
                        break;
                    }
            }

            s = s.Remove(s.Length - 1);

            w.Root = s;

            return w;
        }

        private static Word ConvertStringsToObj(string s)
        {
            Object w = new Object();

            switch (s[s.Length - 1])
            {
                case '1':
                    {
                        w.Plural = false;
                        break;
                    }
                default:
                    {
                        w.Plural = true;
                        s = s.Remove(s.Length - 1);
                        w.Root = s;
                        return w;
                    }
            }

            s = s.Remove(s.Length - 1);

            switch (s[s.Length - 1])
            {
                case 'М':
                    {
                        w.Kind = WordKind.M;
                        break;
                    }
                case 'Ж':
                    {
                        w.Kind = WordKind.F;
                        break;
                    }
                default:
                    {
                        w.Kind = WordKind.N;
                        break;
                    }
            }

            s = s.Remove(s.Length - 1);

            w.Root = s;

            return w;
        }

        private static Word ConvertStringToAdj(string s)
        {
            Adjective adj = new Adjective()
            {
                Root = s
            };

            return adj;
        }

        private static Word ConvertStringToAdv(string s)
        {
            Adverb adj = new Adverb()
            {
                Root = s
            };

            return adj;
        }

        internal static Word GetRandomSubject()
        {
            return ConvertStringsToSubj(Subjects[rand.Next(0, Subjects.Count)]);
        }

        internal static Word GetRandomAdv()
        {
            return ConvertStringToAdv(Adverbs[rand.Next(0, Adverbs.Count)]);
        }

        internal static Word GetRandomObject()
        {
            return ConvertStringsToObj(Objects[rand.Next(0, Objects.Count)]);
        }

        internal static Word GetRandomSubObject()
        {
            return ConvertStringsToObj(SubObjects[rand.Next(0, SubObjects.Count)]);
        }

        internal static Word GetRandomObjAdj()
        {
            return ConvertStringToAdj(ObjAdjectiveRoots[rand.Next(0, ObjAdjectiveRoots.Count)]);
        }

        internal static Word GetRandomItemAdj()
        {
            return ConvertStringToAdj(ItemAdjectiveRoots[rand.Next(0, ItemAdjectiveRoots.Count)]);
        }

        internal static Word GetRandomLegendaryItemAdj()
        {
            return ConvertStringToAdj(LegendaryItemAdjectiveRoots[rand.Next(0, LegendaryItemAdjectiveRoots.Count)]);
        }

        internal static Word GetRandomLegendaryObjectAdj()
        {
            return ConvertStringToAdj(LegendaryObjectAdjectiveRoots[rand.Next(0, LegendaryObjectAdjectiveRoots.Count)]);
        }
    }
}
