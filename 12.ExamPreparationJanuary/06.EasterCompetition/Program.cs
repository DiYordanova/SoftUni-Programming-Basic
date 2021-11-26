using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBread = int.Parse(Console.ReadLine());
            int maxPoints = int.MinValue;
            string bakerNumber1 = "";
            for (int i = 0; i < easterBread; i++)
            {
                string baker = Console.ReadLine();
                int totalPoints = 0;
                string command = Console.ReadLine();
                while (command != "Stop")
                {
                    int points = int.Parse(command);
                    totalPoints += points;
                    command = Console.ReadLine();

                }

                Console.WriteLine($"{baker} has {totalPoints} points.");

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    bakerNumber1 = baker;
                    Console.WriteLine($"{baker} is the new number 1!");
                }

            }
            Console.WriteLine($"{bakerNumber1} won competition with {maxPoints} points!");
        }
    }
}

