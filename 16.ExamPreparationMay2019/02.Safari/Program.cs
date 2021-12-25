using System;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double literOfFiel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            double priceOneLiter = 2.10;
            double priceGuidе = 100;
            double costs = literOfFiel * priceOneLiter + priceGuidе;
            if (day == "Saturday")
            {
                costs = costs * 0.90;
            }

            else if (day == "Sunday")
            {
                costs = costs * 0.80;
            }

            if (costs <= budjet)
            {
            Console.WriteLine($"Safari time! Money left: {budjet - costs:f2} lv. ");
            }

            else
            {
                Console.WriteLine($"Not enough money! Money needed: {costs - budjet:f2} lv.");

            }
        }
    }
}
