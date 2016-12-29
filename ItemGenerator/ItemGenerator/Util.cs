using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public enum ItemType
    {
        Weapon,
        Spell,
        Potion,
        Equipment,
    }
    public static class Util
    {
        private static Random rand = new Random();
    }
}
