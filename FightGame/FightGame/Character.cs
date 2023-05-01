using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightGame
{
    internal class Character
    {
        public string name;
        public double baseDmg;
        public double defense;
        public double healthPoints;
        public int Stamina = 100;

        public Character (string name, double baseDmg, double defense, double healthPoints)
        {
            this.name = name;
            this.baseDmg = baseDmg;
            this.defense = defense;
            this.healthPoints = healthPoints;
        }
        public void showInfo()
        {
            Console.WriteLine("---INFORMATION---");
            Console.WriteLine("NAME - {0}",name);
            Console.WriteLine("DAMAGE - {0}",baseDmg);
            Console.WriteLine("DEFENSE - {0}",defense);
            Console.WriteLine("HP - {0}",healthPoints);
            Console.WriteLine("Stamina - {0}", Stamina);
        }
    }
   


}
