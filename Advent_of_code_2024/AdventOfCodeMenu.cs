using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2024
{
    internal class AdventOfCodeMenu
    {
        internal static void RunMenu()
        {
            Console.Clear();
            Console.WriteLine("Please chose one option from the list below:");
            Console.WriteLine("1: Day one - compare smallest numbers");
            Console.WriteLine("2: Day one - or perhaps day two ?? seems every day has two challenges??");

            Console.WriteLine("E: Exit the program.");

            var menuInput = Console.ReadLine();

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
        }
    }
}
