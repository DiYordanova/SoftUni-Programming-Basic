using System;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floоr = int.Parse(Console.ReadLine());
            int flat = int.Parse(Console.ReadLine());
            for (int fr = floоr; fr >= 1; fr--)
            {
                for (int ft = 0; ft < flat; ft++)
                {
                    if (fr == floоr)
                    {
                        Console.Write($"L{fr}{ft} ");                    
                    }
                    
                    if (fr %2 == 0 && fr != floоr)
                    {
                        Console.Write($"O{fr}{ft} ");
                    }

                    if (fr % 2 != 0 && fr != floоr)
                    {
                        Console.Write($"A{fr}{ft} ");
                    }                 
                }
                Console.WriteLine();
            }    
        }
    }
}             
        
    

