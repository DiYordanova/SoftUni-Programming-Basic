using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double socialScholarShip = 0;
            if(income < minimumWage && averageSuccess >= 4.50)
            {
                socialScholarShip = Math.Floor(minimumWage * 0.35);
            }

            double scholarshipForExcellent = 0;
            if(averageSuccess >= 5.5)
            {
                scholarshipForExcellent = Math.Floor(averageSuccess * 25);
            }

            if(socialScholarShip == 0 && scholarshipForExcellent == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if(socialScholarShip > 0 && scholarshipForExcellent > 0)
            {
                if (socialScholarShip > scholarshipForExcellent)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarShip} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellent} BGN");
                }
            }
            else if(socialScholarShip > 0)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarShip} BGN");
            }
            else if(scholarshipForExcellent > 0)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExcellent} BGN");
            }           
        }
    }
}
