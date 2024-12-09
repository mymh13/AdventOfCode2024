﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2024
{
    internal class AdventOfCodeMenu
    {
        // Since I want to learn from this, none of the code has been generated by LLM tools, it is 100% written by hand.
        // When I get stuck I will search 1) Microsoft documentation, 2) StackOverflow, 3) Google, 4) Pro C#10 With .NET-book, 5) Other books

        internal static void RunMenu()
        {
            Console.Clear();
            Console.WriteLine("Please chose one option from the list below:");
            Console.WriteLine("1: Day one - compare smallest numbers (part 1 and part 2)");
            Console.WriteLine("2: Day two - yet to be implemented");

            Console.WriteLine("\nE: Exit the program.");

            string menuInput = (Console.ReadLine()?.ToUpper()) ?? " ";

            switch (menuInput)
            {
                case "1":
                    DayOne.RunDayOne();
                    break;
                case "2":
                    // DayTwo.RunDayTwo();
                    break;
                case "E":
                    Console.WriteLine("Exiting program. Thanks for playing!");
                    Console.WriteLine("Press any button:");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
            RunMenu();
        }
    }
}
