using System;

namespace ExamPreparationMay2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegetarian = int.Parse(Console.ReadLine());
            double chichenPrice = 10.35;
            double fishPrice = 12.40;
            double vegetarianPrice = 8.15;
            double food = chicken * chichenPrice + fish * fishPrice + vegetarian * vegetarianPrice;
            double dessertPrice = food * 0.2;
            double delivery = 2.50;
            Console.WriteLine($"Total: {food + dessertPrice + delivery:f2}");

        }
    }
}

