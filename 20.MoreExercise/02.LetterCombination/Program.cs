using System;

namespace _02.LetterCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char final = char.Parse(Console.ReadLine());
            char without = char.Parse(Console.ReadLine());
            int count = 0;
            
            for (char i = start; i <= final; i++)
            {
                for (char j = start; j <= final; j++)
                {
                    for (char k = start; k <= final; k++)
                    {
                        
                        if (i == without || j == without || k == without)
                        {
                            continue;
                        }

                        else
                        {
                            count++;
                        Console.Write($"{i.ToString()}{j.ToString()}{k.ToString()} ");
                        }
                    }
                }
            }
                        Console.Write($"{count}");
        }
    }
}
