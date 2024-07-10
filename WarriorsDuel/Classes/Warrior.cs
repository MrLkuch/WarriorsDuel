using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsDuel.Classes
{
    internal class Warrior
    {
        private String _name;
        private int _pv;
        private int _nbAttacks;

        public String Name { get => _name; set => _name = value; }
        public int Pv { get => _pv; set => _pv = value; }
        public int NbAttacks { get => _nbAttacks; set => _nbAttacks = value; }

        public Warrior(String name, int pv, int nbAttacks)
        {
            Name = name;
            Pv = pv;
            NbAttacks = nbAttacks;
        }
    }
}
