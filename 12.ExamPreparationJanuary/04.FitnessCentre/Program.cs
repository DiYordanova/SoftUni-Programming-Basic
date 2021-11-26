using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int counterBack = 0;
            int counterChest = 0;
            int counterLegs = 0;
            int counterAbs = 0;
            int counterProteinShake = 0;
            int counterProteinBar = 0;
            int counterWorkOut = 0;
            int counterProtein = 0;
            for (int i = 0; i < numOfPeople; i++)
            {
                string input = Console.ReadLine();
                if (input == "Back")
                {
                    counterBack++;
                    counterWorkOut++;
                }
                else if (input == "Chest")
                {
                    counterChest++;
                    counterWorkOut++;
                }

                else if (input == "Legs")
                {
                    counterLegs++;
                    counterWorkOut++;
                }

                else if (input == "Abs")
                {
                    counterAbs++;
                    counterWorkOut++;
                }

                else if (input == "Protein shake")
                {
                    counterProteinShake++;
                    counterProtein++;
                }

                else if (input == "Protein bar")
                {
                    counterProteinBar++;
                    counterProtein++;
                }
            }

            Console.WriteLine($"{counterBack} - back");
            Console.WriteLine($"{counterChest} - chest");
            Console.WriteLine($"{counterLegs} - legs");
            Console.WriteLine($"{counterAbs} - abs");
            Console.WriteLine($"{counterProteinShake} - protein shake");
            Console.WriteLine($"{counterProteinBar} - protein bar");
            Console.WriteLine($"{counterWorkOut / (double)numOfPeople * 100:f2}% - work out");
            Console.WriteLine($"{counterProtein / (double)numOfPeople * 100:f2}% - protein");
        }
    }
}

