using System;

namespace _3DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double sum = deposit + termOfDeposit * ((deposit * (percentage / 100)) / 12);
            Console.WriteLine(sum);
        }
    }
}
