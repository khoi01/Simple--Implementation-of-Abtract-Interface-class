using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Model.Abstract
{
   
    public abstract class Creature
    {
        public string Name { get; set; }
        public int HitPoint { get; set; }
        public int Attack { get; set; }


        public abstract void GetSpecialAbility();


       

    }
}
