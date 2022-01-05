using System;

namespace ExamPreparationOctomber
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());
            int ticket = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            double incomeTotal = ticket * priceTicket * day;
            double incomeForCinema = percentage * incomeTotal / 100;
            double profit = incomeTotal - incomeForCinema;
            Console.WriteLine($"The profit from the movie {name} is {profit:f2} lv.");
        }
    }
}

