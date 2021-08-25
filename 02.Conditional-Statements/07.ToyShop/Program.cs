using System;

namespace _7ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfExcursion = double.Parse(Console.ReadLine());
            int countPuzzles = int.Parse(Console.ReadLine());
            int countDolls = int.Parse(Console.ReadLine());
            int countBears = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            double totalPricePuzzles = countPuzzles * 2.60;
            double totalPricePDolls = countDolls * 3;
            double totalPriceBear = countBears * 4.10;
            double totalPriceMinions = countMinions * 8.20;
            double totalPriceTrucks = countTrucks * 2;

            double income = totalPricePuzzles + totalPricePDolls + totalPriceBear + totalPriceMinions + totalPriceTrucks;
            int countToys = countPuzzles + countDolls + countBears + countMinions + countTrucks;
            double discount = income * 0.25;

            if (countToys >= 50)

                income -= discount;

            else
                discount = 0;

            double rent = income * 0.10;
            double result = income - rent;

            if (result >= priceOfExcursion)

                Console.WriteLine($"Yes! {(result - priceOfExcursion):f2} lv left.");

            else
                Console.WriteLine($"Not enough money! {Math.Abs(result - priceOfExcursion):f2} lv needed.");

        }
    }
}
