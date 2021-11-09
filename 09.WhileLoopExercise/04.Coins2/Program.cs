using System;

namespace _04.Coins2
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double change = input * 100;
            int coins = 0;
            change = Math.Round(change, 0);
            while (change > 0)
            {
                coins++;
                if (change >= 200)
                {
                    change -= 200;
                }
                else if (change >= 100)
                {
                    change -= 100;
                }
                else if (change >= 50)
                {
                    change -= 50;
                }
                else if (change >= 20)
                {
                    change -= 20;
                }
                else if (change >= 10)
                {
                    change -= 10;
                }
                else if (change >= 5)
                {
                    change -= 5;
                }
                else if (change >= 2)
                {
                    change -= 2;
                }
                else if (change >= 1)
                {
                    change -= 1;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
