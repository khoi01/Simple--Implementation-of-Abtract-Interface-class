using ConsoleApp2.Model.Abstract;
using ConsoleApp2.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Data.Model
{
    class Vampire : Creature, IVampire
    {
       
       
        public void Bite()
        {
            Console.Write("used bite!");
        }

        public override void GetSpecialAbility()
        {
            Console.WriteLine("Invisible!");
        }
    }
}
