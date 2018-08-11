using ConsoleApp2.Model.Abstract;
using ConsoleApp2.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Data.Model
{
    class Undead : Creature, IUndead
    {
        public void Eat()
        {
            Console.WriteLine("Eat all creature!!");
        }

        public override void GetSpecialAbility()
        {
            Console.WriteLine("Cannot Die!");
        }
    }
}
