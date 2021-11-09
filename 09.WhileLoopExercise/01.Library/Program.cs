using System;

namespace WhileLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            string nextBook = Console.ReadLine();
            int counter = 0;
            while (nextBook != favoriteBook && nextBook != "No More Books")
            {
                nextBook = Console.ReadLine();
                counter++;
            }

            if (nextBook == favoriteBook)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
