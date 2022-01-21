using System;

namespace _02.RectangleNxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char symbol = '*';
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write($"{symbol}");
                }
                Console.WriteLine();
            }
        }
    }
}
