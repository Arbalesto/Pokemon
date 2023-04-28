using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        public string name;
        public double healthPoints;
        public double attack;
        public double defense;
        public double speed;
        public double damage;
        Type type;
        

        public Pokemon(string name, double hp, double attack, double defense, double speed)
        {
            this.name = name;
            this.healthPoints = hp;
            this.attack = attack;
            this.defense = defense;
            this.speed = speed;

        }        
        
        public void showInfo()
        {
            Console.WriteLine("--- Information ---");
            Console.WriteLine("Name - {0}", name);
            Console.WriteLine("Hp - {0}", healthPoints);
            Console.WriteLine("Attack - {0}", attack);
            Console.WriteLine("Defense - {0}", defense);
            Console.WriteLine("Speed - {0}", speed + "\n");

        }
        
        public static double Dmg(Pokemon You, Pokemon Enemy)
        {
            return (((((2 * 100 * 1) / 5 + 2) * 100 * You.attack / Enemy.defense) / 50));
        }
        public static void TEST()
        {
            this.Move.jaja();
        }
        
    }
    enum Type
    {
        Fire,
        Water,
        Grass,
    }
}
