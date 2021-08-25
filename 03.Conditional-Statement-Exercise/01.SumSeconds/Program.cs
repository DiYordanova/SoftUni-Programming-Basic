using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;
            int totalTimeMinutes = totalTime / 60;
            int totalTimeSeconds = totalTime % 60;

            if (totalTimeSeconds < 10)
            {
                Console.WriteLine($"{totalTimeMinutes}:0{totalTimeSeconds}");
            }
            else
            {
                Console.WriteLine($"{totalTimeMinutes}:{totalTimeSeconds}");
            }
        }
    }
}