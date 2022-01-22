using System;

namespace _05.ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int table = int.Parse(Console.ReadLine());

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= f; j++)
                {
                    if (table > (i + j))
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }

                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
