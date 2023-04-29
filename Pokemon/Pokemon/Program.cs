using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
            BuffingItem buffingItem = new BuffingItem();

            Pokemon Pikachu = new Pokemon("Pikachu", 100, 20, 50, 2, move,Healingitem, 25, specialmove, buffingItem);
        
            Pokemon Charizard = new Pokemon("Charizard", 100, 20, 70, 1, move, Healingitem, 25, specialmove, buffingItem);



            while (Pikachu.isRunning(Pikachu, Charizard))
            {
                if (Pikachu.isTurn(Pikachu, Charizard))
                {
                    Pikachu.YourAction(Pikachu, Charizard);
                    Charizard.EnemyAction(Charizard, Pikachu);
                }
                else
                {
                    Charizard.EnemyAction(Charizard,Pikachu);
                    Pikachu.YourAction(Pikachu, Charizard);
                }
                
            }
            Console.ReadKey();
        }
    }

}
