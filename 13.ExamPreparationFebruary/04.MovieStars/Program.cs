using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string nameActor = Console.ReadLine();
            while (nameActor != "ACTION")
            {

                if (nameActor.Length <= 15)
                {
                    double costActor = double.Parse(Console.ReadLine());
                    budjet -= costActor;
                }

                else
                {
                    budjet = budjet * 0.80;
                }

                if (budjet <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budjet):f2} leva for our actors.");
                    return;
                }
                nameActor = Console.ReadLine();
            }

            if (nameActor == "ACTION")
            {
                Console.WriteLine($"We are left with {budjet:f2} leva.");
            }
        }
    }
}
