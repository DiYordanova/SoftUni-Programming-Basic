using System;

namespace _03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string type = Console.ReadLine();
            int ticket = int.Parse(Console.ReadLine());
            double price = 0;
            switch (type)
            {
                case "Drink":
                    if (movie == "John Wick")
                    {
                        price = 12;
                    }

                    else if (movie == "Star Wars")
                    {
                        price =18;
                    }

                    else if (movie == "Jumanji")
                    {
                        price = 9;
                    }
                    break;
                case "Popcorn":
                    if (movie == "John Wick")
                    {
                        price = 15;
                    }

                    else if (movie == "Star Wars")
                    {
                        price = 25;
                    }

                    else if (movie == "Jumanji")
                    {
                        price = 11;
                    }
                    break;
                case "Menu":
                    if (movie == "John Wick")
                    {
                        price = 19;
                    }

                    else if (movie == "Star Wars")
                    {
                        price = 30;
                    }

                    else if (movie == "Jumanji")
                    {
                        price = 14;
                    }
                    break;
            }

            if (movie == "Star Wars" && ticket >= 4 )
            {
                price = price - price * 0.3;
            }

            if (movie == "Jumanji" && ticket == 2)
            {
                price = price - price * 0.15;
            }

            Console.WriteLine($"Your bill is {ticket * price:f2} leva.");
        }
    }
}
       
