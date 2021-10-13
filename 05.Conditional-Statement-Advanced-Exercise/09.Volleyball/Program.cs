using System;

namespace _09.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holiday = int.Parse(Console.ReadLine());
            int weekendInBirthPlace = int.Parse(Console.ReadLine());

            int weekendInSofia = 48 - weekendInBirthPlace;
            double weekendInSofiaPlay = 0.75 * weekendInSofia;
            double holidayPlay = (holiday * 2) / 3;
            double countPlay = weekendInSofiaPlay + weekendInBirthPlace + holidayPlay;

            if (year == "leap")
            {
                countPlay += countPlay * 0.15;
            }
            Console.WriteLine(Math.Floor(countPlay));
        }
    }
}
