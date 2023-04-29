using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public double specialAtak;

        public Move move;
        public Item item;
        public SpecialAttackMove specialmove;
        
       
        

        Type type;
        public double specialatak_
        {
            set
            {
                if (value > 30 || value < 0)
                {
                    throw new Exception("Value is either too low or too high!");
                }
                this.specialAtak = value;
            }
            get
            {
                return this.specialAtak;
            }
        }

        public Pokemon(string name, double hp, double attack, double defense, double speed, Move move, Item item,double specialatak_, SpecialAttackMove specialmove)
        {
            this.name = name;
            this.healthPoints = hp;
            this.attack = attack;
            this.defense = defense;
            this.speed = speed;
            this.move = move;
            this.item = item;
            this.specialatak_ = specialatak_;
            this.specialmove = specialmove;
            
            
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


        public void makeMove(Pokemon target)
        {
            if (target == null) return;
            this.move.execute(this, target);
            Console.WriteLine("ATAK" + "\n");
        }

        public void Leczenie(Pokemon pokemon)
        {
            this.item.Leczenie(pokemon);
        }
        public void makeSpecialMove(Pokemon target)
        {
            if (target == null) return;
            this.specialmove.Specialexecute(this, target);

        }
    }
}
