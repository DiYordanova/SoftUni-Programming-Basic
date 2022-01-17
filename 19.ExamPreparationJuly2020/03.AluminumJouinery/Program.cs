using System;

namespace _02.AliminumJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            int aluminiumNum = int.Parse(Console.ReadLine());
            string aluminiumKind = Console.ReadLine();
            string delivery = Console.ReadLine();
            double price = 0;
            double discount = 0;
            if (aluminiumNum < 10)
            {
                Console.WriteLine("Invalid order");
            }

            switch (aluminiumKind)
            {
                case "90X130":
                    price = 110;
                    if (aluminiumNum > 30 && aluminiumNum <= 60)
                    {
                        discount = 5;
                    }

                    else if (aluminiumNum > 60)
                    {
                        discount = 8;
                    }
                    break;
                case "100X150":
                    price = 140;
                    if (aluminiumNum > 40 && aluminiumNum <= 80)
                    {
                        discount = 6;
                    }

                    else if (aluminiumNum > 80)
                    {
                        discount = 10;
                    }
                    break;
                case "130X180":
                    price = 190;
                    if (aluminiumNum > 20 && aluminiumNum <= 50)
                    {
                        discount = 7;
                    }

                    else if (aluminiumNum > 50)
                    {
                        discount = 12;
                    }
                    break;
                case "200X300":
                    price = 250;
                    if (aluminiumNum > 25 && aluminiumNum <= 50)
                    {
                        discount = 9;
                    }

                    else if (aluminiumNum > 50)
                    {
                        discount = 14;
                    }
                    break;
            }
            price = price * aluminiumNum;
            double priceWithDiscount = price - (price * discount) / 100;

            if (delivery == "With delivery")
            {
                priceWithDiscount += 60;
            }

            if (aluminiumNum > 99)
            {
                priceWithDiscount = priceWithDiscount * 0.96;
            }

            if (aluminiumNum >= 10)
            {
                Console.WriteLine($"{priceWithDiscount:f2} BGN");
            }
        }
    }
}


