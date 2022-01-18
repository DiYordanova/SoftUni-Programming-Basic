using System;

namespace _06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {    // FIRS VARIANT        
            //int f = int.Parse(Console.ReadLine());
            //int s = int.Parse(Console.ReadLine());

            //int f1 = f / 1000;
            //int f2 = f / 100 % 10;
            //int f3 = f / 10 % 10;
            //int f4 = f % 10;

            //int s1 = s / 1000;
            //int s2 = s / 100 % 10;
            //int s3 = s / 10 % 10;
            //int s4 = s % 10;

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        for (int k = 1; k <= 9; k++)
            //        {
            //            for (int l = 1; l <= 9; l++)
            //            {
            //                if ((i % 2 != 0 || i == 1) && i >= f1 && i <= s1)
            //                {
            //                    if ((j % 2 != 0 || j == 1) && j >= f2 && j <= s2)
            //                    {
            //                        if ((k % 2 != 0 || k == 1) && k >= f3 && k <= s3)
            //                        {
            //                            if ((l % 2 != 0 || l == 1) && l >= f4 && l <= s4)
            //                                Console.Write("" + i + j + k + l + " ");
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //SECOND VARIANT

            //int startNumber = int.Parse(Console.ReadLine());
            //int finalNumber = int.Parse(Console.ReadLine());

            //int s1 = startNumber / 1000;
            //int s2 = (startNumber / 100) % 10;
            //int s3 = (startNumber / 10) % 10;
            //int s4 = startNumber % 10;

            //int f1 = finalNumber / 1000;
            //int f2 = (finalNumber / 100) % 10;
            //int f3 = (finalNumber / 10) % 10;
            //int f4 = finalNumber % 10;

            //for (int i = s1; i <= f1; i++)
            //{
            //    for (int j = s2; j <= f2 ; j++)
            //    {
            //        for (int k = s3; k <= f3; k++)
            //        {
            //            for (int l = s4; l <= f4; l++)
            //            {
            //                if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
            //                {
            //                    Console.Write($"{i}{j}{k}{l} ");
            //                }
            //            }
            //        }
            //    }
            //}

            // THIRD VARIANT
            string startNumberAsText = Console.ReadLine();
            string finalNumberAsText = Console.ReadLine();

            int startNumber = int.Parse(startNumberAsText);
            int finalNumber = int.Parse(finalNumberAsText);

            char firstNumStart = startNumberAsText[0];
            char secondNumStart = startNumberAsText[1];
            char treeNumStart = startNumberAsText[2];
            char fourNumStart = startNumberAsText[3];


            char firstNumFinal = finalNumberAsText[0];
            char secondNumFinal = finalNumberAsText[1];
            char treeNumFinal = finalNumberAsText[2];
            char fourNumFinal = finalNumberAsText[3];

            int firstNumStartInt = int.Parse(firstNumStart.ToString());
            int secondNumStartInt = int.Parse(secondNumStart.ToString());
            int treeNumStartInt = int.Parse(treeNumStart.ToString());
            int fourNumStartInt = int.Parse(fourNumStart.ToString());

            int firstNumFinalInt = int.Parse(firstNumFinal.ToString());
            int secondNumFinaltInt = int.Parse(secondNumFinal.ToString());
            int treeNumFinalInt = int.Parse(treeNumFinal.ToString());
            int fourNumFinalInt = int.Parse(fourNumFinal.ToString());

            int sum;

            for (int i = firstNumStartInt; i <= firstNumFinalInt; i++)
            {
                for (int j = secondNumStartInt; j <= secondNumFinaltInt; j++)
                {
                    for (int k = treeNumStartInt; k <= treeNumFinalInt; k++)
                    {
                        for (int l = fourNumStartInt; l <= fourNumFinalInt; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                int i1 = i;

                                int j2 = j;

                                int k2 = k;

                                int f2 = l;

                                sum = i1 * 1000 + j2 * 100 + k2 * 10 + f2 * 1;

                                if (sum >= startNumber && sum <= finalNumber)
                                {
                                    Console.Write("{0} ", sum);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}



