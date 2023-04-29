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
       

        public override void Leczenie(Pokemon pokemon)
        {
            pokemon.healthPoints += 30;
            Console.WriteLine("\n" + "{0} Used Healing" + "\n", pokemon.name);
        }
    }
    public class BuffingItem: Item
    {
        public void Buff(Pokemon Me)
        {

            Me.attack += 50;
            Me.specialAtak += 5;
            Me.damage += 5;
            Me.defense += 5;
        }
    }
}
