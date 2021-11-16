using System;

namespace _03.Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number = int.Parse(Console.ReadLine());
            for (int x1 = 0; x1 <= number; x1++)
            {
                for (int x2 = 0; x2 <= number; x2++)
                {
                    for (int x3 = 0; x3 <= number; x3++)
                    {
                        int sum = 0;
                        sum = x1 + x2 + x3;
                        if (sum == number)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }


}
