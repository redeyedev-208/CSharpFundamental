namespace CSharpFundamentals
{
    public class CSharpCodingDSAlgosExamples
    {
        // Easy Problem on the Summing of an Array
        public static int EasySumArray(int[]? numbers)
        {
            ArgumentNullException.ThrowIfNull(numbers);

            if (numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }


        // Medium Problem on the Summing of an Array with threshold
        public static int MediumSumArray(int[]? numbers, int threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(numbers);

            if (numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            // Only sum the numbers greater than the threshold
            foreach (var number in numbers)
            {
                if (number > threshold)
                {
                    sum += number;
                }
            }

            return sum;
        }

        // Hard Problem on the Summing of an Array with conditions
        public static int HardSumArray(int[]? numbers, int threshold = 0)
        {
            ArgumentNullException.ThrowIfNull(numbers);

            if (numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            // Only sum the numbers that are positive, even, and greater than the threshold
            foreach (var number in numbers)
            {
                if (number > threshold && number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }

        // Easy Problem for Finding a Pair with sum same applies to Medium for more context
        // Problem Statement: Given an array of integers, return a pair of numbers that add up to a specific target. 
        // If no such pair exists, return null.
        public static (int, int)? EasyMediumFindPairWithSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    return (numbers[left], numbers[right]);
                }

                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            // No pair was found
            return null;
        }

        // Hard Example:
        // Problem Statement: Given an unsorted array of integers, find a pair of numbers 
        // that add up to a specific target, and the numbers can be negative.
        public static (int, int)? FindPairWithSumUnsorted(int[] numbers, int target)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers)); // Throwing an exception for null input
            }

            if (numbers.Length == 0)
            {
                return (0, 0); // Return (0, 0) for empty input if that's your requirement
            }

            HashSet<int> seen = new HashSet<int>();

            foreach (var number in numbers)
            {
                int complement = target - number;
                if (seen.Contains(complement))
                {
                    // Ensure the smaller number comes first
                    return (Math.Min(complement, number), Math.Max(complement, number));
                }
                seen.Add(number);
            }
            return null; // No pair found
        }

        // Problem Statement: Given an array of integers, determine if any value appears at least twice.
        // Time Complexity: O(n) - The hash set allows for average O(1) lookups and insertions.
        public static bool EasyContainsDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (var num in nums)
            {
                if (seen.Contains(num))
                {
                    return true;
                }
                seen.Add(num);
            }
            return false;
        }

        // Problem Statement: Given an array of integers, count the occurrences of each integer and return a dictionary 
        // where the keys are the integers and the values are their respective counts.
        // Time Complexity: O(n) - Each number is processed once, resulting in linear time complexity.
        public static Dictionary<int, int> IntermediateCountOccurrences(int[] nums)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap[num] = 1;
                }
            }
            return countMap;
        }

        public static IList<IList<string>> HardGroupAnagrams(string[] strs)
        {
            var anagramMap = new Dictionary<string, IList<string>>();

            foreach (var str in strs)
            {
                // Convert to lower case to ensure case insensitivity
                var sortedStr = new string(str.ToLower().OrderBy(c => c).ToArray());
                if (!anagramMap.ContainsKey(sortedStr))
                {
                    anagramMap[sortedStr] = new List<string>();
                }
                anagramMap[sortedStr].Add(str);
            }

            return anagramMap.Values.ToList();
        }
    }
}