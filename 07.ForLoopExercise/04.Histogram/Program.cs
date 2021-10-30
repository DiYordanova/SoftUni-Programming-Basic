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
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current < 200)
                {
                    p1++;
                }
                else if (current < 400)
                {
                    p2++;
                }
                else if (current < 600)
                {
                    p3++;
                }
                else if (current < 800)
                {
                    p4++;
                }
                else if (current >= 800)
                {
                    p5++;
                }
            }
            Console.WriteLine($"{p1 / count * 100:f2}%");
            Console.WriteLine($"{p2 / count * 100:f2}%");
            Console.WriteLine($"{p3 / count * 100:f2}%");
            Console.WriteLine($"{p4 / count * 100:f2}%");
            Console.WriteLine($"{p5 / count * 100:f2}%");
        }
    }
}
