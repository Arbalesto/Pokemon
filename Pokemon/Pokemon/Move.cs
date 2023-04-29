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
        public override void execute(Pokemon source, Pokemon target)
        {
            Console.WriteLine("\n" + "{0} Hits {1} with base atack" +"\n", source.name, target.name);
            double dmg = this.calculateDmg(source, target);
            target.healthPoints -= dmg;

        }

    }
    public class SpecialAttackMove : Move
    {
        public override void execute(Pokemon source, Pokemon target)
        {
            throw new NotImplementedException();
        }

        protected double SpecialcalculateDmg(Pokemon You, Pokemon Enemy)
        {
            return (((((2 * 100 * 1) / 5 + 2) * 100 * You.attack / Enemy.defense) / 50) + You.specialAtak / 5);
        }


        public void Specialexecute(Pokemon source, Pokemon target)
        {
            Console.Write("Choose your Special Atack! \n 1 - {0} \n 2 - {1} \n 3 - {2}: ", source.Atak1, source.Atak2, source.Atak3);
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Console.WriteLine("\n" + "{0} uses {1}" +"\n", source.name, source.Atak1);
                    break;
                case 2:
                    Console.WriteLine("\n" + "{0} uses {1}" + "\n", source.name, source.Atak2);
                    break;
                case 3:
                    Console.WriteLine("\n" + "{0} uses {1}" + "\n", source.name, source.Atak3);
                    break;
            }
            double dmg = this.SpecialcalculateDmg(source, target);
            target.healthPoints -= dmg;
        }


        public void SpecialexecuteFORENEMY(Pokemon source, Pokemon target)
        { 
            Random random = new Random();
            int wybor = random.Next(1, 4);
            switch (wybor)
            {
                case 1:
                    Console.WriteLine("\n" + "{0} uses {1}" + "\n", source.name, source.Atak1);
                    break;
                case 2:
                    Console.WriteLine("\n" + "{0} uses {1}" + "\n", source.name, source.Atak2);
                    break;
                case 3:
                    Console.WriteLine("\n" + "{0} uses {1}" + "\n", source.name, source.Atak3);
                    break;
            }
            double dmg = this.SpecialcalculateDmg(source, target);
            target.healthPoints -= dmg;
        }


    }
}

