using System;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBall = int.Parse(Console.ReadLine());
            double points = 0;
            int counterRed = 0;
            int counterOrange = 0;
            int counterYellow = 0;
            int counterWhite = 0;
            int counterBlack = 0;
            int counterOther = 0;
            for (int i = 0; i < numBall; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    points += 5;
                    counterRed++;
                }

               else if (color == "orange")
                {
                    points += 10;
                    counterOrange++;
                }

                else if (color =="yellow")
                {
                    points += 15;
                    counterYellow++;
                }

                else if (color == "white")
                {
                    points += 20;
                    counterWhite++;
                }

                else if (color == "black")
                {
                    points = Math.Floor(points / 2);
                    counterBlack++;
                }

                else
                {
                    counterOther++;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {counterRed}");
            Console.WriteLine($"Points from orange balls: {counterOrange}");
            Console.WriteLine($"Points from yellow balls: {counterYellow}");
            Console.WriteLine($"Points from white balls: {counterWhite}");
            Console.WriteLine($"Other colors picked: {counterOther}");
            Console.WriteLine($"Divides from black balls: {counterBlack}");
        }
    }
}
