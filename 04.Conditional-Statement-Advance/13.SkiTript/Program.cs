using System;

namespace _13.SkiTript
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double price = 0;

            if (room == "room for one person")
            {
                price = (day - 1) * 18;
            }
            else if (room == "apartment")
            {
                price = (day - 1) * 25;
            }
            else if (room == "president apartment")
            {
                price = (day - 1) * 35;
            }
            if (room == "apartment")
            {
                if (day < 10)
                {
                    price = 0.7 * price;
                }
                else if (day >= 10 && day <= 15)
                {
                    price = 0.65 * price;
                }
                else if (day >15)
                {
                    price = 0.5 * price;
                }
            }
            else if (room == "president apartment")
            {
                if (day < 10)
                {
                    price = 0.9 * price;
                }
                else if (day >= 10 && day <= 15)
                {
                    price = 0.85 * price;
                }
                else if (day > 15)
                {
                    price = 0.80 * price;
                }
            }
            if (evaluation == "positive")
            {
                price = price + 0.25 * price;
            }
            else if (evaluation == "negative")
            {
                price = price - 0.10 * price;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
