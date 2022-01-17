using System;

namespace _02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBaggageUnder20kg = double.Parse(Console.ReadLine());
            double kgBaggage = double.Parse(Console.ReadLine());
            int daysBeforeTravel = int.Parse(Console.ReadLine());
            int countBaggage = int.Parse(Console.ReadLine());
            double price = 0;
            if (kgBaggage < 10)
            {
                price = priceBaggageUnder20kg * 0.2;
            }

            else if (kgBaggage <= 20)
            {
                price = priceBaggageUnder20kg * 0.5;
            }

            else if (kgBaggage > 20)
            {
                price = priceBaggageUnder20kg;
            }
            if (daysBeforeTravel < 7)
            {
                price += price * 0.40;
            }

            else if (daysBeforeTravel <= 30)
            {
                price += price * 0.15;
            }

            else if (daysBeforeTravel > 30)
            {
                price += price * 0.10;
            }

            Console.WriteLine($"The total price of bags is: {price * countBaggage:f2} lv. ");
        }
    }
}
