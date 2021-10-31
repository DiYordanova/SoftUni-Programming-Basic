using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabCount = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 0; i < tabCount; i++)
            {
                string tabName = Console.ReadLine();
                switch (tabName)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(Math.Round(salary));
            } 
            
        }
    }
}
