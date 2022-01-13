using System;

namespace _04.FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double totalFood = 0;
            double totalFoodDog = 0;
            double totalFoodCat = 0;
            double biscuit = 0;
            double totalBiscuit = 0;
            for (int i = 1; i <= day; i++)
            {
                int currentFoofDog = int.Parse(Console.ReadLine());
                int currentFoofCat = int.Parse(Console.ReadLine());
                totalFood += currentFoofDog;
                totalFood += currentFoofCat;
                totalFoodDog += currentFoofDog;
                totalFoodCat += currentFoofCat;
                if (i % 3 == 0)
                {
                    biscuit = (currentFoofDog + currentFoofCat) * 0.10;
                    totalBiscuit += biscuit;
                }
            }
            double eatFood = totalFood / food * 100;
            double eatFoodDog = totalFoodDog / totalFood * 100;
            double eatFoodCat = totalFoodCat / totalFood * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuit)}gr.");
            Console.WriteLine($"{eatFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatFoodDog:f2}% eaten from the dog.");
            Console.WriteLine($"{eatFoodCat:f2}% eaten from the cat.");
        }
    }
}

