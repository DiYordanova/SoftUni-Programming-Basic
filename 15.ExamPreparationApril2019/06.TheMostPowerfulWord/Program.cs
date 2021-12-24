using System;

namespace _06.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double maxValueWord = double.MinValue;
            string winWord = "";
            while (input != "End of words")
            {
                double valueWord = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char symbol = input[i];
                    valueWord += symbol;
                }
                    if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' ||
                        input[0] == 'u' || input[0] == 'y' || input[0] == 'A' || input[0] == 'E' ||
                        input[0] == 'I' || input[0] == 'O' || input[0] == 'U' || input[0] == 'Y')
                    {
                        valueWord = valueWord * input.Length;
                    }
                    else
                    {
                        valueWord = Math.Floor(valueWord / input.Length);
                    }

                if (valueWord > maxValueWord)
                {
                    maxValueWord = valueWord;
                    winWord = input;
                }
                input = Console.ReadLine();
            }
                Console.WriteLine($"The most powerful word is {winWord} - {maxValueWord}");
        }
    }
}

