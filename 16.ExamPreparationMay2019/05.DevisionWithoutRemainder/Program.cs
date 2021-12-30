using System;

namespace _05.DevisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            for (int i = 0; i < number; i++)
            {
            int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    counter2++;
                }

                if (currentNumber % 3 == 0)
                {
                    counter3++;
                }

                if (currentNumber % 4 == 0)
                {
                    counter4++;
                }
            }

            double percentage2 = (double)counter2 / number * 100;
            double percentage3 = (double)counter3 / number * 100;
            double percentage4 = (double)counter4 / number * 100;

            Console.WriteLine($"{percentage2:f2}%");
            Console.WriteLine($"{percentage3:f2}%");
            Console.WriteLine($"{percentage4:f2}%");
        }
    }
}
