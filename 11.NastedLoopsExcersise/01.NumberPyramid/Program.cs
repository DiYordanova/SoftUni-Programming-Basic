using System;

namespace NastedLoopsExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (current > number)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}