using System;

namespace _08.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrived = int.Parse(Console.ReadLine());
            int minutesArrived = int.Parse(Console.ReadLine());

            int timeInMinutesExam = hourExam * 60 + minutesExam;
            int timeInMinutesArrived = hourArrived * 60 + minutesArrived;

            if (timeInMinutesArrived == timeInMinutesExam)
            {
                Console.WriteLine("On time");
            }
            else if (timeInMinutesArrived < timeInMinutesExam && timeInMinutesExam - timeInMinutesArrived <= 30)
            {
                Console.WriteLine($"On time {timeInMinutesExam - timeInMinutesArrived} minutes before the start");
            }
            else if (timeInMinutesArrived < timeInMinutesExam && timeInMinutesExam - timeInMinutesArrived >= 60)
            {
                int earlyInMinutes = timeInMinutesExam - timeInMinutesArrived;
                int earlyInHours = earlyInMinutes / 60;
                earlyInMinutes = earlyInMinutes % 60;

                Console.WriteLine($"Early {earlyInHours}:{earlyInMinutes:D2} hours before the start");
            }
            else if (timeInMinutesArrived < timeInMinutesExam && timeInMinutesExam - timeInMinutesArrived >= 30)
            {
                Console.WriteLine($"Early {timeInMinutesExam - timeInMinutesArrived} minutes before the start");
            }
           
            else if (timeInMinutesArrived > timeInMinutesExam && timeInMinutesArrived - timeInMinutesExam <= 59)
            {
                Console.WriteLine($"Late {timeInMinutesArrived - timeInMinutesExam} minutes after the start");
            }
            else if (timeInMinutesArrived > timeInMinutesExam && timeInMinutesArrived - timeInMinutesExam >= 60)
            {
                int lateInMinutes = timeInMinutesArrived - timeInMinutesExam;
                int lateInHours = lateInMinutes / 60;
                lateInMinutes = lateInMinutes % 60;

                Console.WriteLine($"Late {lateInHours}:{lateInMinutes:D2} hours after the start");
            }
        }
    }
}
