using System;

namespace moreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '*';
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{symbol}");
                }
                Console.WriteLine();
            }
        }
    }
}
