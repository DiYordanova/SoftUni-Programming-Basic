using System;

namespace _06.TournamentOfCristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            double totalSavedMoney = 0;
            int counterWinDay = 0;
            int counterLoseDay = 0;
            for (int i = 1; i <= day; i++)
            {
                double winMoney = 0;
                int counterWin = 0;
                int counterLose = 0;
                string input = Console.ReadLine();
                while (input != "Finish")
                {
                    string rezult = Console.ReadLine();
                    if (rezult == "win")
                    {
                        winMoney += 20;
                        counterWin++;
                    }

                    else if (rezult == "lose")
                    {
                        counterLose++;
                    }
                    input = Console.ReadLine();
                }

                if (counterWin > counterLose)
                {
                    winMoney = winMoney + winMoney * 0.10;
                    counterWinDay++;
                }

                else
                {
                    counterLoseDay++;
                }
                totalSavedMoney += winMoney;
            }

            if (counterWinDay > counterLoseDay)
            {
                totalSavedMoney += totalSavedMoney * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalSavedMoney:f2}");
            }

            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalSavedMoney:f2}");
            }
        }
    }
}

