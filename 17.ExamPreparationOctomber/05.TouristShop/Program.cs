using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int countForAll = 0;
            int countForThirtProduct = 0;
            double totalPrice = 0;
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                countForThirtProduct++;
                double priceProduct = double.Parse(Console.ReadLine());
                if (countForThirtProduct == 3)
                {
                    countForThirtProduct = 0;
                    priceProduct = priceProduct / 2;
                }

                totalPrice += priceProduct;

                if (totalPrice > budjet)
                {
                    Console.WriteLine($"You don't have enough money!");
                    Console.WriteLine($"You need {totalPrice - budjet:f2} leva!");
                    break;
                }

                countForAll++;
                text = Console.ReadLine();
            }

            if (text == "Stop")
            {
                Console.WriteLine($"You bought {countForAll} products for {totalPrice:f2} leva.");
            }
        }
    }
}

