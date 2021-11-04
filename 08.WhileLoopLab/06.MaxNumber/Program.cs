using System;

namespace _06.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;
            while (input!="Stop")
            {
                int amount = int.Parse(input);
                if (amount > max)
                {
                    max = amount;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
