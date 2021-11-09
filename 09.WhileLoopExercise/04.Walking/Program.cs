using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetStep = 10000;
            int stepSum = 0;
            string input = Console.ReadLine();
            while (input != "Going home")
            {
                stepSum += int.Parse(input);
                if (stepSum >= targetStep)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{stepSum - targetStep} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Going home")
            {
                input = Console.ReadLine();
                stepSum += int.Parse(input);
                if (stepSum >= targetStep)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{stepSum - targetStep} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{targetStep - stepSum} more steps to reach goal.");
                }
            }
        }
    }
}
