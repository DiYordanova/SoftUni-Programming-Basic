using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int sizeCake = width * lenght;
            int sumCake = 0;
            string input = Console.ReadLine();
            bool isEnought = false;
            while (!isEnought && input != "STOP")
            {
                int pieceCake = int.Parse(input);
                sumCake += pieceCake;
                if (sizeCake <= sumCake)
                {
                    isEnought = true;
                    break;
                }
                input = Console.ReadLine();
            }
            if (isEnought)
            {
                Console.WriteLine($"No more cake left! You need {sumCake - sizeCake} pieces more.");
            }
            else
            {
                Console.WriteLine($"{sizeCake - sumCake} pieces are left.");
            }
        }
    }
}
