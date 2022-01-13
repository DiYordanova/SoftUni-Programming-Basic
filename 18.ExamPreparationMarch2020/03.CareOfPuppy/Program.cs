using System;

namespace _05.CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int foodInGram = food * 1000;
            string input = Console.ReadLine();
            double totalFood = 0;
            while (input != "Adopted")
            {
                int currentFood = int.Parse(input);
                totalFood += currentFood;
                input = Console.ReadLine();
            }

            if (foodInGram >= totalFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGram - totalFood} grams.");
            }

            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFood - foodInGram} grams more.");
            }
        }
    }
}

