using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figtin
{
    internal class BOT : HERO
    {
        private Random rand = new();
        private int[] weapon = { 20, 30, 40, 5, 2, 9, 10 };
        public BOT(string name)
        {
            this.HP = 100 * (rand.Next(10, 100) / 10);
            this.Lvl = this.HP / 10;
            this.Name = name;
            this.Dmg = 10 + weapon[rand.Next(0, 6)];
        }
    }
}
