using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double count = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current % 2 == 0)
                {
                    p1++;
                }

                if (current % 3 == 0)
                {
                    p2++;
                }

                if (current % 4 == 0)
                {
                    p3++;
                }

            }

            Console.WriteLine($"{p1 / count * 100:f2}%");
            Console.WriteLine($"{p2 / count * 100:f2}%");
            Console.WriteLine($"{p3 / count * 100:f2}%");
        }
    }    
}
    

