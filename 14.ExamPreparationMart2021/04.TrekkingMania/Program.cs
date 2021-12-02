using System;

namespace _04.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGroup = int.Parse(Console.ReadLine());
            int allPeople = 0;
            int countMusala = 0;
            int countMonblan = 0;
            int countKilimandjaro = 0;
            int countK2 = 0;
            int countEverest = 0;
            for (int i = 0; i < countGroup; i++)
            {
                int countPeopleInOneGroup = int.Parse(Console.ReadLine());

                if (countPeopleInOneGroup <= 5)
                {
                    countMusala += countPeopleInOneGroup;

                }

                else if (countPeopleInOneGroup <= 12)
                {
                    countMonblan += countPeopleInOneGroup;

                }

                else if (countPeopleInOneGroup <= 25)
                {
                    countKilimandjaro += countPeopleInOneGroup;

                }

                else if (countPeopleInOneGroup <= 40)
                {
                    countK2 += countPeopleInOneGroup;

                }

                else if (countPeopleInOneGroup >= 41)
                {
                    countEverest += countPeopleInOneGroup;
                }

                allPeople += countPeopleInOneGroup;

            }
            double percentageMusala = (double)countMusala / allPeople * 100;
            double percentageMonblan = (double)countMonblan / allPeople * 100;
            double percentageKilimandjaro = (double)countKilimandjaro / allPeople * 100;
            double percentageK2 = (double)countK2 / allPeople * 100;
            double percentageEverest = (double)countEverest / allPeople * 100;
            Console.WriteLine($"{percentageMusala:f2}%");
            Console.WriteLine($"{percentageMonblan:f2}%");
            Console.WriteLine($"{percentageKilimandjaro:f2}%");
            Console.WriteLine($"{percentageK2:f2}%");
            Console.WriteLine($"{percentageEverest:f2}%");
        }
    }
}
