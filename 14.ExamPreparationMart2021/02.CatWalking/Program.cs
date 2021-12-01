using System;

namespace _02.CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minWalk = int.Parse(Console.ReadLine());
            int countWalk = int.Parse(Console.ReadLine());
            int caloriesTaken = int.Parse(Console.ReadLine());
            int caloriesBurnet = minWalk * countWalk * 5;
            double fiftyPercentCalory = caloriesTaken / 2;
            if (caloriesBurnet >= fiftyPercentCalory)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurnet}.");
            }

            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurnet}.");
            }
        }
    }
}
