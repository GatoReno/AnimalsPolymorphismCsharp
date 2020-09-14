using System;
using System.Linq;

namespace Polymorphism.Classes
{
    //sealed disable the Inheritance of a class
    class Animal
    {
        private string name;
        protected string sound;
        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void GetAnimalInfo()
        {
            Console.WriteLine($"{Name} had the id of {animalIDInfo.IDNum} and owned by {animalIDInfo.Owner}");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} , says {sound}");
        }

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner;
        }

        public string Name
        {

            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No sound";
                }
                sound = value;

            }
        }


        public Animal() :this("No Name", "No Sound")
        { }

        public Animal(string name) : this(name, "No Sound")
        { }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }



        public class AnimalHealth
        {
            public bool HealthyWeight(double height,
                double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }

        }
    }
}
