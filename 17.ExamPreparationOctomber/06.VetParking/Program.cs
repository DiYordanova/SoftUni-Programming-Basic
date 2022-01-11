using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            double totalSum = 0;
            double price = 0;
            int counter = 0;
            for (int i = 1; i <= day; i++)
            {

                double daySum = 0;
                for (int j = 1; j <= hour; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        price = 2.50;
                    }

                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        price = 1.25;
                    }

                    else
                    {
                        price = 1;
                    }
                    daySum += price;
                }
                totalSum += daySum;
                counter++;
                Console.WriteLine($"Day: {counter} - {daySum:f2} leva");
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");

        }
    }
}

