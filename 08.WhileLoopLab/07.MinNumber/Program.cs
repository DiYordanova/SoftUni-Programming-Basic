using System;

namespace _07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;
            while (input != "Stop")
            {
                int amount = int.Parse(input);
                if (amount < min)
                {
                    min = amount;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}