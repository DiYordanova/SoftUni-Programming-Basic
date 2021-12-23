using System;

namespace _06.FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string nameMax = "";
            int numberFilm = 0;
            int maxSymbol = int.MinValue;
            while (name != "STOP")
            {
                int sumSymbol = 0;
                numberFilm++;              
                for (int i = 0; i < name.Length; i++)
                {
                  char symbol = name[i];
                   
                    if (symbol >= 65 && symbol <= 90)
                    {
                        sumSymbol = sumSymbol - name.Length;
                    }

                    else if (symbol >= 97 && symbol <= 122)
                    {
                        sumSymbol = sumSymbol - 2 * (name.Length);
                    }
                    sumSymbol += symbol;
                }

                if (sumSymbol > maxSymbol)
                {
                    maxSymbol = sumSymbol;
                    nameMax = name;
                }

                if (numberFilm == 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }
                name = Console.ReadLine();
            }

            Console.WriteLine($"The best movie for you is {nameMax} with {maxSymbol} ASCII sum.");
        }
    }
}
