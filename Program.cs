using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            string rollYN;

            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
            rollYN = Console.ReadLine().ToLower();
            if (rollYN == "n" || rollYN == "no")
            {
                Console.WriteLine("Goodbye");

            }
            else if (rollYN == "y" || rollYN == "yes")
            {
                int diceSides;

                Random rollDice = new Random();
                Console.WriteLine("How many sides are on the dice?");
                diceSides = int.Parse(Console.ReadLine());
                RollTheDice(rollDice, diceSides);
                RollTheDice(rollDice, diceSides);
            }
            else
            {
                Console.WriteLine("I dont understand. Goodbye.");
            }


        }
        public static void RollTheDice(Random rollDice, int diceSides)
        {

            int rolling = rollDice.Next(1, diceSides + 1);
            Console.WriteLine(rolling);

        }

    }
}
