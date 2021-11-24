using System;

namespace ExamPreparationJanuary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double sunbedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());
            double totalEntranceFee = entranceFee * numOfPeople;
            double totalSunbedPrice = Math.Ceiling(0.75 * numOfPeople) * sunbedPrice;
            double totalUmbrellaPrice = Math.Ceiling(numOfPeople * 0.5) * umbrellaPrice;
            Console.WriteLine($"{totalEntranceFee + totalSunbedPrice + totalUmbrellaPrice:f2} lv.");
        }
    }
}
