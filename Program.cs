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

            Vampire vampire = new Vampire();
            vampire.HitPoint = 15;
            Human human = new Human();
            human.HitPoint = 60;
            Undead undead = new Undead();
            undead.HitPoint = 80;

            List<Creature> creatures = new List<Creature>();
            creatures.Add(vampire);
            creatures.Add(human);
            creatures.Add(undead);


            UseSpecialAbilities(creatures, item => item.HitPoint <= 15);

            Console.ReadKey();
        }



        public static void UseSpecialAbilities(List<Creature> creatures,IsUsable isUsable)
        {

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
