using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrade = int.Parse(Console.ReadLine());
            int counter =0;
            int counter2 = 0;
            double sumGrade = 0;            
            string lastName = "";
            bool isEnough = false;
            while (!isEnough && counter2 != poorGrade)
            {
                string nameGrade = Console.ReadLine();
                if (nameGrade == "Enough")
                {
                    isEnough = true;
                     break;
                }

                lastName = nameGrade;
                counter++;
                int grade = int.Parse(Console.ReadLine());
                sumGrade += grade;
                if (grade <= 4)
                {
                    counter2++;
                }

            }

            if (isEnough)
            {
                Console.WriteLine($"Average score: {sumGrade / counter:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastName}");
            }

            else
            {
                Console.WriteLine($"You need a break, {counter2} poor grades.");
            }
        }
    }
}
