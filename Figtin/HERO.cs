using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figtin
{

    internal class HERO
    {
        public int HP;
        public int Dmg;
        public int Lvl = 1;
        public string Name;

        public void Attack(HERO enemy)
        {
            if (HP > 0)
            {
                if (enemy.HP > 0)
                {
                    enemy.HP -= Dmg;
                }

                else
                {
                    enemy.HP = 0;
                }
            }
        }
    }
}
