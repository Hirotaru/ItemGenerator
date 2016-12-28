using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameGenerator;
using System.Drawing;
using System.IO;

namespace ItemGenerator
{
    public enum ItemType
    {
        Weapon,
        Spell,
        Potion,
        Equipment,
    }

    public class Item
    {
        private static Random rand = new Random();

        private static List<Color> itemColors = new List<Color>()
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


        public int Rank
        {
            get { return chain.Rank; }
        }

        private WordChain chain;

        public WordChain Chain
        {
            get { return chain; }
            private set { chain = value; }
        }

        private Image img;

        public Image Img
        {
            get { return img; }
            private set { img = value; }
        }

        public Item(WordChain chain)
        {
            this.chain = chain;
            LoadImage();
        }

        private void LoadImage()
        {
            string path = @"..\..\Images\" + Util.SubjectsFoldres[chain.Subj];

            int filesCount = Directory.EnumerateFiles(path).ToList().Count;

            Bitmap b = (Bitmap)Bitmap.FromFile(path + @"\" + rand.Next(0, filesCount) + ".png");

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {

                    if (b.GetPixel(x, y).A == 0)
                    {
                        b.SetPixel(x, y, Item.itemColors[Rank]);
                    }
                }
            }

            img = b;
        }




    }
}
