﻿using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < countNumber; i++)
            {
                int element = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum = evenSum + element;
                }
                else
                {
                    oddSum = oddSum + element;
                }                
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
