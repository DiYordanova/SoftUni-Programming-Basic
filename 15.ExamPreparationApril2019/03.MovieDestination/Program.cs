using System;

namespace _03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Winter":
                    if (destination == "Dubai")
                    {
                        price = 45000;
                    }

                    else if (destination == "Sofia")
                    {
                        price = 17000;
                    }

                    else if (destination == "London")
                    {
                        price = 24000;
                    }
                    break;
                case "Summer":
                    if (destination == "Dubai")
                    {
                        price = 40000;
                    }

                    else if (destination == "Sofia")
                    {
                        price = 12500;
                    }

                    else if (destination == "London")
                    {
                        price = 20250;
                    }
                    break;
            }

            if (destination =="Dubai")
            {
                price -= price * 0.3;
            }

            if (destination =="Sofia")
            {
                price += price * 0.25;
            }

            if (budjet >= price * day)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budjet - price * day:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"The director needs {price * day - budjet:f2} leva more!");
            }
        }
    }
}
