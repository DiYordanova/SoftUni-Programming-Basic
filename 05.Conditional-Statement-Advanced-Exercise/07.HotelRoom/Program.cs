using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNight = int.Parse(Console.ReadLine());

            double priceApartment = 0;
            double priceStudio = 0;
            

            switch(month)
            {
                case "May":
                case "October":
                    priceApartment = 65 * countNight;
                    priceStudio = 50 * countNight;
                    if (countNight > 7 && countNight < 14)
                    {
                        priceStudio = 0.95 * priceStudio;
                    }
                    else if (countNight > 14)
                    {
                        priceStudio = 0.70 * priceStudio;
                    }
                    break;
                case "June":
                case "September":
                    priceApartment = 68.70 * countNight;
                    priceStudio = 75.20 * countNight;
                    if (countNight > 14)
                    {
                        priceStudio = 0.80 * priceStudio;
                    }
                    break;
                case "July":
                case "August":
                    priceApartment = 77 * countNight;
                    priceStudio = 76 * countNight;
                    break;
            }

            if (countNight > 14)
            {
                priceApartment = 0.90 * priceApartment;
            }
            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }

    }
}
