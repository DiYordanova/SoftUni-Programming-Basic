using System;

namespace _09.Mooving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freeSpaceVolume = width * lenght * height;
            int spaceTaken = 0;
            string input = Console.ReadLine(); ;
            while (input != "Done")
            {
                int inputInInt = int.Parse(input);      //
                spaceTaken += inputInInt;              // spaceTaken += int.Parse(input)
                if (spaceTaken >= freeSpaceVolume)
                {
                    Console.WriteLine($"No more free space! You need {spaceTaken - freeSpaceVolume} Cubic meters more."
);
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Done")
            {
                Console.WriteLine($"{freeSpaceVolume - spaceTaken} Cubic meters left.");
            }
        }
    }
}
