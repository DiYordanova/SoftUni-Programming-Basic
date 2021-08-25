using System;

namespace _6AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            switch (name)

            {
                case "square":
                    double sideOfSquare = double.Parse(Console.ReadLine());
                    double areaOfSquare = sideOfSquare * sideOfSquare;
                    Console.WriteLine($"{areaOfSquare:f3}");
                    break;
                case "rectangle":
                    double sideOneOfRectangle = double.Parse(Console.ReadLine());
                    double sideTwoOfRectangle = double.Parse(Console.ReadLine());
                    double areaOfRectangle = sideOneOfRectangle * sideTwoOfRectangle;
                    Console.WriteLine($"{areaOfRectangle:f3}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    double areaOfRadius = radius * radius * Math.PI;
                    Console.WriteLine($"{areaOfRadius:f3}");
                    break;
                case "triangle":
                    double sideOfTriangle = double.Parse(Console.ReadLine());
                    double hеight = double.Parse(Console.ReadLine());
                    double areaOfTriangle = (sideOfTriangle * hеight) / 2;
                    Console.WriteLine($"{areaOfTriangle:f3}");
                    break;

            }
        }
    }
}
