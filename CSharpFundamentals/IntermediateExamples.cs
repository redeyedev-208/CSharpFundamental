using System;
using System.Linq;

namespace CSharpFundamentals
{
    public class IntermediateExamples
    {
        // Method to find the intersection of two arrays
        public static int[] FindArrayIntersection(int[] array1, int[] array2)
        {
            // Handle null inputs
            if (array1 == null || array2 == null)
            {
                Console.WriteLine("One or both input arrays are null.");
                return Array.Empty<int>(); // Return an empty array
            }

            // Compute intersection
            int[] intersection = array1.Intersect(array2).ToArray();

            return intersection;
        }

        // Method to calculate factorial of a number
        public static int CalculateFactorial(int number)
        {
            if (number < 0) throw new ArgumentException("Number must be a non-negative number.");
            return (number == 0) ? 1 : number * CalculateFactorial(number - 1);
        }

        // Method to check if an array is sorted in ascending order
        public static bool IsArraySorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }

        // Method to remove vowels from a given string
        public static string RemoveVowels(string input)
        {
            return new string(input.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
        }

        // Method to calculate the sum of the squares of the integers in an array
        public static int SumOfSquares(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = checked(sum + number * number); // Use checked to throw on overflow
            }
            return sum;
        }

    }
}
