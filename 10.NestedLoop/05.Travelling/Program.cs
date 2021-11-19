using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double budjet = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < budjet)
                {
                    double currenSum = double.Parse(Console.ReadLine());
                    savedMoney += currenSum;
                }
                Console.WriteLine($"Going to {destination}!");                
                destination = Console.ReadLine();
            }


        }
    }
}
