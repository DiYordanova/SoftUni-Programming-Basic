using System;

namespace _05.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double pointEnter = double.Parse(Console.ReadLine());
            int juryNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < juryNumber; i++)
            {
                string nameJury = Console.ReadLine();
                double pointJury = double.Parse(Console.ReadLine());
                pointEnter += (nameJury.Length * pointJury) / 2;
                if (pointEnter > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {pointEnter:f1}!");
                    return;
                }               
            }
            Console.WriteLine($"Sorry, {nameActor} you need {1250.5 - pointEnter:f1} more!");
        }
    }
}
