using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFilm = int.Parse(Console.ReadLine());
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            double averageRating = 0;
            string filmMaxRating = "";
            string filmMinRating = "";
            for (int i = 0; i < numFilm; i++)
            {
                string nameFilm = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                averageRating += rating;
                if (rating > maxRating)
                {
                    maxRating = rating;
                    filmMaxRating = nameFilm;
                }

                if (rating < minRating)
                {
                    minRating = rating;
                    filmMinRating = nameFilm;
                }
            }
            Console.WriteLine($"{filmMaxRating} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{filmMinRating} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {averageRating / numFilm:f1}");
        }
    }
}

