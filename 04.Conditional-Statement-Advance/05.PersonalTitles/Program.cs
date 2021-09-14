using System;

namespace _05.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string jender = Console.ReadLine();

            if (age >= 16 && jender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (age < 16 && jender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16 && jender == "f")
            {
                Console.WriteLine("Ms.");
            }
            else if (age < 16 && jender == "f")
            { 
                Console.WriteLine("Miss");
            }
            

          
        }
    }
}
