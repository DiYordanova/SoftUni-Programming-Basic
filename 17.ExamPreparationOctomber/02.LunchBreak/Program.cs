using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double durationEpisode = int.Parse(Console.ReadLine());
            double durationRest = int.Parse(Console.ReadLine());
            double timeForLunch = durationRest / 8;
            double timeForRelaxation = durationRest / 4;
            double timeRest = durationRest - timeForLunch - timeForRelaxation;
            if (timeRest >= durationEpisode)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeRest - durationEpisode)} minutes free time.");
            }

            else
            {

                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(durationEpisode - timeRest)} more minutes.");
            }
        }
    }
}
