using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int videoCard = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());
            double videoCardPrice = 250;
            double videoCardTotalPrice = videoCard * videoCardPrice;
            double processorPrice = videoCardTotalPrice * 0.35;
            double ramMemoryPrice = videoCardTotalPrice * 0.10;
            double totalprice = videoCardTotalPrice + processor * processorPrice + ramMemory * ramMemoryPrice;
            if (videoCard > processor)
            {
                totalprice = totalprice - totalprice * 0.15;
            }

            if (budjet >= totalprice)
            {
                Console.WriteLine($"You have {budjet - totalprice:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {totalprice - budjet:f2} leva more!");
            }
        }
    }
}