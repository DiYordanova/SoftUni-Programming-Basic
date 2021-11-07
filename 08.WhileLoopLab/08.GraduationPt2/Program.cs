using System;

namespace _08.GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sumGrade = 0.00;
            double counter = 0;
            int counterUnrerGrade4 = 0;
            double averageGrade = 0;
            bool isFailed = false;
            while (!isFailed)
            {
                double grade = double.Parse(Console.ReadLine());
                sumGrade += grade;
                counter++;
                averageGrade = sumGrade / counter;
                if (grade < 4)
                {
                    counterUnrerGrade4++;
                }
                if (grade < 4 && counterUnrerGrade4 == 2)
                {

                    Console.WriteLine($"{name} has been excluded at {counter -1} grade");
                    break;
                }
                if (counter == 12)
                {
                    isFailed = true;
                }
            }
            if (isFailed)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
