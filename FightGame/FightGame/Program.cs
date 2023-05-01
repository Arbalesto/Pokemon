using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightGame
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Attack atak = new Attack();
            Character Jasiu = new Character("Jasiu", 50, 50, 100, atak);
            Character BOMBA = new Character("BOMBA", 50, 1, 100, atak);
            Jasiu.showInfo();
            Jasiu.setAttack(Jasiu,BOMBA);
            BOMBA.showInfo();
            Jasiu.showInfo();
            Console.ReadKey();

            
        }
    }
}
