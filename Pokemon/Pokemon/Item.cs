using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Item
    {
        public virtual void Leczenie(Pokemon pokemon)
        {
            
        }
    }
    public class HealingItem : Item
    {
        public string name = "Apteczka";

        public override void Leczenie(Pokemon pokemon)
        {
            pokemon.healthPoints += 11;
            Console.WriteLine("{0} Użył Apteczki, Hp {1} wynosi - {2}", pokemon.name, pokemon.name, pokemon.healthPoints);
        }
    }
    public class BuffingItem: Item
    {
        public void Buff(Pokemon Me)
        {
            Me.attack += 5;
            Me.specialAtak += 5;
            Me.damage += 5;
            Me.speed += 5;
            Me.defense += 5;
        }
    }
}
