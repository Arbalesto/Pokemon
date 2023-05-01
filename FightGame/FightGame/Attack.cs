using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FightGame
{
    internal class Attack
    {
        protected double calculateDmg(Character You, Character Enemy)
        {
            return You.baseDmg - Enemy.defense;
        }
        public void ChooseAtack(Character You, Character Enemy)
        {
            double damage = calculateDmg(You, Enemy);
            Console.WriteLine("Choose Atack!\n1-Punch\n2-Kick \n");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    damage = damage;
                    You.Stamina -= 10;
                    break;

                case 2:
                    You.Stamina -= 20;
                    damage += 5;
                    break;
            }

        }
        public void ChooseTarget(Character You, Character Enemy) {

            double damage = calculateDmg(You, Enemy);
            Console.WriteLine("Where do you want to hit \n 1-Head \n 2-Stomach \n 3-Legs");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You hit {0} in his Head", Enemy.name);
                    damage += 5;
                    You.Stamina -= 10;
                    Enemy.healthPoints -= damage;
                    break;

                case 2:
                    Console.WriteLine("You hit {0} in his Stomach", Enemy.name);
                    You.Stamina -= 20;
                    Enemy.healthPoints -= damage;
                    damage = damage;
                    break;
                case 3:
                    Console.WriteLine("You hit {0} in his Legs", Enemy.name);
                    damage -= 3;
                    Enemy.healthPoints -= damage;
                    break;

            }
        }
    }
}
