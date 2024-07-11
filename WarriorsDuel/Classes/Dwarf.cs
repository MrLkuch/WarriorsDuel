using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WarriorsDuel.Classes
{
    internal class Dwarf : Warrior
    {

        public Dwarf(String name, int hp, int nbAttacks, int armor = 0) : base (name, hp, nbAttacks, armor)
        {
            
        }
    }
}
