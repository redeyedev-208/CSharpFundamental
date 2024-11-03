using Xunit;
using System;

namespace CSharpFundamentals.Tests
{
    public class IntermediateExamplesTests
    {
        // To run tests with more information we can use the following command:
        // dotnet test --logger "console;verbosity=detailed" to run all of the test basic and intermediate
        // We can run these tests exactly for this file like this: dotnet test --filter "FullyQualifiedName~CSharpFundamentals.Tests.IntermediateExamplesTests" --logger "console;verbosity=detailed"
        // This below shows how to run a single test to get what is needed if it is failing
        // dotnet test --logger "console;verbosity=detailed" --filter "FullyQualifiedName~CSharpFundamentals.Tests.IntermediateExamplesTests.FindArrayIntersection_ShouldReturnIntersectionOfTwoArrays"
        [Fact]
        public void FindArrayIntersection_ShouldReturnIntersectionOfTwoArrays()
        {
            // Arrange
            var array1 = new int[] { 1, 2, 3, 4 };
            var array2 = new int[] { 3, 4, 5, 6 };
            var expected = new int[] { 3, 4 };

            // Act 
            var result = IntermediateExamples.FindArrayIntersection(array1, array2);

            // Assert
            Assert.Equal(expected, result);

            // Print result and time complexity to the console
            Console.WriteLine("=== Array Intersection Intermediate Problem Test Results ===");
            Console.WriteLine($"Array 1: [{string.Join(", ", array1)}]");
            Console.WriteLine($"Array 2: [{string.Join(", ", array2)}]");
            Console.WriteLine($"Intersection Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("In the FindArrayIntersection method, we use LINQ’s Intersect method to find common elements between two arrays.");
            Console.WriteLine();
            Console.WriteLine("1. Intersect Operation:");
            Console.WriteLine("   - Intersect iterates over each element in array1 and checks if it exists in array2.");
            Console.WriteLine("   - Since Intersect uses hashing for set-like behavior, checking membership is efficient with average O(1) complexity for each lookup.");
            Console.WriteLine("   - Given that there are n elements in array1 and m in array2, the time complexity is O(n + m) on average, assuming the hash operations are O(1).");
            Console.WriteLine();
            Console.WriteLine("2. Conversion to Array:");
            Console.WriteLine("   - ToArray simply transforms the result into an array format, which is O(k), where k is the size of the intersection.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function is O(n + m), where n and m are the sizes of the two input arrays.");
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.WriteLine();

        }

        [Fact]
        public void FindArrayIntersection_ShouldReturnEmptyArray_WhenNoIntersection()
        {
            Console.WriteLine("\n============== No Intersection Test ====================");
            Console.WriteLine("Array1: [1, 2, 3]");
            Console.WriteLine("Array2: [4, 5, 6]");

            var array1 = new int[] { 1, 2, 3 };
            var array2 = new int[] { 4, 5, 6 };
            var expected = new int[0];

            var result = IntermediateExamples.FindArrayIntersection(array1, array2);
            Console.WriteLine("Expected Intersection: []");
            Console.WriteLine($"Actual Intersection: [{string.Join(", ", result)}]");
            Console.WriteLine("========================================================\n");
            Console.WriteLine();
            Console.WriteLine();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindArrayIntersection_ShouldReturnEmptyArray_WhenOneArrayIsEmpty()
        {
            Console.WriteLine("\n=========== One Array Empty Test =============");
            Console.WriteLine("Array1: []");
            Console.WriteLine("Array2: [1, 2, 3]");

            var array1 = new int[0];
            var array2 = new int[] { 1, 2, 3 };
            var expected = new int[0];

            var result = IntermediateExamples.FindArrayIntersection(array1, array2);
            Console.WriteLine("Expected Intersection: []");
            Console.WriteLine($"Actual Intersection: [{string.Join(", ", result)}]");
            Console.WriteLine("==============================================\n");
            Console.WriteLine();
            Console.WriteLine();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindArrayIntersection_ShouldReturnEmptyArray_WhenBothArraysAreEmpty()
        {
            Console.WriteLine("\n=========== Both Arrays Empty Test =============");
            Console.WriteLine("Array1: []");
            Console.WriteLine("Array2: []");

            var array1 = new int[0];
            var array2 = new int[0];
            var expected = new int[0];

            var result = IntermediateExamples.FindArrayIntersection(array1, array2);
            Console.WriteLine("Expected Intersection: []");
            Console.WriteLine($"Actual Intersection: [{string.Join(", ", result)}]");
            Console.WriteLine("===============================================\n");
            Console.WriteLine();
            Console.WriteLine();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindArrayIntersection_ShouldHandleDuplicateElements()
        {
            Console.WriteLine("\n================ Duplicate Elements Test ==================");
            Console.WriteLine("Array1: [1, 2, 2, 3]");
            Console.WriteLine("Array2: [2, 3, 3, 4]");

            var array1 = new int[] { 1, 2, 2, 3 };
            var array2 = new int[] { 2, 3, 3, 4 };
            var expected = new int[] { 2, 3 };

            var result = IntermediateExamples.FindArrayIntersection(array1, array2);
            Console.WriteLine("Expected Intersection: [2, 3]");
            Console.WriteLine($"Actual Intersection: [{string.Join(", ", result)}]");
            Console.WriteLine("===========================================================\n");
            Console.WriteLine();
            Console.WriteLine();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindArrayIntersection_ShouldReturnSingleElement_WhenArraysHaveOneCommonElement()
        {
            Console.WriteLine("\n============== Single Element Intersection Test =================");
            Console.WriteLine("Array1: [7]");
            Console.WriteLine("Array2: [7]");

            var array1 = new int[] { 7 };
            var array2 = new int[] { 7 };
            var expected = new int[] { 7 };

            var result = IntermediateExamples.FindArrayIntersection(array1, array2);
            Console.WriteLine("Expected Intersection: [7]");
            Console.WriteLine($"Actual Intersection: [{string.Join(", ", result)}]");
            Console.WriteLine("=================================================================\n");
            Console.WriteLine();
            Console.WriteLine();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateFactorial_ShouldReturnOne_WhenInputIsZero()
        {
            // Arrange
            int input = 0;
            int expected = 1;

            // Act
            int result = IntermediateExamples.CalculateFactorial(input);

            // Assert
            Assert.Equal(expected, result);

            // Print result and time complexity to the console
            Console.WriteLine("\n================ Calculate Factorial Test =================");
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Expected Result: {expected}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The CalculateFactorial method uses a simple recursive approach.");
            Console.WriteLine("2. Base Case: For input 0, it returns 1 (0! = 1). This is O(1).");
            Console.WriteLine("3. Recursive Case: For n > 0, it computes n * Factorial(n - 1), making the time complexity O(n) in total.");
            Console.WriteLine("Overall, the time complexity of this function is O(n).");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void CalculateFactorial_ShouldReturnFactorial_WhenInputIsPositive()
        {
            // Arrange
            int input = 5;
            int expected = 120; // 5! = 120

            // Act
            int result = IntermediateExamples.CalculateFactorial(input);

            // Assert
            Assert.Equal(expected, result);

            // Print result and time complexity to the console
            Console.WriteLine("\n================ Calculate Factorial Test =================");
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Expected Result: {expected}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The CalculateFactorial method calculates 5! by multiplying 5 * 4 * 3 * 2 * 1.");
            Console.WriteLine("2. Each multiplication is a simple arithmetic operation.");
            Console.WriteLine("3. The overall time complexity is O(n), where n is the input value.");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void CalculateFactorial_ShouldThrowArgumentException_WhenInputIsNegative()
        {
            // Arrange
            int input = -1;

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => IntermediateExamples.CalculateFactorial(input));
            Assert.Equal("Number must be a non-negative number.", exception.Message);

            // Print exception details to the console
            Console.WriteLine("\n================ Negative Input Test =================");
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Caught Exception: {exception.Message}");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void CalculateFactorial_ShouldHandleLargeNumbers()
        {
            // Arrange
            int input = 10;
            int expected = 3628800; // 10! = 3628800

            // Act
            int result = IntermediateExamples.CalculateFactorial(input);

            // Assert
            Assert.Equal(expected, result);

            // Print result and time complexity to the console
            Console.WriteLine("\n================ Calculate Factorial Test =================");
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Expected Result: {expected}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. For input 10, the method calculates 10! = 10 * 9 * ... * 1.");
            Console.WriteLine("2. This involves 10 multiplications, resulting in a time complexity of O(n).");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void CalculateFactorial_ShouldReturnOne_WhenInputIsOne()
        {
            // Arrange
            int input = 1;
            int expected = 1; // 1! = 1

            // Act
            int result = IntermediateExamples.CalculateFactorial(input);

            // Assert
            Assert.Equal(expected, result);

            // Print result and time complexity to the console
            Console.WriteLine("\n================ Calculate Factorial Test =================");
            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Expected Result: {expected}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. For input 1, the method directly returns 1.");
            Console.WriteLine("2. The time complexity is O(1) for this base case.");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void IsArraySorted_ShouldReturnTrue_WhenArrayIsSorted()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };

            // Act
            bool result = IntermediateExamples.IsArraySorted(input);

            // Assert
            Assert.True(result);

            // Print result to the console
            Console.WriteLine("\n================ Array Sorted Test =================");
            Console.WriteLine($"Input: [{string.Join(", ", input)}]");
            Console.WriteLine($"Is Array Sorted: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method iterates through the array once.");
            Console.WriteLine("2. The time complexity is O(n), where n is the number of elements in the array.");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void IsArraySorted_ShouldReturnFalse_WhenArrayIsNotSorted()
        {
            // Arrange
            int[] input = { 1, 3, 2, 4, 5 };

            // Act
            bool result = IntermediateExamples.IsArraySorted(input);

            // Assert
            Assert.False(result);

            // Print result to the console
            Console.WriteLine("\n================ Array Not Sorted Test =================");
            Console.WriteLine($"Input: [{string.Join(", ", input)}]");
            Console.WriteLine($"Is Array Sorted: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method finds an unsorted pair (3 > 2) and returns false.");
            Console.WriteLine("2. The time complexity remains O(n) for the traversal.");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void IsArraySorted_ShouldReturnTrue_WhenArrayIsEmpty()
        {
            // Arrange
            int[] input = { };

            // Act
            bool result = IntermediateExamples.IsArraySorted(input);

            // Assert
            Assert.True(result);

            // Print result to the console
            Console.WriteLine("\n================ Empty Array Test =================");
            Console.WriteLine($"Input: []");
            Console.WriteLine($"Is Array Sorted: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. An empty array is considered sorted.");
            Console.WriteLine("2. The time complexity is O(1) since no elements are checked.");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void IsArraySorted_ShouldReturnTrue_WhenArrayHasOneElement()
        {
            // Arrange
            int[] input = { 42 };

            // Act
            bool result = IntermediateExamples.IsArraySorted(input);

            // Assert
            Assert.True(result);

            // Print result to the console
            Console.WriteLine("\n================ Single Element Array Test =================");
            Console.WriteLine($"Input: [{string.Join(", ", input)}]");
            Console.WriteLine($"Is Array Sorted: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. An array with a single element is trivially sorted.");
            Console.WriteLine("2. The time complexity is O(1) since no comparisons are made.");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void IsArraySorted_ShouldReturnTrue_WhenArrayContainsIdenticalElements()
        {
            // Arrange
            int[] input = { 7, 7, 7, 7, 7 };

            // Act
            bool result = IntermediateExamples.IsArraySorted(input);

            // Assert
            Assert.True(result);

            // Print result to the console
            Console.WriteLine("\n================ Identical Elements Array Test =================");
            Console.WriteLine($"Input: [{string.Join(", ", input)}]");
            Console.WriteLine($"Is Array Sorted: {result}");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Identical elements are sorted by definition.");
            Console.WriteLine("2. The time complexity remains O(n) for the traversal.");
            Console.WriteLine("===========================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void RemoveVowels_ShouldRemoveVowelsFromInputString()
        {
            // Arrange
            string input = "Hello World!";
            string expected = "Hll Wrld!";

            // Act
            string result = IntermediateExamples.RemoveVowels(input);

            // Assert
            Assert.Equal(expected, result);

            // Print result and time complexity to the console
            Console.WriteLine("=== Remove Vowels Test Results ===");
            Console.WriteLine($"Input String: \"{input}\"");
            Console.WriteLine($"Expected Result: \"{expected}\"");
            Console.WriteLine($"Actual Result: \"{result}\"");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("The RemoveVowels method iterates through each character of the input string.");
            Console.WriteLine();
            Console.WriteLine("1. Input Processing:");
            Console.WriteLine("   - The method performs a linear scan of the input string, checking each character.");
            Console.WriteLine("   - This results in O(n) time complexity, where n is the length of the input string.");
            Console.WriteLine();
            Console.WriteLine("2. String Construction:");
            Console.WriteLine("   - A new string is created from the characters that are not vowels.");
            Console.WriteLine("   - Constructing a new string from an array of characters is also O(n) in complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function is O(n), making it efficient for vowel removal.");
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void RemoveVowels_ShouldReturnEmptyString_WhenInputIsAllVowels()
        {
            // Arrange
            string input = "aeiou";
            string expected = "";

            // Act
            string result = IntermediateExamples.RemoveVowels(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input String: \"{input}\"");
            Console.WriteLine($"Expected Result: \"{expected}\"");
            Console.WriteLine($"Actual Result: \"{result}\"");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void RemoveVowels_ShouldReturnSameString_WhenInputHasNoVowels()
        {
            // Arrange
            string input = "Hll Wrd!";
            string expected = "Hll Wrd!";

            // Act
            string result = IntermediateExamples.RemoveVowels(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input String: \"{input}\"");
            Console.WriteLine($"Expected Result: \"{expected}\"");
            Console.WriteLine($"Actual Result: \"{result}\"");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void RemoveVowels_ShouldReturnEmptyString_WhenInputIsEmpty()
        {
            // Arrange
            string input = "";
            string expected = "";

            // Act
            string result = IntermediateExamples.RemoveVowels(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input String: \"{input}\"");
            Console.WriteLine($"Expected Result: \"{expected}\"");
            Console.WriteLine($"Actual Result: \"{result}\"");
            Console.WriteLine();
            Console.WriteLine();
        }

        [Fact]
        public void SumOfSquares_WithPositiveIntegers_ReturnsCorrectSum()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4 };
            int expected = 30; // 1^2 + 2^2 + 3^2 + 4^2 = 30

            // Act
            int result = IntermediateExamples.SumOfSquares(input); // Reference the method from MathUtilities

            // Assert
            Assert.Equal(expected, result);

            // Print result and time complexity to the console
            Console.WriteLine("=== Sum Of Squares Test Results ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: {expected}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Input Processing:");
            Console.WriteLine("   - The method iterates through each element of the input array, squaring each one.");
            Console.WriteLine("   - This results in O(n) time complexity, where n is the number of elements in the input array.");
            Console.WriteLine();
            Console.WriteLine("2. Summation:");
            Console.WriteLine("   - The summation of squares is performed in a single pass.");
            Console.WriteLine("   - Therefore, the overall complexity remains O(n).");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function is O(n), making it efficient for calculating the sum of squares.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void SumOfSquares_WithNegativeIntegers_ReturnsCorrectSum()
        {
            // Arrange
            int[] input = { -1, -2, -3, -4 };
            int expected = 30; // (-1)^2 + (-2)^2 + (-3)^2 + (-4)^2 = 30

            // Act
            int result = IntermediateExamples.SumOfSquares(input); // Reference the method from MathUtilities

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: {expected}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine();
        }

        [Fact]
        public void SumOfSquares_WithEmptyArray_ReturnsZero()
        {
            // Arrange
            int[] input = { };
            int expected = 0; // No elements to square

            // Act
            int result = IntermediateExamples.SumOfSquares(input); // Reference the method from MathUtilities

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: {expected}");
            Console.WriteLine($"Actual Result: {result}");
            Console.WriteLine();
        }

        [Fact]
        public void SumOfSquares_WithMaxIntegers_ThrowsOverflowException()
        {
            // Arrange
            int[] input = { int.MaxValue }; // Adjusted for clarity

            // Act & Assert
            var exception = Assert.Throws<OverflowException>(() => IntermediateExamples.SumOfSquares(input));
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Exception: {exception.Message}");
        }
    }
}
