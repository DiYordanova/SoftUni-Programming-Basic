using System;

namespace _05.Time_15Minures
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMinutes = hour * 60 + minutes;
            int sumMinutes = timeInMinutes + 15;
            int timeInHoursAfter15Min = sumMinutes / 60;
            int timeInMinutesAfter15Min = sumMinutes % 60;

            if (timeInHoursAfter15Min > 23)
            {
                timeInHoursAfter15Min = timeInHoursAfter15Min - 24;
            }
            Console.WriteLine($"{timeInHoursAfter15Min}:{timeInMinutesAfter15Min:d2}");
        }
    }
}
