﻿using System;

namespace WhileLoopLab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();

                if (text == "Stop")
                {
                    break;
                }
                Console.WriteLine(text);
            }
        }
    }
}
