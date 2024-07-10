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
        private int _armor;

        public int Armor { get => _armor; set => _armor = value; }
        public Dwarf(String name, int pv, int nbAttacks, int armor) : base (name, pv, nbAttacks)
        {
            Armor = armor;
        }
    }
}
