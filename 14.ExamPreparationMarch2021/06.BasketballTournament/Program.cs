using System;

namespace _06.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameTourney = Console.ReadLine();
            int totalCountGame = 0;
            int countWin = 0;
            int countLoss = 0;
            while (nameTourney != "End of tournaments")
            {
                int game = int.Parse(Console.ReadLine());
                for (int i = 1; i <= game; i++)
                {
                    
                    int pointForDesi = int.Parse(Console.ReadLine());
                    int pointAgeintsDesi = int.Parse(Console.ReadLine());

                    if (pointForDesi > pointAgeintsDesi)
                    {
                        countWin++;
                        Console.WriteLine($"Game {i} of tournament {nameTourney}: win with {pointForDesi - pointAgeintsDesi} points.");
                    }

                    else
                    {
                        countLoss++;
                        Console.WriteLine($"Game {i} of tournament {nameTourney}: lost with {pointAgeintsDesi - pointForDesi} points.");
                    }
                }
                
             totalCountGame += game ;
                
                nameTourney = Console.ReadLine();
            }

            if (nameTourney == "End of tournaments")
            {
            Console.WriteLine($"{(double)countWin / totalCountGame * 100:f2}% matches win");
            Console.WriteLine($"{(double)countLoss / totalCountGame * 100:f2}% matches lost");
            }
        }
    }
}
