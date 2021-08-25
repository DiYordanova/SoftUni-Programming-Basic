using System;

namespace _5BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentForHall = double.Parse(Console.ReadLine());
            double priceOfCake = rentForHall * 0.2;
            double priceOfDrink = priceOfCake - priceOfCake * 0.45;
            double PriceOfAnimator = rentForHall / 3;
            double rezult = rentForHall + priceOfCake + priceOfDrink + PriceOfAnimator;
            Console.WriteLine(rezult);

        }
    }
}