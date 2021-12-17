using System;

namespace ExamPreparationApril2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counterTicket = 0;
            int counterOtherPurchase = 0;
            while (input != "End")
            {
                char symbol1 = input[0];
                char symbol2 = input[1];
                if (input.Length > 8)
                {
                    if ((symbol1 + symbol2) <= voucher)
                    {
                        voucher = voucher - (symbol1 + symbol2);
                        counterTicket++;
                    }

                    else
                    {
                        break;
                    }
                }

                else if (input.Length <= 8)
                {
                    if (symbol1 <= voucher)
                    {
                        voucher = voucher - symbol1;
                        counterOtherPurchase++;
                    }

                    else
                    {
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{counterTicket}");
            Console.WriteLine($"{counterOtherPurchase}");
        }
    }
}

