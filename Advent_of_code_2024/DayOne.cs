using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advent_of_code_2024
{
    internal class DayOne
    {
        internal static void RunDayOne()
        {
            Console.WriteLine("Choose which of the following do you want to do:");
            Console.WriteLine("(1) - Part 1");
            Console.WriteLine("(2) - Part 2");
            Console.WriteLine("(9) - Return to main menu");
            
            switch (Console.ReadLine())
            {
                case "1":
                    RunDayOnePartOne();
                    break;
                case "2":
                    RunDayOnePartTwo();
                    break;
                case "9":
                    AdventOfCodeMenu.RunMenu();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    RunDayOne();
                    break;
            }
        }

        internal static void RunDayOnePartOne()
        {
            string textFilePath = @"C:\DevProj\Advent_of_code_2024\Advent_of_code_2024\docs\OneOne.txt";

            if (!File.Exists(textFilePath))
            {
                Console.WriteLine($"File not found: {textFilePath}");
                Console.WriteLine("Returning to the main menu. Press any key:");
                Console.ReadKey();
                AdventOfCodeMenu.RunMenu();
                return;
            }

            string[] readText = File.ReadAllLines(textFilePath);

            Console.WriteLine("Processing file...");
            int totalDifference = CalculateTotalDistance(readText);

            Console.WriteLine($"The total difference is: {totalDifference}");
            Console.WriteLine("Returning to the main menu. Press any key:");
            Console.ReadKey();
            RunDayOne();
        }

        private static int CalculateTotalDistance(string[] lines)
        {
            List<int> leftNumbers = new List<int>();
            List<int> rightNumbers = new List<int>();

            foreach (string line in lines)
            {
                string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (numbers.Length == 2)
                {
                    leftNumbers.Add(int.Parse(numbers[0]));
                    rightNumbers.Add(int.Parse(numbers[1]));
                }
            }

            leftNumbers.Sort();
            rightNumbers.Sort();

            int totalDistance = 0;
            for (int i = 0; i < leftNumbers.Count; i++)
            {
                totalDistance += Math.Abs(leftNumbers[i] - rightNumbers[i]);
            }

            return totalDistance;
        }

        private static void RunDayOnePartTwo()
        {
            Console.WriteLine("To be implemented.");
            Console.WriteLine("Returning to the main menu. Press any key:");
            Console.ReadKey();
            RunDayOne();
        }
    }
}
