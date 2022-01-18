using System;

namespace _05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxGoal = int.MinValue;
            string nameMaxGoal = "";
            while (name != "END")
            {
                int goal = int.Parse(Console.ReadLine());
                if (goal > maxGoal)
                {
                    maxGoal = goal;
                    nameMaxGoal = name;
                }

                if (goal >= 10)
                {
                    Console.WriteLine($"{nameMaxGoal} is the best player!");
                    Console.WriteLine($"He has scored {maxGoal} goals and made a hat-trick !!!");
                    return;
                }
                name = Console.ReadLine();
            }

            if (name == "END")
            {
                Console.WriteLine($"{nameMaxGoal} is the best player!");
            }

            if (maxGoal >= 3)
            {
                Console.WriteLine($"He has scored {maxGoal} goals and made a hat-trick !!!");
            }

            else
            {
                Console.WriteLine($"He has scored {maxGoal} goals.");
            }
        }
    }
}
