using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFisherman = int.Parse(Console.ReadLine());

            double price = 0;
            if (season =="Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }

            if (countFisherman <= 6)
            {
                price = 0.9 * price;
            }
            else if (countFisherman > 7 && countFisherman <= 11)
            {
                price = 0.85 * price;
            }
            else if (countFisherman >= 12)
            {
                price = 0.75 * price;
            }

            if (countFisherman % 2 == 0 && season != "Autumn")
            {
                price = 0.95 * price;
            }

            if (budjet >= price)
            {
                Console.WriteLine($"Yes! You have {budjet -price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budjet:f2} leva.");
            }
        }
    } 
}
