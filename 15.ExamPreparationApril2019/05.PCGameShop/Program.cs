using System;

namespace _05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int heartstone = 0;
            int fornite = 0;
            int owerwatch = 0;
            int other = 0;
            for (int i = 1; i <= counter; i++)
            {
                string game = Console.ReadLine();
                if (game == "Hearthstone")
                {
                    heartstone++;                    
                }

                else if (game == "Fornite")
                {
                    fornite++;                    
                }

                else if (game == "Overwatch")
                {
                    owerwatch++;
                }

                else
                {
                    other++;                    
                }
            }
            double heartstonePercentage = (double)heartstone / counter * 100;
            double fornitePercentage = (double)fornite / counter * 100;
            double owerwatchPercentage = (double)owerwatch / counter * 100;
            double otherPercentage = (double)other / counter * 100;
            Console.WriteLine($"Hearthstone - {heartstonePercentage:f2}%");
            Console.WriteLine($"Fornite - {fornitePercentage:f2}%");
            Console.WriteLine($"Overwatch - {owerwatchPercentage:f2}%");
            Console.WriteLine($"Others - {otherPercentage:f2}%");
            
        }
    }
}
