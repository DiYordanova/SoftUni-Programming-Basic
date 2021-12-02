using System;

namespace _03.CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string shugar = Console.ReadLine();
            int countDrink = int.Parse(Console.ReadLine());
            double price = 0;
            switch (drink)
            {
                case "Espresso":
                    if (shugar == "Without")
                    {
                        price = 0.90;
                    }

                    else if (shugar == "Normal")
                    {
                        price = 1.00;
                    }

                    else if (shugar == "Extra")
                    {
                        price = 1.20;
                    }
                    break;
                case "Cappuccino":
                    if (shugar == "Without")
                    {
                        price = 1.00;
                    }

                    else if (shugar == "Normal")
                    {
                        price = 1.20;
                    }

                    else if (shugar == "Extra")
                    {
                        price = 1.60;
                    }
                    break;
                case "Tea":
                    if (shugar == "Without")
                    {
                        price = 0.50;
                    }

                    else if (shugar == "Normal")
                    {
                        price = 0.60;
                    }

                    else if (shugar == "Extra")
                    {
                        price = 0.70;
                    }
                    break;
            }

            if (shugar == "Without")
            {
                price = price - price * 0.35;
            }

            if (drink == "Espresso" && countDrink >= 5)
            {
                price = price - price * 0.25;
            }

            price = price * countDrink;
            if (price > 15.00)
            {
                price = price - price * 0.20;
            }

            Console.WriteLine($"You bought {countDrink} cups of {drink} for {price:f2} lv.");
        }
    }
}
 