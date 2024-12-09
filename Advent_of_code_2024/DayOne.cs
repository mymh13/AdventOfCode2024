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
        private static string textFilePath = @"C:\DevProj\Advent_of_code_2024\Advent_of_code_2024\docs\OneOne.txt";

        internal static void RunDayOne()
        {
            Console.WriteLine("\nChoose which of the following do you want to do:");
            Console.WriteLine("1: Part 1 - Calculate difference between smallest number in each pair on the left/right columns");
            Console.WriteLine("2: Part 2 - Calculate similarity score by multiplying similar numbers in each pair");
            Console.WriteLine("\n9: - Return to main menu");
            
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
            string[] readText = FileNotFound();
            if (readText.Length == 0) return;

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
                // Math.Abs() returns the absolute value of the difference between two numbers
                totalDistance += Math.Abs(leftNumbers[i] - rightNumbers[i]);
            }

            return totalDistance;
        }

        private static void RunDayOnePartTwo()
        {
            string[] readText = FileNotFound();
            if (readText.Length == 0) return;

            int similarityScore = CalculateSimilarityScore(readText);

            Console.WriteLine($"The total product is: {similarityScore}");
            Console.WriteLine("Returning to the main menu. Press any key:");
            Console.ReadKey();
            RunDayOne();
        }

        private static int CalculateSimilarityScore(string[] lines)
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

            int similarityScore = 0;
            foreach (int left in leftNumbers)
            {
                int countInRight = rightNumbers.Count(right => right == left);
                similarityScore += left * countInRight;
            }

            return similarityScore;
        }

        private static string[] FileNotFound()
        {
            if (!File.Exists(textFilePath))
            {
                Console.WriteLine($"File not found: {textFilePath}");
                Console.WriteLine("Returning to the main menu. Press any key:");
                Console.ReadKey();
                AdventOfCodeMenu.RunMenu();
                return Array.Empty<string>(); ;
            }

            Console.WriteLine("Processing file...");
            return File.ReadAllLines(textFilePath);
        }
    }
}
