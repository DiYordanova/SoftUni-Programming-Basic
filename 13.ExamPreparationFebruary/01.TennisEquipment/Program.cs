using System;

namespace pPreparationExamFebruary
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTennisRacket = double.Parse(Console.ReadLine());
            int countTennisRacket = int.Parse(Console.ReadLine());
            int cointSneakers = int.Parse(Console.ReadLine());
            double priceTotalTennisRacket = priceTennisRacket * countTennisRacket;
            double priceSneacers = priceTennisRacket / 6;
            double priceTotalSneakers = priceSneacers * cointSneakers;
            double otherEquipment = (priceTotalSneakers + priceTotalTennisRacket) * 0.2;
            double totalPrice = priceTotalSneakers + priceTotalTennisRacket + otherEquipment;
            double totalPriceDjokovic = totalPrice / 8;
            double totalPriceSponsor = totalPrice * (0.875);
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPriceDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPriceSponsor)}");
        }
    }
}
