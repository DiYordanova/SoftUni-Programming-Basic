using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string namePreсentaion = Console.ReadLine();
            double sumGrade = 0;
            int counter = 0;
            double totalSumGrade = 0;        
            while (namePreсentaion != "Finish")
            {                
                sumGrade = 0;
                for (int i = 0; i < juryCount; i++)
                {
                double grade = double.Parse(Console.ReadLine());
                sumGrade += grade;
                counter++;                
                }

                Console.WriteLine($"{namePreсentaion} - {(sumGrade / juryCount):f2}.");
                namePreсentaion = Console.ReadLine();
                totalSumGrade += sumGrade;

            }
            if (namePreсentaion == "Finish")
            {
                Console.WriteLine($"Student's final assessment is {(totalSumGrade / counter):f2}.");
            }
        }
    }
}
