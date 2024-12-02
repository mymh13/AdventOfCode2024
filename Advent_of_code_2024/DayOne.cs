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
            
            Console.WriteLine("Please enter the numbers for the left list separated by a comma");
            var leftList[] = Console.ReadLine().Split(',');
            // We could check if the user entered a comma separated list of numbers
            // Then we need to convert the string array to an int array

            Console.WriteLine("Please enter the numbers for the right list separated by a comma");
            var rightList[] = Console.ReadLine().Split(',');

            // Now we want to cycle through the two lists and compare the smallest number on the left with the smallest number on the right
        }
    }
}