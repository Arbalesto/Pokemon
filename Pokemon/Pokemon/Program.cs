using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<Type, (List<Type>, List<Type>)> typesMap = new Dictionary<Type, (List<Type>, List<Type>)>();
            //typesMap.Add(Type.Fire);
            Move move = new AttackMove();
            Item Healingitem = new HealingItem();
            SpecialAttackMove specialmove = new SpecialAttackMove();


            Pokemon Pikachu = new Pokemon("Pikachu", 100, 20, 50, 100, move,Healingitem, 29, specialmove);
        
            Pokemon Charizard = new Pokemon("Charizard", 100, 20, 70, 50, move, Healingitem, 28, specialmove);

            Charizard.makeSpecialMove(Pikachu);
            Pikachu.showInfo();
           
           

            Console.ReadKey();

        }
    }
}
