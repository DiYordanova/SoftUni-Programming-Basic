using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int countpeople = int.Parse(Console.ReadLine());
            double priceClothesPerson = double.Parse(Console.ReadLine());

            double priceClothesPeople = priceClothesPerson * countpeople;
            double movieSet = budjet * 0.10;

            if (countpeople > 150)
            {
                priceClothesPeople -= priceClothesPeople * 0.1;
            }
            double costs = priceClothesPeople + movieSet;
            
            if (costs > budjet)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {costs - budjet:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budjet - costs:f2} leva left.");
            }

        }
    }
}

