using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < countNumber; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }

            int sum2 = 0;
            for (int i = 0; i < countNumber; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                sum2 = sum2 + num2;
            }
            if (sum == sum2)
            {

                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum - sum2)}");
            }
        }

    }
}
