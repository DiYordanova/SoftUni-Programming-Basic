using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxPoints = int.MinValue;
            string nameWin = "";
            while (name !="Stop")
            {
                int points = 0;
                
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    char symbol = name[i];
                    if (number == symbol)
                    {
                        points += 10;
                    }

                    else
                    {
                        points += 2;
                    }
                }

                if (points >= maxPoints)
                {
                    maxPoints = points;
                    nameWin = name;
                }          

                name = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {nameWin} with {maxPoints} points!");
        }
    }
}
