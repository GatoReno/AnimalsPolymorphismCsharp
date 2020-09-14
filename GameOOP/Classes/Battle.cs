using System;
namespace GameOOP.Classes
{
    public class Battle
    {
        public Battle()
        {
           
        }


        public static void StartFight(Warrior w1, Warrior w2)
        {
            while (true)
            {
                if (GetAttackResult(w1,w2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    Console.ReadLine();
                    break;
                }
                if (GetAttackResult(w2, w1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    Console.ReadLine();
                    break;
                }

                
            }
        }

        private static string GetAttackResult(Warrior w1, Warrior w2)
        {
            double w1AttAmount = w1.Attack();
            double w2Bloamount = w2.Block();

            double dmgWar2 = w1AttAmount - w2Bloamount;

            if (dmgWar2 > 0)
            {
                w2.Health = w2.Health - dmgWar2;
            }
            else
            {
                dmgWar2 = 0;
            }
            Console.WriteLine("{0} attacks {1} and deals {2} damage",
                w1.Name, w2.Name, dmgWar2);

            if (w2.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is Victorius \n",
                    w2.Name,w1.Name);
                return "Game Over";
            }
            return "fighting";
        }
    }
}
