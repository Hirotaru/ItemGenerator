using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NameGenerator;
using System.IO;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace ItemGenerator
{
    public partial class Form1 : Form
    {
        public Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        Item lastItem;

        private void Button1_Click(object sender, EventArgs e)
        {
            Item item = new Item(WordChainBuilder.BuildPotion());

            lastItem = item;

            textBox1.Text = lastItem.Chain.GetName(checkBox1.Checked);

            //pictureBox1.BackColor = Color.Red;

            pictureBox1.Image = lastItem.Img;

            //label1.Text = "Урон: " + item.MinDmg + "—" + item.MaxDmg;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string name = lastItem?.Chain?.GetName(checkBox1.Checked);

            textBox1.Text = name;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WordChainBuilder.SetUpgradeChance(99);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
