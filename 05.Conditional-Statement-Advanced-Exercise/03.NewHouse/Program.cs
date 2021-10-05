using System;

namespace _03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int countFlower = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double price = 0;

            if (flower == "Roses")
            {
                price = countFlower * 5;
            }
            else if (flower == "Dahlias")
            {
                price = countFlower * 3.80;
            }
            else if (flower == "Tulips")
            {
                price = countFlower * 2.80;
            }
            else if (flower == "Narcissus")
            {
                price = countFlower * 3;
            }
            else if (flower == "Gladiolus")
            {
                price = countFlower * 2.50;
            }


            if (countFlower > 80 && flower == "Roses")
            {
                price = 0.9 * price;
            }
            else if (countFlower > 90 && flower == "Dahlias")
            {
                price = 0.85 * price;
            }
            else if (countFlower > 80 && flower == "Tulips")
            {
                price = 0.85 * price;
            }
            else if (countFlower < 120 && flower == "Narcissus")
            {
                price += 0.15 * price;
            }
            else if (countFlower < 80 && flower == "Gladiolus")
            {
                price += 0.2 * price;
            }


            if (budjet >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlower} {flower} and {budjet - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budjet:f2} leva more.");
            }
        }
    }
}
