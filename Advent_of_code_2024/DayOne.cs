using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_of_code_2024
{
    internal class DayOne
    {
        internal static void RunDayOne()
        {
            Console.WriteLine("Welcome to day one. This first puzzle requires matching numbers between two lists.");
            Console.WriteLine("We want to compare the smallest number on the left list with the smallest number on the right.");
            Console.WriteLine("The distance between the numbers will be remembered, and at the end we sum the total distance.\n");

            // Input and validation for both lists
            int[] leftListInt = GetValidatedInput("Please enter the numbers for the left list separated by a comma:");
            int[] rightListInt = GetValidatedInput("Please enter the numbers for the right list separated by a comma:");

            // Calculate total distance
            int totalDistance = CalculateTotalDistance(leftListInt, rightListInt);

            Console.WriteLine($"The total distance between the smallest numbers in the two lists is: {totalDistance}");
            Console.WriteLine("Press any button to return to the main menu.");
            Console.ReadKey();
            Console.Clear();
            AdventOfCodeMenu.RunMenu();
        }

        private static int GetValidatedInput(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    continue;
                }

                if (!input.Contains(","))
                {
                    Console.WriteLine("Input must contain a comma. Please try again.");
                    continue;
                }

                string[] parts = input.Split(",");
                if (parts.Length < 2)
                {
                    Console.WriteLine("Input must contain at least two numbers. Please try again.");
                    continue;
                }

                try
                {
                    return Array.ConvertAll(parts, int.Parse);
                }
                catch (FormatException)
                {
                    Console.WriteLine("All inputs must be valid integers. Please try again.");
                }
            }
        }

        private static int CalculateTotalDistance(int[] leftList, int[] rightList)
        {
            int totalDistance = 0;

            while (leftList.Length > 0 && rightList.Length > 0)
            {
                int leftMin = leftList.Min();
                int rightMin = rightList.Min();

                int leftIndex = Array.IndexOf(leftList, leftMin);
                int rightIndex = Array.IndexOf(rightList, rightMin);

                totalDistance += Math.Abs(leftIndex - rightIndex);

                // Remove the smallest numbers to avoid duplicates
                leftList = RemoveAtIndex(leftList, leftIndex);
                rightList = RemoveAtIndex(rightList, rightIndex);
            }

            return totalDistance;
        }

        private static int[] RemoveAtIndex(int[] array, int index)
        {
            // Remove the element at the specified index
            // The _ is a discard variable, which is used to ignore the value at the current index
            // The lambda expression returns true for all elements except the one at the specified index
            // This way, the Where method filters out the element at the specified index
            // The ToArray method is then used to convert the IEnumerable<int> back to an int[]
            return array.Where((_, i) => i != index).ToArray();
        }
    }
}