using System;
namespace Polymorphism.Classes
{
    class Dog : Animal
    {
        public Dog()
        {
        }

        public string Sound2 { get; set; } = "Grrr";
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Name", string sound = "No sound", string sound2 = "No sound")
        : base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}
