using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string exit = Console.ReadLine();

            switch (input)
            {
                case "m":
                    if (exit =="cm")
                        number = number * 100;
                    else if (exit == "mm")
                        number = number * 1000;
                    break;
                case "cm":
                    if (exit == "m")
                        number = number / 100;
                    else if (exit == "mm")
                        number = number * 10;
                    break;
                case "mm":
                    if (exit == "m")
                        number = number / 1000;
                    else if (exit == "cm")
                        number = number / 10;
                    break;
            }
            Console.WriteLine($"{number:f3}");
        }
    }
}
