using System;
using GameOOP.Classes;

namespace GameOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior bob = new Warrior("Etho", 1000, 120, 40);

            Battle.StartFight(maximus, bob);
            //Console.WriteLine("Hello Warriors!");
            Console.ReadLine();
           
        }
    }
}
