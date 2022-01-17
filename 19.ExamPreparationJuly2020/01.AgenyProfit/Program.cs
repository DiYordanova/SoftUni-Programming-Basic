using System;

namespace ExamPreparationJuly2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numTicketAdult = int.Parse(Console.ReadLine());
            int numTicketKid = int.Parse(Console.ReadLine());
            double priceTicketAdult = double.Parse(Console.ReadLine());
            double priceService = double.Parse(Console.ReadLine());
            double priceTicketAdultTotal = priceTicketAdult + priceService;
            double priceTicketKidTotal = priceTicketAdult * 0.3 + priceService;
            double priceTicketTotal = (priceTicketAdultTotal * numTicketAdult) + (priceTicketKidTotal * numTicketKid);
            double profit = priceTicketTotal * 0.2;
            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2} lv.");
        }
    }
}

