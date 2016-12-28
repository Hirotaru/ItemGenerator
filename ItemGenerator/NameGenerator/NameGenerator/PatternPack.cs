using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public static class PatternPack
    {
        public static readonly List<List<PatternParts>> Patterns = new List<List<PatternParts>>()
        {
            new List<PatternParts>()
            {
                PatternParts.Subject
            },

            new List<PatternParts>()
            {
                PatternParts.ItemAdjective,
                PatternParts.Subject

            },

            new List<PatternParts>()
            {
                PatternParts.Subject,
                PatternParts.SubObject
            },

            new List<PatternParts>()
            {
                PatternParts.Subject,
                PatternParts.ObjAdjective,
                PatternParts.SubObject

            },

            new List<PatternParts>()
            {
                PatternParts.ItemAdjective,
                PatternParts.Subject,
                PatternParts.SubObject

            },

            new List<PatternParts>()
            {
                PatternParts.ItemAdjective,
                PatternParts.Subject,
                PatternParts.ObjAdjective,
                PatternParts.SubObject

            },

            new List<PatternParts>()
            {
                PatternParts.LegendaryItemAdjective,
                PatternParts.Subject,
                PatternParts.ObjAdjective,
                PatternParts.Object,
                PatternParts.SubObject
            },

            new List<PatternParts>()
            {
                PatternParts.LegendaryItemAdjective,
                PatternParts.Subject,
                PatternParts.LegendaryObjectAdjective,
                PatternParts.Object,
                PatternParts.SubObject
            },

        };

        public static int Count
        {
            get { return Patterns.Count; }
        }
    }
}
