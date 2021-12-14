using System;

namespace _04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string people = Console.ReadLine();
            int totalInkome = 0;
            
            while (people != "Movie time!")
            {
                int income = 0;
                int peopleNumber = int.Parse(people);

                if (peopleNumber > capacity)
                {
                    Console.WriteLine($"The cinema is full.");
                    Console.WriteLine($"Cinema income - {totalInkome} lv.");
                    return;
                }
                capacity -= peopleNumber;
                income = peopleNumber * 5;
                if (peopleNumber % 3 ==0)
                {
                    income = income - 5;
                }
                totalInkome += income;
                people = Console.ReadLine();
            }

            if (people == "Movie time!")
            {
                
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {totalInkome} lv.");
            }
        }
    }
}
