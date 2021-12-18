using System;

namespace _04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double areaNotPaint = double.Parse(Console.ReadLine());
            double totalArea = height * width * 4;
            double meterForPaint = (int)Math.Ceiling(totalArea - totalArea * ((double)areaNotPaint / 100));
            string literPaint = Console.ReadLine();
            while (literPaint != "Tired!")
            {
                double literPaintAsNumber = double.Parse(literPaint);
                meterForPaint -= literPaintAsNumber;
                if (meterForPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(meterForPaint)} l paint left!" );
                    return;
                }

                else if (meterForPaint == 0)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    return;
                }

                literPaint = Console.ReadLine();
            }

            if (literPaint == "Tired!")
            {
                Console.WriteLine($"{meterForPaint} quadratic m left.");
            }
        }
    }
}
