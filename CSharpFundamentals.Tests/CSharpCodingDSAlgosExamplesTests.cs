namespace CSharpFundamentals.Tests
{
    public class CSharpCodingDSAlgosExamplesTests
    {
        [Fact]
        public void EasySumArray_ShouldReturnSum_WhenArrayContainsPositiveNumbers()
        {
            // Arrange
            var numbers = new int[] { 1, 2, 3, 4 };
            var expected = 10;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasySumArray(numbers);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Easy Problem Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This manual summation method is useful if you plan to implement additional logic for each element during summation.");
            Console.WriteLine("Alternative Approach (LINQ Sum()):");
            Console.WriteLine("Using LINQ's Sum() is preferable for readability and simplicity when the goal is just to sum the elements of an array.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void EasySumArray_ShouldReturnZero_WhenArrayIsEmpty()
        {
            // Arrange
            var numbers = new int[0];
            var expected = 0;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasySumArray(numbers);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Easy Problem Empty Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("Returning 0 for an empty array makes the function intuitive for users expecting a sum.");
            Console.WriteLine("Alternative Approach (LINQ Sum()):");
            Console.WriteLine("While LINQ will also handle empty arrays, manual checks can provide clearer control over logic if needed.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void EasySumArray_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[]? numbers = null;

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => CSharpCodingDSAlgosExamples.EasySumArray(numbers));

            // Console Output
            Console.WriteLine("=== Sum Array Easy Problem Null Test Results ===");
            Console.WriteLine($"Input Array: null");
            Console.WriteLine($"Expected Exception: {nameof(ArgumentNullException)}");
            Console.WriteLine($"Actual Exception: {exception.GetType().Name}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This method ensures that callers are alerted if they provide a null array.");
            Console.WriteLine("Alternative Approach (LINQ Sum()):");
            Console.WriteLine("LINQ does not handle null checks for the collection, so it's essential to ensure null safety when using it.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void EasySumArray_ShouldReturnSum_WhenArrayContainsNegativeNumbers()
        {
            // Arrange
            var numbers = new int[] { -1, -2, -3, -4 };
            var expected = -10;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasySumArray(numbers);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Easy Problem Negative Numbers Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This approach is beneficial when handling sums that include negative numbers, ensuring accurate total calculation.");
            Console.WriteLine("Alternative Approach (LINQ Sum()):");
            Console.WriteLine("Using LINQ's Sum() method can simplify this logic as well while maintaining readability.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void EasySumArray_ShouldReturnSum_WhenArrayContainsMixedNumbers()
        {
            // Arrange
            var numbers = new int[] { 1, -2, 3, -4 };
            var expected = -2;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasySumArray(numbers);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Easy Problem Mixed Numbers Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This approach effectively handles diverse inputs, providing a flexible summation method.");
            Console.WriteLine("Alternative Approach (LINQ Sum()):");
            Console.WriteLine("LINQ can achieve the same result concisely but lacks the granular control provided by manual iteration.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void MediumSumArray_ShouldReturnSum_WhenArrayContainsNumbersAboveThreshold()
        {
            // Arrange
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var threshold = 2;
            var expected = 12; // 3 + 4 + 5

            // Act
            var result = CSharpCodingDSAlgosExamples.MediumSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Medium Problem Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This method is useful when you want to sum values conditionally based on a defined threshold.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("Consider using LINQ for more concise code, though it may affect readability depending on the context.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void MediumSumArray_ShouldReturnZero_WhenArrayContainsNoNumbersAboveThreshold()
        {
            // Arrange
            var numbers = new int[] { 1, 2 };
            var threshold = 2;
            var expected = 0;

            // Act
            var result = CSharpCodingDSAlgosExamples.MediumSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Medium Problem No Above Threshold Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This case demonstrates handling of an array where all numbers fall below the threshold, returning zero.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("You might also want to handle different cases using LINQ for variety in results.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void MediumSumArray_ShouldReturnZero_WhenArrayIsEmpty()
        {
            // Arrange
            var numbers = new int[0];
            var threshold = 0;
            var expected = 0;

            // Act
            var result = CSharpCodingDSAlgosExamples.MediumSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Medium Problem Empty Array Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("Returning 0 for an empty array ensures clarity and expected behavior.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("LINQ will also return 0 for an empty array but requires no additional logic.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void MediumSumArray_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[]? numbers = null;
            var threshold = 0;

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => CSharpCodingDSAlgosExamples.MediumSumArray(numbers, threshold));

            // Console Output
            Console.WriteLine("=== Sum Array Medium Problem Null Test Results ===");
            Console.WriteLine($"Input Array: null");
            Console.WriteLine($"Expected Exception: {nameof(ArgumentNullException)}");
            Console.WriteLine($"Actual Exception: {exception.GetType().Name}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This method ensures that callers are alerted if they provide a null array.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("LINQ does not handle null checks for the collection, so ensuring null safety is crucial.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void MediumSumArray_ShouldReturnSum_WhenArrayContainsNegativeAndPositiveNumbers()
        {
            // Arrange
            var numbers = new int[] { -1, 2, -3, 4, 5 };
            var threshold = 0;
            var expected = 11; // 2 + 4 + 5

            // Act
            var result = CSharpCodingDSAlgosExamples.MediumSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Medium Problem Mixed Numbers Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This approach effectively handles a mixture of positive and negative numbers.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("Using LINQ can simplify the code, but manual iteration provides better clarity on conditions.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void HardSumArray_ShouldReturnSum_WhenArrayContainsPositiveEvenNumbersAboveThreshold()
        {
            // Arrange
            var numbers = new int[] { 2, 4, 6, 8 };
            var threshold = 1;
            var expected = 20;

            // Act
            var result = CSharpCodingDSAlgosExamples.HardSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Hard Problem Positive Even Numbers Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This method is useful for summing positive, even numbers under specific constraints.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("Consider using LINQ for a more concise implementation, though it may reduce clarity.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void HardSumArray_ShouldReturnZero_WhenNoNumbersMeetConditions()
        {
            // Arrange
            var numbers = new int[] { 1, 3, 5, 7 };
            var threshold = 2;
            var expected = 0;

            // Act
            var result = CSharpCodingDSAlgosExamples.HardSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Hard Problem No Numbers Meet Conditions Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This scenario shows handling when no numbers satisfy the conditions.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("Using LINQ could yield similar results with concise code.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void HardSumArray_ShouldReturnSum_WhenArrayContainsMixedNumbers()
        {
            // Arrange
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var threshold = 3;
            var expected = 18; // 4 + 6 + 8

            // Act
            var result = CSharpCodingDSAlgosExamples.HardSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Hard Problem Mixed Numbers Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This scenario demonstrates summing mixed positive and negative numbers based on specific criteria.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("LINQ could also be employed for clearer syntax, though it may obscure the logic in more complex scenarios.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void HardSumArray_ShouldReturnZero_WhenArrayIsEmpty()
        {
            // Arrange
            var numbers = new int[0];
            var threshold = 0;
            var expected = 0;

            // Act
            var result = CSharpCodingDSAlgosExamples.HardSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Hard Problem Empty Array Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("Returning 0 for an empty array ensures expected behavior and clarity.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("Using LINQ would also return 0 without additional checks.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void HardSumArray_ShouldThrowArgumentNullException_WhenArrayIsNull()
        {
            // Arrange
            int[]? numbers = null;

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => CSharpCodingDSAlgosExamples.HardSumArray(numbers));

            // Console Output
            Console.WriteLine("=== Sum Array Hard Problem Null Test Results ===");
            Console.WriteLine($"Input Array: null");
            Console.WriteLine($"Expected Exception: {nameof(ArgumentNullException)}");
            Console.WriteLine($"Actual Exception: {exception.GetType().Name}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This method ensures callers are alerted if they provide a null array.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("LINQ does not handle null checks, making explicit checks essential.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void HardSumArray_ShouldReturnSum_WhenArrayContainsNegativeEvenNumbersAboveThreshold()
        {
            // Arrange
            var numbers = new int[] { -2, -4, 0, -6, -8 };
            var threshold = -5;
            var expected = -6;

            // Act
            var result = CSharpCodingDSAlgosExamples.HardSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Hard Problem Negative Even Numbers Above Threshold Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This example shows how to sum negative even numbers that are above a specified threshold.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("Consider using LINQ for a potentially more compact solution.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void HardSumArray_ShouldReturnZero_WhenAllNumbersAreBelowThreshold()
        {
            // Arrange
            var numbers = new int[] { -2, -4, -6, -8 };
            var threshold = -1;
            var expected = 0;

            // Act
            var result = CSharpCodingDSAlgosExamples.HardSumArray(numbers, threshold);

            // Assert
            Assert.Equal(expected, result);

            // Console Output
            Console.WriteLine("=== Sum Array Hard Problem All Below Threshold Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Threshold: {threshold}");
            Console.WriteLine($"Expected Sum: {expected}");
            Console.WriteLine($"Actual Sum: {result}");
            Console.WriteLine("When to Use This Approach:");
            Console.WriteLine("This scenario illustrates the handling of all numbers below a specified threshold.");
            Console.WriteLine("Alternative Approach:");
            Console.WriteLine("Utilizing LINQ could simplify conditions but may reduce code clarity.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void FindPairWithSum_Empty_Array_Test()
        {
            // Method: EasyMediumFindPairWithSum
            // Problem Statement: Given an empty array, should return default value indicating no pair.
            // Time Complexity: O(1).

            // Arrange
            var inputArray = new int[] { };
            var targetSum = 6;
            (int, int)? expectedOutput = null; // or whatever default makes sense in your context

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyMediumFindPairWithSum(inputArray, targetSum);

            // Print result and time complexity to the console
            Console.WriteLine("=== Find Pair With Sum Empty Array Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Target Sum: {targetSum}");
            Console.WriteLine($"Expected Output: {expectedOutput}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("In the EasyMediumFindPairWithSum method, if the array is empty, it should return a default indicating no pair found.");
            Console.WriteLine("   - The method does not iterate over any elements, leading to a time complexity of O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void FindPairWithSum_Single_Element_Test()
        {
            // Method: EasyMediumFindPairWithSum
            // Problem Statement: Given an array with a single element, should return default value indicating no pair.
            // Time Complexity: O(1).

            // Arrange
            var inputArray = new int[] { 5 };
            var targetSum = 6;
            (int, int)? expectedOutput = null; // or whatever default makes sense in your context

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyMediumFindPairWithSum(inputArray, targetSum);

            // Print result and time complexity to the console
            Console.WriteLine("=== Find Pair With Sum Single Element Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Target Sum: {targetSum}");
            Console.WriteLine($"Expected Output: {expectedOutput}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("In the EasyMediumFindPairWithSum method, if the array has only one element, it cannot form a pair.");
            Console.WriteLine("   - The method does not iterate over any elements, leading to a time complexity of O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void FindPairWithSum_No_Valid_Pair_Test()
        {
            // Method: EasyMediumFindPairWithSum
            // Problem Statement: Given an array where no two numbers sum to the target, should return default value.
            // Time Complexity: O(n).

            // Arrange
            var inputArray = new int[] { 1, 2, 3, 4, 5 };
            var targetSum = 10;
            (int, int)? expectedOutput = null; // or whatever default makes sense in your context

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyMediumFindPairWithSum(inputArray, targetSum);

            // Print result and time complexity to the console
            Console.WriteLine("=== Find Pair With Sum No Valid Pair Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Target Sum: {targetSum}");
            Console.WriteLine($"Expected Output: {expectedOutput}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("In the EasyMediumFindPairWithSum method, if no valid pair is found, it should return a default indicating no pair.");
            Console.WriteLine("   - The method iterates through the array, leading to a time complexity of O(n), where n is the number of elements in the array.");
            Console.WriteLine("==============================");
            Console.WriteLine();

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void FindPairWithSum_Multiple_Pairs_Test()
        {
            // Method: EasyMediumFindPairWithSum
            // Problem Statement: Given an array with multiple pairs summing to the target, should return one of them.
            // Time Complexity: O(n).

            // Arrange
            var inputArray = new int[] { 1, 2, 3, 4, 5, 3 };
            var targetSum = 6;
            var expectedOutput = (3, 3);

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyMediumFindPairWithSum(inputArray, targetSum);

            // Print result and time complexity to the console
            Console.WriteLine("=== Find Pair With Sum Multiple Pairs Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Target Sum: {targetSum}");
            Console.WriteLine($"Expected Output: {expectedOutput}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("In the EasyMediumFindPairWithSum method, if there are multiple valid pairs, the method should return one of them.");
            Console.WriteLine("   - The method iterates through the array, leading to a time complexity of O(n), where n is the number of elements in the array.");
            Console.WriteLine("==============================");
            Console.WriteLine();

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void FindPairWithSum_Negative_Numbers_Test()
        {
            // Problem Statement: Given an array with negative numbers, should correctly find pairs that sum to the target.
            // Time Complexity: O(n).

            // Arrange
            var inputArray = new int[] { -1, -2, -3, 4, 5 };
            var targetSum = 2;
            var expectedOutput = (-2, 4);

            // Act
            var result = CSharpCodingDSAlgosExamples.FindPairWithSumUnsorted(inputArray, targetSum);

            // Print result and time complexity to the console
            Console.WriteLine("=== Find Pair With Sum Negative Numbers Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Target Sum: {targetSum}");
            Console.WriteLine($"Expected Output: {expectedOutput}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("In the FindPairWithSumUnsorted method, the algorithm should handle negative numbers appropriately.");
            Console.WriteLine("   - The method iterates through the array, leading to a time complexity of O(n), where n is the number of elements in the array.");
            Console.WriteLine("==============================");
            Console.WriteLine();

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void ContainsDuplicate_Test()
        {
            // Arrange
            var inputArray = new int[] { 1, 2, 3, 4, 5, 2 };
            var expectedResult = true;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyContainsDuplicate(inputArray);

            // Console Output
            Console.WriteLine("=== Contains Duplicate Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {expectedResult}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity: O(n) - The hash set allows for average O(1) lookups and insertions.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ContainsDuplicate_NoDuplicates_Test()
        {
            // Arrange
            var inputArray = new int[] { 1, 2, 3, 4, 5 };
            var expectedResult = false;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyContainsDuplicate(inputArray);

            // Console Output
            Console.WriteLine("=== Contains Duplicate No Duplicates Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {expectedResult}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity: O(n) - The hash set allows for average O(1) lookups and insertions.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ContainsDuplicate_EmptyArray_Test()
        {
            // Arrange
            var inputArray = new int[] { };
            var expectedResult = false;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyContainsDuplicate(inputArray);

            // Console Output
            Console.WriteLine("=== Contains Duplicate Empty Array Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {expectedResult}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity: O(n) - The hash set allows for average O(1) lookups and insertions.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ContainsDuplicate_SingleElement_Test()
        {
            // Arrange
            var inputArray = new int[] { 1 };
            var expectedResult = false;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyContainsDuplicate(inputArray);

            // Console Output
            Console.WriteLine("=== Contains Duplicate Single Element Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {expectedResult}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity: O(n) - The hash set allows for average O(1) lookups and insertions.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ContainsDuplicate_NegativeNumbers_Test()
        {
            // Arrange
            var inputArray = new int[] { -1, -2, -3, 4, 5, -2 };
            var expectedResult = true;

            // Act
            var result = CSharpCodingDSAlgosExamples.EasyContainsDuplicate(inputArray);

            // Console Output
            Console.WriteLine("=== Contains Duplicate Negative Numbers Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {expectedResult}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity: O(n) - The hash set allows for average O(1) lookups and insertions.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountOccurrences_MultipleDuplicates_Test()
        {
            // Arrange
            var inputArray = new int[] { 1, 2, 2, 3, 3, 3, 4 };
            var expectedResult = new Dictionary<int, int>
            {
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 1 }
            };

            // Act
            var result = CSharpCodingDSAlgosExamples.IntermediateCountOccurrences(inputArray);

            // Console Output
            Console.WriteLine("=== Count Occurrences Multiple Duplicates Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatDictionary(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatDictionary(result)}");
            Console.WriteLine("Time Complexity: O(n) - Each number is processed once, resulting in linear time complexity.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountOccurrences_NoDuplicates_Test()
        {
            // Arrange
            var inputArray = new int[] { 1, 2, 3, 4, 5 };
            var expectedResult = new Dictionary<int, int>
            {
                { 1, 1 },
                { 2, 1 },
                { 3, 1 },
                { 4, 1 },
                { 5, 1 }
            };

            // Act
            var result = CSharpCodingDSAlgosExamples.IntermediateCountOccurrences(inputArray);

            // Console Output
            Console.WriteLine("=== Count Occurrences No Duplicates Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatDictionary(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatDictionary(result)}");
            Console.WriteLine("Time Complexity: O(n) - Each number is processed once, resulting in linear time complexity.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountOccurrences_EmptyArray_Test()
        {
            // Arrange
            var inputArray = new int[] { };
            var expectedResult = new Dictionary<int, int>(); // Empty dictionary expected

            // Act
            var result = CSharpCodingDSAlgosExamples.IntermediateCountOccurrences(inputArray);

            // Console Output
            Console.WriteLine("=== Count Occurrences Empty Array Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatDictionary(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatDictionary(result)}");
            Console.WriteLine("Time Complexity: O(n) - Each number is processed once, resulting in linear time complexity.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountOccurrences_SingleElement_Test()
        {
            // Arrange
            var inputArray = new int[] { 1 };
            var expectedResult = new Dictionary<int, int>
            {
                { 1, 1 }
            };

            // Act
            var result = CSharpCodingDSAlgosExamples.IntermediateCountOccurrences(inputArray);

            // Console Output
            Console.WriteLine("=== Count Occurrences Single Element Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatDictionary(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatDictionary(result)}");
            Console.WriteLine("Time Complexity: O(n) - Each number is processed once, resulting in linear time complexity.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CountOccurrences_NegativeNumbers_Test()
        {
            // Arrange
            var inputArray = new int[] { -1, -2, -2, -3, -1 };
            var expectedResult = new Dictionary<int, int>
            {
                { -1, 2 },
                { -2, 2 },
                { -3, 1 }
            };

            // Act
            var result = CSharpCodingDSAlgosExamples.IntermediateCountOccurrences(inputArray);

            // Console Output
            Console.WriteLine("=== Count Occurrences Negative Numbers Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatDictionary(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatDictionary(result)}");
            Console.WriteLine("Time Complexity: O(n) - Each number is processed once, resulting in linear time complexity.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GroupAnagrams_MultipleAnagrams_Test()
        {
            // Arrange
            var inputArray = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var expectedResult = new List<IList<string>>
            {
                new List<string> { "eat", "tea", "ate" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            } as IList<IList<string>>; // Cast to IList<IList<string>>

            // Act
            var result = CSharpCodingDSAlgosExamples.HardGroupAnagrams(inputArray);

            // Console Output
            Console.WriteLine("=== Group Anagrams Multiple Anagrams Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatNestedList(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatNestedList(result)}");
            Console.WriteLine("Time Complexity: O(n * k log k) - where n is the number of strings and k is the maximum length of a string, due to sorting each string.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GroupAnagrams_NoAnagrams_Test()
        {
            // Arrange
            var inputArray = new string[] { "abc", "def", "ghi" };
            var expectedResult = new List<IList<string>>
            {
                new List<string> { "abc" },
                new List<string> { "def" },
                new List<string> { "ghi" }
            } as IList<IList<string>>; // Cast to IList<IList<string>>

            // Act
            var result = CSharpCodingDSAlgosExamples.HardGroupAnagrams(inputArray);

            // Console Output
            Console.WriteLine("=== Group Anagrams No Anagrams Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatNestedList(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatNestedList(result)}");
            Console.WriteLine("Time Complexity: O(n * k log k) - where n is the number of strings and k is the maximum length of a string, due to sorting each string.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GroupAnagrams_EmptyArray_Test()
        {
            // Arrange
            var inputArray = new string[] { };
            var expectedResult = new List<IList<string>>() as IList<IList<string>>; // Cast to IList<IList<string>>

            // Act
            var result = CSharpCodingDSAlgosExamples.HardGroupAnagrams(inputArray);

            // Console Output
            Console.WriteLine("=== Group Anagrams Empty Array Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatNestedList(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatNestedList(result)}");
            Console.WriteLine("Time Complexity: O(n * k log k) - where n is the number of strings and k is the maximum length of a string, due to sorting each string.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GroupAnagrams_SingleWord_Test()
        {
            // Arrange
            var inputArray = new string[] { "hello" };
            var expectedResult = new List<IList<string>>
            {
                new List<string> { "hello" }
            } as IList<IList<string>>; // Cast to IList<IList<string>>

            // Act
            var result = CSharpCodingDSAlgosExamples.HardGroupAnagrams(inputArray);

            // Console Output
            Console.WriteLine("=== Group Anagrams Single Word Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatNestedList(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatNestedList(result)}");
            Console.WriteLine("Time Complexity: O(n * k log k) - where n is the number of strings and k is the maximum length of a string, due to sorting each string.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GroupAnagrams_MixedCaseAnagrams_Test()
        {
            // Arrange
            var inputArray = new string[] { "Tea", "Eat", "ate", "Ate" };
            var expectedResult = new List<IList<string>>
            {
                new List<string> { "Tea", "Eat", "ate", "Ate" }
            } as IList<IList<string>>; // Cast to IList<IList<string>>

            // Act
            var result = CSharpCodingDSAlgosExamples.HardGroupAnagrams(inputArray);

            // Console Output
            Console.WriteLine("=== Group Anagrams Mixed Case Anagrams Test ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", inputArray)}]");
            Console.WriteLine($"Expected Result: {FormatNestedList(expectedResult)}");
            Console.WriteLine($"Actual Result: {FormatNestedList(result)}");
            Console.WriteLine("Time Complexity: O(n * k log k) - where n is the number of strings and k is the maximum length of a string, due to sorting each string.");
            Console.WriteLine("==================================\n");

            // Assert
            Assert.Equal(expectedResult, result);
        }

        // Utility method for formatting nested list output
        private string FormatNestedList(IList<IList<string>> nestedList)
        {
            return "[" + string.Join(", ", nestedList.Select(innerList => "[" + string.Join(", ", innerList) + "]")) + "]";
        }
        // Utility method for formatting dictionary output
        private string FormatDictionary(Dictionary<int, int> dict)
        {
            return "{" + string.Join(", ", dict.Select(kvp => $"{kvp.Key}: {kvp.Value}")) + "}";
        }

    }
}