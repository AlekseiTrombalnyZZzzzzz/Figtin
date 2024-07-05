using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figtin
{
    internal class PLAYER : HERO
    {
        int Max_HP = 100;
        public PLAYER(int HP, string name, int Weapon)
        {
            this.HP = HP;
            this.Name = name;
            this.Dmg = 10 + Weapon;
        }

        private void Attack(HERO enemy)
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
                    Max_HP = Lvl + enemy.Lvl % enemy.Dmg;
                }
            }
        }
        public void Heal(int amount)
        {
            if (HP > 0 && HP < Max_HP)
                HP += amount;
        }
    }
}
