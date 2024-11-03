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

        // Method to find the Fibonacci series up to n numbers
        public static int[] GenerateFibonacci(int n)
        {
            if (n <= 0) return Array.Empty<int>();
            int[] fib = new int[n];
            fib[0] = 0;
            if (n > 1) fib[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib;
        }

        // Method to check if two strings are anagrams of each other
        public static bool AreAnagrams(string str1, string str2)
        {
            return str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c));
        }

        // Method to find the longest common prefix among an array of strings
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].ToLower().IndexOf(prefix.ToLower()) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0) return "";
                }
            }

            return prefix;
        }


        // Method to perform binary search on a sorted array
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0, right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target) return mid;
                if (array[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1; // Target not found
        }

        // Method to merge two sorted arrays into one sorted array
        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                    result[k++] = arr1[i++];
                else
                    result[k++] = arr2[j++];
            }

            while (i < arr1.Length) result[k++] = arr1[i++];
            while (j < arr2.Length) result[k++] = arr2[j++];

            return result;
        }

        // Method to perform Quick Sort
        public static int[] QuickSort(int[] array)
        {
            Console.WriteLine("Current Array: " + string.Join(", ", array));

            if (array.Length <= 1) return array;

            int pivot = array[array.Length / 2];
            Console.WriteLine($"Pivot: {pivot}");

            var left = array.Where(x => x < pivot).ToArray();
            var middle = array.Where(x => x == pivot).ToArray();
            var right = array.Where(x => x > pivot).ToArray();

            Console.WriteLine($"Left: {string.Join(", ", left)} | Middle: {string.Join(", ", middle)} | Right: {string.Join(", ", right)}");

            return QuickSort(left).Concat(middle).Concat(QuickSort(right)).ToArray();
        }


        // Method to perform Merge Sort
        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1) return array;

            int mid = array.Length / 2;
            int[] left = MergeSort(array.Take(mid).ToArray());
            int[] right = MergeSort(array.Skip(mid).ToArray());

            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length) result[k++] = left[i++];
            while (j < right.Length) result[k++] = right[j++];

            return result;
        }

        // Stack implementation
        public class Stack<T>
        {
            private List<T> _elements = new List<T>();
            public void Push(T item) => _elements.Add(item);
            public T Pop()
            {
                if (_elements.Count == 0) throw new InvalidOperationException("Stack is empty.");
                T item = _elements[^1];
                _elements.RemoveAt(_elements.Count - 1);
                return item;
            }
            public bool IsEmpty() => _elements.Count == 0;
        }

        // Queue implementation
        public class Queue<T>
        {
            private List<T> _elements = new List<T>();
            public void Enqueue(T item) => _elements.Add(item);
            public T Dequeue()
            {
                if (_elements.Count == 0) throw new InvalidOperationException("Queue is empty.");
                T item = _elements[0];
                _elements.RemoveAt(0);
                return item;
            }
            public bool IsEmpty() => _elements.Count == 0;
        }

        // Method to find the longest substring without repeating characters
        public static int LengthOfLongestSubstring(string s)
        {
            HashSet<char> chars = new HashSet<char>();
            int left = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                // Check if the character is already in the set
                while (chars.Contains(s[right]))
                {
                    chars.Remove(s[left]);
                    left++;
                }
                // Add the current character to the set
                chars.Add(s[right]);
                // Calculate the current length and update maxLength
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }

        // Method for matrix addition
        public static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
        {
            int rows = matrixA.GetLength(0);
            int cols = matrixA.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return result;
        }

        // Depth-First Search (DFS)
        public static void DepthFirstSearch(Dictionary<int, List<int>> graph, int start, HashSet<int> visited)
        {
            // Check if the start node exists in the graph
            if (!graph.ContainsKey(start)) return;

            // If the node has already been visited, return
            if (visited.Contains(start)) return;

            // Mark the node as visited and print it
            visited.Add(start);
            Console.WriteLine(start);

            // Recursively visit all adjacent nodes
            foreach (var neighbor in graph[start])
            {
                DepthFirstSearch(graph, neighbor, visited);
            }
        }

        // Example for the 0/1 Knapsack Problem
        public static int Knapsack(int[] weights, int[] values, int capacity)
        {
            int n = values.Length;
            int[,] dp = new int[n + 1, capacity + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int w = 0; w <= capacity; w++)
                {
                    if (weights[i - 1] <= w)
                    {
                        dp[i, w] = Math.Max(dp[i - 1, w], dp[i - 1, w - weights[i - 1]] + values[i - 1]);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }
            return dp[n, capacity];
        }
    }
}
