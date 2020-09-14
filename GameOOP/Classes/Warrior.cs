using System;
namespace GameOOP.Classes
{
    public class Warrior
    {
        public Warrior()
        {
        }

        public string Name { get; set; } = "warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double AttackMin { get; set; } = 0;
        public double BlockMax{ get; set; } = 0;

        //Random number

        Random rnd = new Random();

        //constructor 
        public Warrior(string name = "warrior", double health = 0,
            double attack = 0, double block = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attack;
            BlockMax = block;  
        }

        //attack method
        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }
        //attack Block
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
       
    }
}
