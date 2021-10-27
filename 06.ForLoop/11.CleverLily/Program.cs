using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrace = double.Parse(Console.ReadLine());

            int safeMoney = 0;
            int presentMoney = 10;
            int toyCount = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    safeMoney = presentMoney + safeMoney;
                    presentMoney += 10;
                    safeMoney = safeMoney - 1;
                }
                else
                {
                    toyCount++;
                }
            }
            double totalToysPrice = toyCount * toyPrace;
            double incom = totalToysPrice + safeMoney;

            if (incom >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {incom - washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - incom:f2}");
            }
        }
    
    }
}
