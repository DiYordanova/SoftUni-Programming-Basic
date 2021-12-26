using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string term = Console.ReadLine();
            string contract = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double fee = 0;
            double priceMobileInterne = 0;
            double priceTotalForMonth = 0;
            switch (term)
            {
                case "one":
                    if (contract == "Small")
                    {
                        fee = 9.98;
                    }

                    else if (contract == "Middle")
                    {
                        fee = 18.99;
                    }

                    else if (contract == "Large")
                    {
                        fee = 25.98;
                    }

                    else if (contract == "ExtraLarge")
                    {
                        fee = 35.99;
                    }
                    break;
                case "two":
                    if (contract == "Small")
                    {
                        fee = 8.58;
                    }

                    else if (contract == "Middle")
                    {
                        fee = 17.09;
                    }

                    else if (contract == "Large")
                    {
                        fee = 23.59;
                    }

                    else if (contract == "ExtraLarge")
                    {
                        fee = 31.79;
                    }
                    break;
            }
            if (mobileInternet == "yes" && fee <= 10)
            {
                priceMobileInterne = 5.50;
            }

            else if (mobileInternet == "yes" && fee <= 30)
            {
                priceMobileInterne = 4.35;
            }

            else if (mobileInternet == "yes" && fee > 30)
            {
                priceMobileInterne = 3.85;
            }

            priceTotalForMonth = fee + priceMobileInterne;

            if (term == "two")
            {
                priceTotalForMonth = priceTotalForMonth - priceTotalForMonth * 0.0375;
            }

            Console.WriteLine($"{months * priceTotalForMonth:f2} lv.");
        }
    }
}

