using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsDuel.Classes
{
    internal class Elf : Warrior
    {
        public Elf(String name, int hp, int nbAttacks, int armor = 0) : base (name, hp, nbAttacks, armor)
        {

        }

        public override int Attack()
        {
            int dmg;
            do
            {
                dmg = new Random().Next(1, 7);

            } while (dmg == 1);

            return dmg;
        }
    }
}
