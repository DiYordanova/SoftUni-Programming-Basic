using System;

namespace _05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int game = int.Parse(Console.ReadLine());
            int w = 0;
            int d = 0;
            int l = 0;
            for (int i = 0; i < game; i++)
            {
                string inputRezult = Console.ReadLine();
                if (inputRezult == "W")
                {
                    w++;
                }

                else if (inputRezult == "D")
                {
                    d++;
                }

                else if (inputRezult == "L")
                {
                    l++;
                }
            }

            double point = w * 3 + d;
            double winGame = (double)w / game * 100;
            if (game == 0)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");
            }

            else
            {
            Console.WriteLine($"{name} has won {point} points during this season.");
            Console.WriteLine($"Total stats:");
            Console.WriteLine($"## W: {w}");
            Console.WriteLine($"## D: {d}");
            Console.WriteLine($"## L: {l}");
            Console.WriteLine($"Win rate: {winGame:f2}%");          
            }
        }
    }
}
