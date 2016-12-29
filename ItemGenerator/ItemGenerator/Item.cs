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
    public class Item
    {
        private static Random rand = new Random();

        private ItemType type;

        public ItemType Type
        {
            get { return type; }
            private set { type = value; }
        }



        private Damage dmg;

        public Damage Dmg
        {
            get { return dmg; }
            private set { dmg = value; }
        }

        public double MinDmg
        {
            get { return dmg.MinDamage; }
        }

        public double MaxDmg
        {
            get { return dmg.MaxDamage; }
        }

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
            dmg = new Damage(Rank);
        }

        private void LoadImage()
        {
            string path = @"..\..\Images\" + WordManager.SubjectsFoldres[chain.Subj];

            int filesCount = Directory.EnumerateFiles(path).ToList().Count;

            Bitmap b = (Bitmap)Image.FromFile(path + @"\" + rand.Next(0, filesCount) + ".png");

            FixImage(b);

            img = b;
        }

        private void FixImage(Bitmap b)
        {
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {

                    if (b.GetPixel(x, y).A == 0 || b.GetPixel(x, y).B > 91)
                    {
                        switch (type)
                        {
                            case ItemType.Potion:
                                {
                                    b.SetPixel(x, y, Visual.PotionColors[Rank]);
                                    break;
                                }

                            case ItemType.Equipment:
                            case ItemType.Spell:
                            case ItemType.Weapon:
                                {
                                    b.SetPixel(x, y, Visual.itemColors[Rank]);
                                    break;
                                }
                        }
                    }
                }
            }
        }

        ~Item()
        {
            img.Dispose();
        }


    }
}
