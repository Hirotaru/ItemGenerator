using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class Visual
    {
        public static readonly List<Color> itemColors = new List<Color>()
        {
            Color.FromArgb(133, 133, 133),

            Color.FromArgb(222, 222, 222),

            Color.FromArgb(140, 255, 41),

            Color.FromArgb(41, 163, 255),

            Color.FromArgb(202, 41, 255),

            Color.FromArgb(248, 231, 28),

            Color.FromArgb(255, 155, 0),

            Color.FromArgb(255, 95, 41),
        };

        public static readonly List<Color> PotionColors = new List<Color>()
        {
            Color.FromArgb(140, 255, 41),

            Color.FromArgb(41, 163, 255),

            Color.FromArgb(202, 41, 255),

            Color.FromArgb(248, 231, 28),

            Color.FromArgb(255, 155, 0),

            Color.FromArgb(255, 95, 41),
        };
    }
}
