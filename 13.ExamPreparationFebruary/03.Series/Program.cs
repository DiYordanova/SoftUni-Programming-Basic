using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int numberSeries = int.Parse(Console.ReadLine());
            double totalPriceSeries = 0;
            for (int i = 0; i < numberSeries; i++)
            {
                string nameSeries = Console.ReadLine();
                double priceSeries = double.Parse(Console.ReadLine());

                if (nameSeries == "Thrones")
                {
                    priceSeries = priceSeries / 2;
                }

                else if (nameSeries == "Lucifer")
                {
                    priceSeries -= priceSeries * 0.40;
                }

                else if (nameSeries == "Protector")
                {
                    priceSeries -= priceSeries * 0.30;
                }

                else if (nameSeries == "TotalDrama")
                {
                    priceSeries -= priceSeries * 0.20;
                }

                else if (nameSeries == "Area")
                {
                    priceSeries -= priceSeries * 0.10;
                }

                totalPriceSeries += priceSeries;
            }

            if (budjet >= totalPriceSeries)
            {
                Console.WriteLine($"You bought all the series and left with {budjet - totalPriceSeries:f2} lv.");
            }

            else
            {
                Console.WriteLine($"You need {totalPriceSeries - budjet:f2} lv. more to buy the series!");
            }
        }
    }
}
