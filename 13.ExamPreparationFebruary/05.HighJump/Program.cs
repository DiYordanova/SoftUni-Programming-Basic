using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredHeight = int.Parse(Console.ReadLine());
            int currentDesiredHeight = desiredHeight - 30;
            int counter = 0;
            int counterUnsuccessful = 0;
            bool isSuxccess = false;
            while (!isSuxccess)
            {
                for (int i = 0; i < 3; i++)
                {
                    int currentHeight = int.Parse(Console.ReadLine());
                    counter++;
                    if (currentHeight > desiredHeight)
                    {
                        isSuxccess = true;
                        break;
                    }

                    else if (currentHeight > currentDesiredHeight)
                    {

                        break;
                    }

                    else if (counterUnsuccessful < 3)
                    {
                        counterUnsuccessful++;

                    }

                    if (counterUnsuccessful == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {currentDesiredHeight}cm after {counter} jumps.");
                        return;
                    }
                }
                counterUnsuccessful = 0;


                currentDesiredHeight += 5;
            }

            if (isSuxccess)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeight}cm after {counter} jumps.");
            }

            else
            {
                Console.WriteLine($"Tihomir failed at {currentDesiredHeight}cm after {counter} jumps.");
            }
        }
    }
}

