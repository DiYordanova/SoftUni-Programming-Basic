using System;

namespace _6CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int pastryCook = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());
            double sum = ((cake * 45 + waffles * 5.8 + pancake * 3.2) * pastryCook) * day;
            double cost = sum / 8;
            double result = sum - cost;
            Console.WriteLine(result);
        }
    }
}
