using System;

namespace _03.OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            for (int i = 1; i <= count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }
                    if (evenMin > num)
                    {
                        evenMin = num;
                    }

                }
                else
                {
                    oddSum += num;
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }
                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                }
            }            
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddSum == 0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenSum == 0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
