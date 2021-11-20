using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            
            for (int i = startNumber; i <= endNumber; i++)
            {
                string numAsText = i.ToString();
                    int oddSum = 0;
                    int evenSum = 0;
                for (int index = 0; index < numAsText.Length; index++)
                {
                    int num = int.Parse(numAsText[index].ToString());
                    if (index % 2 == 0)
                    {
                        evenSum += num;
                    }
                    else
                    {
                        oddSum += num;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
