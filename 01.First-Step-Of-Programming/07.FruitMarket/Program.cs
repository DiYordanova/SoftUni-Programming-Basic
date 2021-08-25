using System;

namespace _7FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangeKg = double.Parse(Console.ReadLine());
            double raspberryKg = double.Parse(Console.ReadLine());
            double strawberyKg = double.Parse(Console.ReadLine());
            double raspberryPrice = strawberryPrice * 0.5;
            double orangePrice = raspberryPrice * 0.6;
            double bananasPrice = raspberryPrice * 0.2;
            double sum = strawberryPrice * strawberyKg + raspberryPrice * raspberryKg + orangePrice * orangeKg + bananasPrice * bananasKg;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
