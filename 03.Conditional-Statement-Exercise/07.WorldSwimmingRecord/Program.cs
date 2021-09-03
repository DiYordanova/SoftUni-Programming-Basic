using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeSwimmingMeter = double.Parse(Console.ReadLine());

            double sumTimeSwiming = timeSwimmingMeter * distance;
            double resistance = Math.Floor(distance / 15) * 12.5;
            double totalSumSwimming = sumTimeSwiming + resistance;

            if (totalSumSwimming < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalSumSwimming:f2} seconds.");
            }
            else 
            { 
                Console.WriteLine($"No, he failed! He was {Math.Abs(record - totalSumSwimming):f2} seconds slower.");
            }
        }

    }
}

