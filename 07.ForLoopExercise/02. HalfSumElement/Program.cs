using System;

namespace _02._HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;

                if (current > max)
                {
                    max = current;
                }
            }
                if (sum - max == max)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {max}");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(max -(sum - max))}");
                }            
        }
    }
} 
