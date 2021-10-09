using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string simbol = Console.ReadLine();

            double sum = n1 + n2;
            double difference = n1 - n2;
            double division = n1 / n2;
            double divisionPercentage = n1 % n2;
            double multiplication = n1 * n2;

            switch (simbol)
            {
                case "+":
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                    }
                    break;
                case "-":
                    if (difference % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {difference} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {difference} - odd");
                    }
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} / {n2} = {division:f2}");
                    }
                    break;
                case "*":
                    if (multiplication % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {multiplication} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {multiplication} - odd");
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} % {n2} = {divisionPercentage}");
                    }
                    break;
            }
        }
    }
}
