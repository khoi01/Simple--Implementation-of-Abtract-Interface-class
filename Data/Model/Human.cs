using ConsoleApp2.Model.Abstract;
using ConsoleApp2.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Data.Model
{
    class Human : Creature, IHuman
    {
        public override void GetSpecialAbility()
        {
            Console.WriteLine("Attack with a sword!");
        }

        public void ThrowRock()
        {
            Console.WriteLine("Throw a rock!");
        }
    }
}
