﻿using System;
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
            Pokemon Pikachu = new Pokemon("Pikachu", 100, 20, 50, 100);
            Pikachu.showInfo();

            Pokemon Charizard = new Pokemon("Charizard", 100, 20, 70, 50);
            Charizard.showInfo();

            Pokemon.Test(Pikachu,Charizard);
            Pikachu.showInfo();
            Console.ReadKey();
        }
    }
}
