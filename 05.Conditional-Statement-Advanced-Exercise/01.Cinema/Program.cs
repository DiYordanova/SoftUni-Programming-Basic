using System;

namespace _01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double income = 0;
            if (movie == "Premiere")
            {
                income = row * column * 12;
            }
            else if (movie == "Normal")
            {
                income = row * column * 7.50;
            }
            else if (movie == "Discount")
            {
                income = row * column * 5;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
