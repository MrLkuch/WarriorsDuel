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
        private int _hp;
        private int _nbAttacks;
        private int _armor;

        public String Name { get => _name; set => _name = value; }
        public int Hp { get => _hp; set => _hp = value; }
        public int NbAttacks { get => _nbAttacks; set => _nbAttacks = value; }
        public int Armor { get => _armor; set => _armor = value; }

        public Warrior(String name, int hp, int nbAttacks, int armor = 0)
        {
            Name = name;
            Hp = hp;
            NbAttacks = nbAttacks;
            Armor = armor;
        }

        public virtual int Attack()
        {
            int dmg = new Random().Next(1, 7); ;
            return dmg;
        }

        public int ReceiveDmg(int dmg)
        {
            int receivedDmg = 0;
            if (dmg >= Armor)
            {
                receivedDmg += dmg - Armor;
            }
            return receivedDmg;
        }
    }
}
