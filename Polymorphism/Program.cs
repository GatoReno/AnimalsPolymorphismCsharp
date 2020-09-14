using System;
using Polymorphism.Classes;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "whiskers", Sound = "miau"
            };
            whiskers.SetAnimalIDInfo(112121,"jhon doe");

            Dog grover = new Dog()
            { Name = "brok", Sound = "guau", Sound2="aaauuh" };



            whiskers.MakeSound();
            whiskers.GetAnimalInfo();
            grover.MakeSound();
            grover.GetAnimalInfo();

            Animal.AnimalHealth  health = new Animal.AnimalHealth();

            Console.WriteLine( "whiskers health : {0} ", health.HealthyWeight(11, 46) );

            //polymorph

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooff",
                Sound2 = "good day commander"
            };

            // The problem is that if you call a 
            // function in Animal it won't call
            // the overridden method in Dog unless
            // the method that might be overridden
            // is marked virtual
            spot.MakeSound();
            monkey.MakeSound();

            Console.WriteLine("Hello Polymorphism!");
            Console.ReadLine();


        }
    }
}
