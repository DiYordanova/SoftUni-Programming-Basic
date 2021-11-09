using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double ownerMoney = double.Parse(Console.ReadLine());
            int spendMoneyCount = 0;
            int day = 0;
            while (ownerMoney < needMoney && spendMoneyCount < 5 )
            {
            string command = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());
                day++;
                if (command == "save")
                {
                    ownerMoney += money;
                    spendMoneyCount = 0;
                    
                }

                else
                {
                    ownerMoney -= money;
                    spendMoneyCount++;
                    if (money > ownerMoney)
                    {
                        ownerMoney = 0;
                    }
                }

            }

            if (ownerMoney >= needMoney)
            {
                Console.WriteLine($"You saved the money for {day} days.");
            }

            if (spendMoneyCount == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(day);
            }
        }
    }
}
