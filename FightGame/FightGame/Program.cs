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
            Character Jasiu = new Character("Jasiu", 50, 50, 100);
            Jasiu.showInfo();
            Console.ReadKey();
            
        }
    }
}
