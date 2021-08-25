using System;

namespace _8FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hеight = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volumeSm = length * width * hеight;
            double volumeLiters = volumeSm * 0.001;
            percentage = percentage * 0.01;
            double realLiters = volumeLiters - (volumeLiters * percentage);
            Console.WriteLine(realLiters);

        }
    }
}
