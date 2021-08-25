using System;

namespace _4VocationBoocsList
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPage = int.Parse(Console.ReadLine());
            double pagePerOneHour = Double.Parse(Console.ReadLine());
            int countOfDay = int.Parse(Console.ReadLine());
            double timeAllPages = countPage / pagePerOneHour;
            double result = timeAllPages / countOfDay;
            Console.WriteLine(result);

        }
    }
}
