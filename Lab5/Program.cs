using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
            string rollYN = Console.ReadLine().ToLower();

            Welcome(rollYN);

        }
        public static void Welcome(string rollYN)
        {



            if (rollYN == "n" || rollYN == "no")
            {
                Console.WriteLine("Goodbye");
                return;
            }
            else if (rollYN == "y" || rollYN == "yes")
            {
                string diceSides;
                int sides = 0;

                Random rollDice = new Random();
                Console.WriteLine("How many sides are on the dice?");
                diceSides = Console.ReadLine();
                try
                {
                    sides = int.Parse(diceSides);
                }
                catch (Exception e)
                {
                    Console.WriteLine("You messed up, Start Over!");
                    Console.WriteLine(e.StackTrace);
                    Welcome(rollYN);
                }
                RollTheDice(rollDice, sides);
                RollTheDice(rollDice, sides);
            }
            else
            {
                Console.WriteLine("I dont understand. Try again.");
                Welcome(rollYN);
            }
            Console.WriteLine("Roll again?");
            string reply = Console.ReadLine().ToLower();
            if (reply == "y" || reply == "yes")
            {
                Welcome(reply);
            }
            else
            {
                Console.WriteLine("Goodbye");
                return;
            }
            return;

        }


        public static void RollTheDice(Random rollDice, int diceSides)
        {

            int rolling = rollDice.Next(1, diceSides + 1);
            Console.WriteLine(rolling);

        }

    }
}
