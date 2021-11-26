using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double target = double.Parse(Console.ReadLine());
            string cocktail = Console.ReadLine();
            double costTotalCocktail = 0;
            double income = 0;
            while (cocktail != "Party!")
            {
                int numbercocktail = int.Parse(Console.ReadLine());
                int costForOneCocktail = cocktail.Length;
                costTotalCocktail = numbercocktail * costForOneCocktail;
                if (costTotalCocktail % 2 == 1)
                {
                    costTotalCocktail = costTotalCocktail * 0.75;
                }
                income += costTotalCocktail;
                if (income >= target)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {income:f2} leva.");
                    break;
                }

                cocktail = Console.ReadLine();
            }

            if (cocktail == "Party!")
            {
                Console.WriteLine($"We need {target - income:f2} leva more.");
                Console.WriteLine($"Club income - {income:f2} leva.");
            }
        }
    }
}

