﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

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
        
        public string Atak1 {get;set;}
        public string Atak2 { get;set;}
        public string Atak3 { get;set;}

        public Move move;
        public Item item;
        public SpecialAttackMove specialmove;
        public BuffingItem buff;




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

        public Pokemon(string name, double hp, double attack, double defense, double speed,
            Move move, Item item, double specialatak_, SpecialAttackMove specialmove, BuffingItem buff, string atak1, string atak2, string atak3)
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
            this.buff = buff;
            this.Atak1 = atak1;
            this.Atak2 = atak2;
            this.Atak3 = atak3;

        }


        public void showInfo()
        {
            Console.WriteLine("--- Information ---");
            Console.WriteLine("Name - {0}", name);
            Console.WriteLine("Hp - {0}", healthPoints);
            Console.WriteLine("Attack - {0}", attack);
            Console.WriteLine("Defense - {0}", defense);
            Console.WriteLine("Speed - {0}", speed + "\n");
            Console.WriteLine("--------------------------"+"\n");
        }

        public void makeSpecialMoveforBot(Pokemon target)
        {

            specialmove.SpecialexecuteFORENEMY(this, target);
            target.showInfo();
        }
        public void makeMove(Pokemon target)
        {
            move.execute(this, target);
            target.showInfo();
        }

        public void Leczenie(Pokemon pokemon)
        {
            item.Leczenie(pokemon);
            pokemon.showInfo();
        }
        public void makeSpecialMove(Pokemon target)
        {
            specialmove.Specialexecute(this, target);
            target.showInfo();

        }
        public void buffingMove(Pokemon target)
        {
            buff.Buff(target);
            Console.WriteLine("{0} Uses buff item! Current Stats: "+"\n", target.name );
            target.showInfo();
        }
        public bool isTurn(Pokemon A, Pokemon B)
        {
            if (A.speed > B.speed) return true;
            else return false;
        }
        public void YourAction(Pokemon A, Pokemon B)
            
        {
            Console.Write("Choose your action \n 1-Attack \n 2-Special Atack \n 3-Heal \n 4-Buff: ");
            int choice = int.Parse(Console.ReadLine());

            
            switch (choice)
            {
                case 1:
                    A.makeMove(B);
                    break;
                case 2:
                    A.makeSpecialMove(B);
                    break;
                case 3:
                    A.Leczenie(A);
                    break;
                case 4:
                    A.buffingMove(A);
                    break;        
                default:
                    Console.WriteLine("Invalid choice ");
                    break;
            }
        }
        public void EnemyAction(Pokemon B, Pokemon A)
        {
            Random random = new Random();
            int enemychoice = random.Next(1, 5);
            if (B.healthPoints > 0){
                switch (enemychoice)
                {
                    case 1:
                        B.makeMove(A);
                        break;
                    case 2:
                        B.makeSpecialMoveforBot(A);
                        break;
                    case 3:
                        B.Leczenie(B);
                        break;
                    case 4:
                        B.buffingMove(B);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid choice ");
                        break;
                }
            }
        }
        public bool isRunning(Pokemon A, Pokemon B)
        {

            if (A.healthPoints > 0 && B.healthPoints > 0)
            {
                return true;
            }
            else return false;
        }
       
    }
}

