using ConsoleApp2.Data.Model;
using ConsoleApp2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp2
{
    delegate bool IsUsable(Creature creature);

    class Program
    {
        static void Main(string[] args)
        {
            
            //Create Object
            Vampire vampire = new Vampire();
            vampire.HitPoint = 15;
            Human human = new Human();
            human.HitPoint = 60;
            Undead undead = new Undead();
            undead.HitPoint = 80;
            
            //create list 
            List<Creature> creatures = new List<Creature>();
            //add object into list
            creatures.Add(vampire);
            creatures.Add(human);
            creatures.Add(undead);

            
            //if hitpoint less then or equal to 15, able to used special ability
            UseSpecialAbilities(creatures, item => item.HitPoint <= 15);

            Console.ReadKey();
        }


        //GET: list object, delegate object
        public static void UseSpecialAbilities(List<Creature> creatures,IsUsable isUsable)
        {
            //loop every creature 
            foreach(var creature in creatures)
            {
                
                if (isUsable(creature))
                {
                    creature.GetSpecialAbility();
                }
                else
                {
                    Console.WriteLine("Cannot used that skill!");
                }
            }

        }


        



        






        
    }


}
