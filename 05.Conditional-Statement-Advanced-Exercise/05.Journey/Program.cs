using System;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double spendSum = 0;

            if (budjet <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        spendSum = 0.3 * budjet;
                        break;
                    case "winter":
                        spendSum = 0.7 * budjet;
                        break;
                }
            }
            else if (budjet > 101 && budjet <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        spendSum = 0.4 * budjet;
                        break;
                    case "winter":
                        spendSum = 0.8 * budjet;
                        break;
                }
            }
            else if (budjet > 1000)
            {
                destination = "Europe";
                spendSum = 0.9 * budjet;
            }

            string typeOfRest = "";

            if (destination == "Europe")
            {
                typeOfRest = "Hotel";
            }
            else if (season == "summer")
            {
                typeOfRest = "Camp";
            }
            else if (season == "winter")
            {
                typeOfRest = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfRest} - {spendSum:f2}");
        }
    }
}
