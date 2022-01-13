using System;

namespace _05.SuitcaseLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;
            while (input != "End")
            {
                double volumeSuitcase = double.Parse(input);
                counter++;
                if (counter % 3 == 0)
                {
                    volumeSuitcase = volumeSuitcase + (volumeSuitcase * 0.10);
                }
                if (trunkCapacity <= volumeSuitcase)
                {
                    break;
                }
                trunkCapacity -= volumeSuitcase;
                input = Console.ReadLine();
            }

            if (input == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {counter} suitcases loaded.");
            }

            else
            {
                Console.WriteLine($"No more space!");
                Console.WriteLine($"Statistic: {counter - 1} suitcases loaded."); ;
            }
        }
    }
}

