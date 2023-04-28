using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public abstract class Move
    {
        public abstract void execute(Pokemon source, Pokemon target);

       

    }
    public class AttackMove : Move
    {
        protected double calculateDmg(Pokemon You, Pokemon Enemy)
        {
            return (((((2 * 100 * 1) / 5 + 2) * 100 * You.attack / Enemy.defense) / 50));
        }
        public  override void execute(Pokemon source, Pokemon target)
        {
            double dmg = this.calculateDmg(source, target);
            target.healthPoints -= dmg;
            
        }
        public void specjalnyAtak(Pokemon source, Pokemon target)
        {
            
        }
    }

}

