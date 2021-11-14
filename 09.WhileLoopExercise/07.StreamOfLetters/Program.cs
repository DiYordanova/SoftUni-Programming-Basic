using System;

namespace MoreExerciseWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool hasC = false;
            bool hasO = false;
            bool hasN = false;
            string word = "";
            while (input != "End")
            {
                if (input == "c")
                {
                    if (hasC)
                    {
                        word += input;
                    }
                    else
                    {
                        hasC = true;
                    }
                }

                else if (input == "o")
                {
                    if (hasO)
                    {
                        word += input;
                    }
                    else
                    {
                        hasO = true;
                    }

                }

                else if (input == "n")
                {
                    if (hasN)
                    {
                        word += input;
                    }
                    else
                    {
                        hasN = true;
                    }

                }

                else
                {
                    int charNum = input[0];
                    if ((65 <= charNum && charNum <= 90) || (97 <= charNum && charNum <= 122))
                    {
                        word += input;
                    }
                }
                if (hasC && hasO && hasN)
                {
                    Console.Write($"{word} ");
                    word = "";
                    hasC = false;
                    hasO = false;
                    hasN = false;
                }
                input = Console.ReadLine();
            }
        }
    }
}

