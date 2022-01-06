using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();
            double difficulty = 0;
            double implementation = 0;
            double maxPoints = 20;
            switch (device)
            {
                case "ribbon":
                    if (country == "Russia")
                    {
                        difficulty = 9.100;
                        implementation = 9.400;
                    }

                    if (country == "Bulgaria")
                    {
                        difficulty = 9.600;
                        implementation = 9.400;
                    }

                    if (country == "Italy")
                    {
                        difficulty = 9.200;
                        implementation = 9.500;
                    }
                    break;
                case "hoop":
                    if (country == "Russia")
                    {
                        difficulty = 9.300;
                        implementation = 9.800;
                    }

                    if (country == "Bulgaria")
                    {
                        difficulty = 9.5500;
                        implementation = 9.7500;
                    }

                    if (country == "Italy")
                    {
                        difficulty = 9.4500;
                        implementation = 9.3500;
                    }
                    break;
                case "rope":
                    if (country == "Russia")
                    {
                        difficulty = 9.600;
                        implementation = 9.000;
                    }

                    if (country == "Bulgaria")
                    {
                        difficulty = 9.500;
                        implementation = 9.400;
                    }

                    if (country == "Italy")
                    {
                        difficulty = 9.700;
                        implementation = 9.150;
                    }
                    break;
            }

            double totalEvaluation = difficulty + implementation;
            double restPoints = maxPoints - totalEvaluation;
            Console.WriteLine($"The team of {country} get {totalEvaluation:f3} on {device}.");
            Console.WriteLine($"{restPoints / maxPoints * 100:f2}%");
        }
    }
}

