using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public static class PatternPack
    {
        public static readonly List<List<PatternParts>> ItemPatterns = new List<List<PatternParts>>()
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

        public static readonly List<List<PatternParts>> PotionPatterns = new List<List<PatternParts>>()
        {
            new List<PatternParts>()
            {
                PatternParts.SmallPotionAdjective,
                PatternParts.Potion,
                PatternParts.PotionObject,
            },

            new List<PatternParts>()
            {
                PatternParts.MediumPotionAdjective,
                PatternParts.Potion,
                PatternParts.PotionObject,
            },

            new List<PatternParts>()
            {
                PatternParts.HugePotionAdjective,
                PatternParts.Potion,
                PatternParts.PotionObject,
            },
        };

        public static int ItemCount
        {
            get { return ItemPatterns.Count; }
        }

        public static int PotionCount
        {
            get { return PotionPatterns.Count; }
        }
    }
}
