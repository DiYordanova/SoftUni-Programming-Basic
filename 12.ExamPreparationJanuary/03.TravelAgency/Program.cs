using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiskount = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
            if (day < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            double price = 0;
            double discount = 0;
            if (city == "Borovets" || city == "Bansko")
            {
                if (package == "withEquipment")
                {
                    price = 100;
                    discount = 0.10;
                }

                else if (package == "noEquipment")
                {
                    price = 80;
                    discount = 0.05;
                }

            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (package == "withBreakfast")
                {
                    price = 130;
                    discount = 0.12;
                }

                else if (package == "noBreakfast")
                {
                    price = 100;
                    discount = 0.07;
                }

            }

            if (day > 7)
            {
                day = day - 1;
            }

            if (vipDiskount == "yes")
            {
                price = price - price * discount;
            }

            double totalPrice = price * day;
            if (totalPrice > 0)
            {
                Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
            }

            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}

