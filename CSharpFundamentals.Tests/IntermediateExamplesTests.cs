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

        [Fact]
        public void GenerateFibonacci_WithZero_ReturnsEmptyArray()
        {
            // Arrange
            int n = 0;
            int[] expected = { }; // No Fibonacci numbers

            // Act
            int[] result = IntermediateExamples.GenerateFibonacci(n);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input: {n}");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method directly returns an empty array for n <= 0.");
            Console.WriteLine("   - This results in O(1) time complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for n = 0 is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void GenerateFibonacci_WithNegativeInput_ReturnsEmptyArray()
        {
            // Arrange
            int n = -5;
            int[] expected = { }; // No Fibonacci numbers

            // Act
            int[] result = IntermediateExamples.GenerateFibonacci(n);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input: {n}");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method directly returns an empty array for n <= 0.");
            Console.WriteLine("   - This results in O(1) time complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for n < 0 is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void GenerateFibonacci_WithOne_ReturnsZero()
        {
            // Arrange
            int n = 1;
            int[] expected = { 0 }; // First Fibonacci number

            // Act
            int[] result = IntermediateExamples.GenerateFibonacci(n);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input: {n}");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method initializes the first Fibonacci number (0) and returns it.");
            Console.WriteLine("   - This results in O(1) time complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for n = 1 is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void GenerateFibonacci_WithTwo_ReturnsFirstTwoFibonacciNumbers()
        {
            // Arrange
            int n = 2;
            int[] expected = { 0, 1 }; // First two Fibonacci numbers

            // Act
            int[] result = IntermediateExamples.GenerateFibonacci(n);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input: {n}");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method initializes the first two Fibonacci numbers (0 and 1) and returns them.");
            Console.WriteLine("   - This results in O(1) time complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for n = 2 is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void GenerateFibonacci_WithFive_ReturnsFirstFiveFibonacciNumbers()
        {
            // Arrange
            int n = 5;
            int[] expected = { 0, 1, 1, 2, 3 }; // First five Fibonacci numbers

            // Act
            int[] result = IntermediateExamples.GenerateFibonacci(n);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input: {n}");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method fills the array using the relation fib[i] = fib[i - 1] + fib[i - 2].");
            Console.WriteLine("   - This results in O(n) time complexity, where n is the input value.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for n = 5 is O(n).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AreAnagrams_WithIdenticalStrings_ReturnsTrue()
        {
            // Arrange
            string str1 = "listen";
            string str2 = "listen";

            // Act
            bool result = IntermediateExamples.AreAnagrams(str1, str2);

            // Assert
            Assert.True(result);

            // Print results to console
            Console.WriteLine($"Input Strings: \"{str1}\" and \"{str2}\"");
            Console.WriteLine($"Are Anagrams: {result}");
            Console.WriteLine("Explanation: Both strings are identical, hence they are anagrams.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AreAnagrams_WithAnagramStrings_ReturnsTrue()
        {
            // Arrange
            string str1 = "listen";
            string str2 = "silent";

            // Act
            bool result = IntermediateExamples.AreAnagrams(str1, str2);

            // Assert
            Assert.True(result);

            // Print results to console
            Console.WriteLine($"Input Strings: \"{str1}\" and \"{str2}\"");
            Console.WriteLine($"Are Anagrams: {result}");
            Console.WriteLine("Explanation: Both strings are anagrams of each other.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AreAnagrams_WithDifferentLengthStrings_ReturnsFalse()
        {
            // Arrange
            string str1 = "abc";
            string str2 = "ab";

            // Act
            bool result = IntermediateExamples.AreAnagrams(str1, str2);

            // Assert
            Assert.False(result);

            // Print results to console
            Console.WriteLine($"Input Strings: \"{str1}\" and \"{str2}\"");
            Console.WriteLine($"Are Anagrams: {result}");
            Console.WriteLine("Explanation: Strings have different lengths, hence they cannot be anagrams.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AreAnagrams_WithNonAnagramStrings_ReturnsFalse()
        {
            // Arrange
            string str1 = "hello";
            string str2 = "world";

            // Act
            bool result = IntermediateExamples.AreAnagrams(str1, str2);

            // Assert
            Assert.False(result);

            // Print results to console
            Console.WriteLine($"Input Strings: \"{str1}\" and \"{str2}\"");
            Console.WriteLine($"Are Anagrams: {result}");
            Console.WriteLine("Explanation: Both strings do not have the same characters.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AreAnagrams_WithEmptyStrings_ReturnsTrue()
        {
            // Arrange
            string str1 = "";
            string str2 = "";

            // Act
            bool result = IntermediateExamples.AreAnagrams(str1, str2);

            // Assert
            Assert.True(result);

            // Print results to console
            Console.WriteLine($"Input Strings: \"{str1}\" and \"{str2}\"");
            Console.WriteLine($"Are Anagrams: {result}");
            Console.WriteLine("Explanation: Both strings are empty, hence they are anagrams.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AreAnagrams_WithWhitespace_ReturnsFalse()
        {
            // Arrange
            string str1 = "a b c";
            string str2 = "abc";

            // Act
            bool result = IntermediateExamples.AreAnagrams(str1, str2);

            // Assert
            Assert.False(result);

            // Print results to console
            Console.WriteLine($"Input Strings: \"{str1}\" and \"{str2}\"");
            Console.WriteLine($"Are Anagrams: {result}");
            Console.WriteLine("Explanation: Whitespace affects the anagram status.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AreAnagrams_WithCaseInsensitivity_ReturnsTrue()
        {
            // Arrange
            string str1 = "Listen";
            string str2 = "Silent";

            // Act
            bool result = IntermediateExamples.AreAnagrams(str1.ToLower(), str2.ToLower());

            // Assert
            Assert.True(result);

            // Print results to console
            Console.WriteLine($"Input Strings: \"{str1}\" and \"{str2}\" (case insensitive)");
            Console.WriteLine($"Are Anagrams: {result}");
            Console.WriteLine("Explanation: Both strings are anagrams of each other when case is ignored.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LongestCommonPrefix_WithCommonPrefix_ReturnsCorrectPrefix()
        {
            // Arrange
            string[] strs = { "flower", "flow", "flight" };
            string expected = "fl";

            // Act
            string result = IntermediateExamples.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Strings: [{string.Join(", ", strs)}]");
            Console.WriteLine($"Expected Prefix: \"{expected}\"");
            Console.WriteLine($"Actual Prefix: \"{result}\"");
            Console.WriteLine("Explanation: The longest common prefix among the given strings is \"fl\".");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LongestCommonPrefix_WithNoCommonPrefix_ReturnsEmptyString()
        {
            // Arrange
            string[] strs = { "dog", "racecar", "car" };
            string expected = "";

            // Act
            string result = IntermediateExamples.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Strings: [{string.Join(", ", strs)}]");
            Console.WriteLine($"Expected Prefix: \"{expected}\"");
            Console.WriteLine($"Actual Prefix: \"{result}\"");
            Console.WriteLine("Explanation: There is no common prefix among the given strings.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LongestCommonPrefix_WithSingleString_ReturnsSameString()
        {
            // Arrange
            string[] strs = { "hello" };
            string expected = "hello";

            // Act
            string result = IntermediateExamples.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Strings: [{string.Join(", ", strs)}]");
            Console.WriteLine($"Expected Prefix: \"{expected}\"");
            Console.WriteLine($"Actual Prefix: \"{result}\"");
            Console.WriteLine("Explanation: With a single string, the longest common prefix is the string itself.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LongestCommonPrefix_WithEmptyArray_ReturnsEmptyString()
        {
            // Arrange
            string[] strs = { };
            string expected = "";

            // Act
            string result = IntermediateExamples.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Strings: [{string.Join(", ", strs)}]");
            Console.WriteLine($"Expected Prefix: \"{expected}\"");
            Console.WriteLine($"Actual Prefix: \"{result}\"");
            Console.WriteLine("Explanation: An empty array returns an empty string as there are no strings to compare.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LongestCommonPrefix_WithAllEmptyStrings_ReturnsEmptyString()
        {
            // Arrange
            string[] strs = { "", "", "" };
            string expected = "";

            // Act
            string result = IntermediateExamples.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Strings: [{string.Join(", ", strs)}]");
            Console.WriteLine($"Expected Prefix: \"{expected}\"");
            Console.WriteLine($"Actual Prefix: \"{result}\"");
            Console.WriteLine("Explanation: All strings are empty, so the longest common prefix is also empty.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LongestCommonPrefix_WithDifferentCase_ReturnsCommonPrefix()
        {
            // Arrange
            string[] strs = { "Flower", "flow", "Flight" };
            string expected = "Fl"; // Case-sensitive prefix

            // Act
            string result = IntermediateExamples.LongestCommonPrefix(strs);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Strings: [{string.Join(", ", strs)}]");
            Console.WriteLine($"Expected Prefix: \"{expected}\"");
            Console.WriteLine($"Actual Prefix: \"{result}\"");
            Console.WriteLine("Explanation: The longest common prefix is case-sensitive and returns \"Fl\".");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void BinarySearch_WithExistingElement_ReturnsCorrectIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int target = 3;
            int expected = 2; // Index of the target

            // Act
            int result = IntermediateExamples.BinarySearch(array, target);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Binary Search Test: Existing Element ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine($"Expected Index: {expected}");
            Console.WriteLine($"Actual Index: {result}");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The binary search algorithm divides the search interval in half.");
            Console.WriteLine("2. This results in a time complexity of O(log n).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void BinarySearch_WithNonExistingElement_ReturnsNegativeOne()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int target = 6; // Not in the array
            int expected = -1; // Target not found

            // Act
            int result = IntermediateExamples.BinarySearch(array, target);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Binary Search Test: Non-Existing Element ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine($"Expected Index: {expected}");
            Console.WriteLine($"Actual Index: {result}");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void BinarySearch_WithEmptyArray_ReturnsNegativeOne()
        {
            // Arrange
            int[] array = { };
            int target = 1;
            int expected = -1; // Target not found

            // Act
            int result = IntermediateExamples.BinarySearch(array, target);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Binary Search Test: Empty Array ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine($"Expected Index: {expected}");
            Console.WriteLine($"Actual Index: {result}");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void BinarySearch_WithSingleElementArray_ReturnsCorrectIndex()
        {
            // Arrange
            int[] array = { 42 };
            int target = 42; // The only element
            int expected = 0; // Index of the target

            // Act
            int result = IntermediateExamples.BinarySearch(array, target);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Binary Search Test: Single Element Array ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine($"Expected Index: {expected}");
            Console.WriteLine($"Actual Index: {result}");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void BinarySearch_WithTargetAtStart_ReturnsZero()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int target = 1; // The first element
            int expected = 0; // Index of the target

            // Act
            int result = IntermediateExamples.BinarySearch(array, target);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Binary Search Test: Target At Start ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine($"Expected Index: {expected}");
            Console.WriteLine($"Actual Index: {result}");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void BinarySearch_WithTargetAtEnd_ReturnsLastIndex()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int target = 5; // The last element
            int expected = 4; // Index of the target

            // Act
            int result = IntermediateExamples.BinarySearch(array, target);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Binary Search Test: Target At End ===");
            Console.WriteLine($"Input Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Target: {target}");
            Console.WriteLine($"Expected Index: {expected}");
            Console.WriteLine($"Actual Index: {result}");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSortedArrays_WithBothNonEmptyArrays_ReturnsMergedSortedArray()
        {
            // Arrange
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2, 4, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            // Act
            int[] result = IntermediateExamples.MergeSortedArrays(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Merge Sorted Arrays Test: Both Non-Empty ===");
            Console.WriteLine($"Array 1: [{string.Join(", ", arr1)}]");
            Console.WriteLine($"Array 2: [{string.Join(", ", arr2)}]");
            Console.WriteLine($"Expected Merged Array: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Merged Array: [{string.Join(", ", result)}]");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSortedArrays_WithFirstArrayEmpty_ReturnsSecondArray()
        {
            // Arrange
            int[] arr1 = { };
            int[] arr2 = { 2, 4, 6 };
            int[] expected = { 2, 4, 6 };

            // Act
            int[] result = IntermediateExamples.MergeSortedArrays(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Merge Sorted Arrays Test: First Array Empty ===");
            Console.WriteLine($"Array 1: [{string.Join(", ", arr1)}]");
            Console.WriteLine($"Array 2: [{string.Join(", ", arr2)}]");
            Console.WriteLine($"Expected Merged Array: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Merged Array: [{string.Join(", ", result)}]");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSortedArrays_WithSecondArrayEmpty_ReturnsFirstArray()
        {
            // Arrange
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { };
            int[] expected = { 1, 3, 5 };

            // Act
            int[] result = IntermediateExamples.MergeSortedArrays(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Merge Sorted Arrays Test: Second Array Empty ===");
            Console.WriteLine($"Array 1: [{string.Join(", ", arr1)}]");
            Console.WriteLine($"Array 2: [{string.Join(", ", arr2)}]");
            Console.WriteLine($"Expected Merged Array: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Merged Array: [{string.Join(", ", result)}]");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSortedArrays_WithIdenticalElements_ReturnsMergedArray()
        {
            // Arrange
            int[] arr1 = { 1, 1, 1 };
            int[] arr2 = { 1, 1, 1 };
            int[] expected = { 1, 1, 1, 1, 1, 1 };

            // Act
            int[] result = IntermediateExamples.MergeSortedArrays(arr1, arr2);

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Merge Sorted Arrays Test: Identical Elements ===");
            Console.WriteLine($"Array 1: [{string.Join(", ", arr1)}]");
            Console.WriteLine($"Array 2: [{string.Join(", ", arr2)}]");
            Console.WriteLine($"Expected Merged Array: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Merged Array: [{string.Join(", ", result)}]");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSortedArrays_WithReverseOrderArrays_ReturnsMergedSortedArray()
        {
            // Arrange
            int[] arr1 = { 5, 3, 1 };
            int[] arr2 = { 6, 4, 2 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            // Act
            int[] result = IntermediateExamples.MergeSortedArrays(arr1.OrderBy(x => x).ToArray(), arr2.OrderBy(x => x).ToArray());

            // Assert
            Assert.Equal(expected, result);

            // Print results
            Console.WriteLine("=== Merge Sorted Arrays Test: Reverse Order Arrays ===");
            Console.WriteLine($"Array 1 (Reversed): [{string.Join(", ", arr1)}]");
            Console.WriteLine($"Array 2 (Reversed): [{string.Join(", ", arr2)}]");
            Console.WriteLine($"Expected Merged Array: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Merged Array: [{string.Join(", ", result)}]");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void QuickSort_WithSingleElement_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 1 };
            int[] expected = { 1 };

            // Act
            int[] result = IntermediateExamples.QuickSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method returns the input array directly as it has one element.");
            Console.WriteLine("   - This results in O(1) time complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for an array of size 1 is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void QuickSort_WithEmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            // Act
            int[] result = IntermediateExamples.QuickSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method directly returns an empty array.");
            Console.WriteLine("   - This results in O(1) time complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for an empty array is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void QuickSort_WithAlreadySortedArray_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = IntermediateExamples.QuickSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method partitions the array around the pivot without changes.");
            Console.WriteLine("   - The average time complexity is O(n log n).");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for an already sorted array is O(n log n).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void QuickSort_WithReverseSortedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = IntermediateExamples.QuickSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method will require multiple partitions until sorted.");
            Console.WriteLine("   - This results in O(n^2) in the worst case, as all elements are in reverse order.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for a reverse sorted array is O(n^2).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void QuickSort_WithUnorderedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 3, 6, 8, 10, 1, 2, 1 };
            int[] expected = { 1, 1, 2, 3, 6, 8, 10 };

            // Act
            int[] result = IntermediateExamples.QuickSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method will perform partitioning and recursive calls.");
            Console.WriteLine("   - This results in O(n log n) on average for random data.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for an unordered array is O(n log n).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSort_WithSingleElement_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 1 };
            int[] expected = { 1 };

            // Act
            int[] result = IntermediateExamples.MergeSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method returns the input array directly as it has one element.");
            Console.WriteLine("   - This results in O(1) time complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for an array of size 1 is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSort_WithEmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            // Act
            int[] result = IntermediateExamples.MergeSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method directly returns an empty array.");
            Console.WriteLine("   - This results in O(1) time complexity.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for an empty array is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSort_WithAlreadySortedArray_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = IntermediateExamples.MergeSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method divides and merges without needing to reorder elements.");
            Console.WriteLine("   - This results in O(n log n) time complexity in all cases.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for an already sorted array is O(n log n).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSort_WithReverseSortedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = IntermediateExamples.MergeSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method will require full merging across the partitions.");
            Console.WriteLine("   - This results in O(n log n) time complexity, regardless of initial order.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for a reverse sorted array is O(n log n).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSort_WithUnorderedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 3, 6, 8, 10, 1, 2, 1 };
            int[] expected = { 1, 1, 2, 3, 6, 8, 10 };

            // Act
            int[] result = IntermediateExamples.MergeSort(input);

            // Assert
            Assert.Equal(expected, result);

            // Print results to console
            Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
            Console.WriteLine($"Expected Result: [{string.Join(", ", expected)}]");
            Console.WriteLine($"Actual Result: [{string.Join(", ", result)}]");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The method effectively divides and merges unordered segments.");
            Console.WriteLine("   - This results in O(n log n) on average for random data.");
            Console.WriteLine();
            Console.WriteLine("Overall, the time complexity of this function for an unordered array is O(n log n).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void MergeSort_WithTwoElementsSorted_ReturnsSameArray()
        {
            int[] input = { 1, 2 };
            int[] expected = { 1, 2 };

            int[] result = IntermediateExamples.MergeSort(input);

            Assert.Equal(expected, result);
            Console.WriteLine("Tested already sorted two-element array to validate minimal merge operation.");
        }

        [Fact]
        public void MergeSort_WithTwoElementsUnsorted_ReturnsSortedArray()
        {
            int[] input = { 2, 1 };
            int[] expected = { 1, 2 };

            int[] result = IntermediateExamples.MergeSort(input);

            Assert.Equal(expected, result);
            Console.WriteLine("Tested unsorted two-element array to validate basic merge sorting.");
        }

        [Fact]
        public void MergeSort_WithMultipleElements_ReturnsSortedArray()
        {
            int[] input = { 3, 5, 1, 4, 2 };
            int[] expected = { 1, 2, 3, 4, 5 };

            int[] result = IntermediateExamples.MergeSort(input);

            Assert.Equal(expected, result);
            Console.WriteLine("Tested multi-element array, verifying merging and sorting.");
        }

        [Fact]
        public void MergeSort_WithArrayContainingDuplicates_ReturnsSortedArray()
        {
            int[] input = { 4, 2, 2, 3, 4, 1 };
            int[] expected = { 1, 2, 2, 3, 4, 4 };

            int[] result = IntermediateExamples.MergeSort(input);

            Assert.Equal(expected, result);
            Console.WriteLine("Tested array with duplicates, confirming correct handling during merge.");
        }

        [Fact]
        public void MergeSort_WithAllElementsSame_ReturnsSameArray()
        {
            int[] input = { 2, 2, 2, 2, 2 };
            int[] expected = { 2, 2, 2, 2, 2 };

            int[] result = IntermediateExamples.MergeSort(input);

            Assert.Equal(expected, result);
            Console.WriteLine("Tested array where all elements are identical to verify stability and order preservation.");
        }


        [Fact]
        public void Push_AddsElementToStack()
        {
            var stack = new IntermediateExamples.Stack<int>(); // Full namespace reference
            stack.Push(10);

            Assert.False(stack.IsEmpty());

            // Print results to console
            Console.WriteLine("Test: Push_AddsElementToStack");
            Console.WriteLine("Pushed Element: 10");
            Console.WriteLine("Expected: Stack is not empty");
            Console.WriteLine("Actual: Stack is not empty - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The Push operation adds an element to the top of the stack, which is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void Pop_RemovesAndReturnsLastElement()
        {
            var stack = new IntermediateExamples.Stack<int>(); // Full namespace reference
            stack.Push(10);
            stack.Push(20);

            int result = stack.Pop();

            Assert.Equal(20, result);

            // Print results to console
            Console.WriteLine("Test: Pop_RemovesAndReturnsLastElement");
            Console.WriteLine("Pushed Elements: 10, 20");
            Console.WriteLine("Popped Element: 20");
            Console.WriteLine("Expected Result: 20");
            Console.WriteLine($"Actual Result: {result} - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The Pop operation removes the last element, which is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new IntermediateExamples.Stack<int>(); // Full namespace reference

            var exception = Assert.Throws<InvalidOperationException>(() => stack.Pop());

            // Print results to console
            Console.WriteLine("Test: Pop_EmptyStack_ThrowsInvalidOperationException");
            Console.WriteLine("Attempted Pop on an Empty Stack");
            Console.WriteLine("Expected Exception: InvalidOperationException");
            Console.WriteLine($"Actual Exception: {exception.GetType().Name} - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Checking if the stack is empty and throwing an exception is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void IsEmpty_OnNewStack_ReturnsTrue()
        {
            var stack = new IntermediateExamples.Stack<int>(); // Full namespace reference

            Assert.True(stack.IsEmpty()); // Using IsEmpty method

            // Print results to console
            Console.WriteLine("Test: IsEmpty_OnNewStack_ReturnsTrue");
            Console.WriteLine("Expected: Stack is empty");
            Console.WriteLine("Actual: Stack is empty - Test Passed");
            Console.WriteLine("Explanation: 'Stack<int>' in .NET does not have an 'IsEmpty' method, so we use 'stack.Count == 0' to check for emptiness.");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Checking if the stack is empty by evaluating count is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void IsEmpty_AfterPushAndPop_ReturnsTrue()
        {
            var stack = new IntermediateExamples.Stack<int>(); // Full namespace reference
            stack.Push(10);
            stack.Pop();

            Assert.True(stack.IsEmpty()); // Using IsEmpty method

            // Print results to console
            Console.WriteLine("Test: IsEmpty_AfterPushAndPop_ReturnsTrue");
            Console.WriteLine("Pushed and then Popped Element: 10");
            Console.WriteLine("Expected: Stack is empty after Pop");
            Console.WriteLine("Actual: Stack is empty - Test Passed");
            Console.WriteLine("Explanation: 'Stack<int>' in .NET does not have an 'IsEmpty' method, so we use 'stack.Count == 0' to check for emptiness.");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Push and Pop operations are both O(1), and checking if empty is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void Pop_OnStackWithMultipleElements_RemovesElementsInLIFOOrder()
        {
            var stack = new IntermediateExamples.Stack<int>(); // Full namespace reference
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Assert.Equal(30, stack.Pop());
            Assert.Equal(20, stack.Pop());
            Assert.Equal(10, stack.Pop());
            Assert.True(stack.IsEmpty()); // Using IsEmpty method

            // Print results to console
            Console.WriteLine("Test: Pop_OnStackWithMultipleElements_RemovesElementsInLIFOOrder");
            Console.WriteLine("Pushed Elements: 10, 20, 30");
            Console.WriteLine("Expected Pop Sequence: 30, 20, 10");
            Console.WriteLine("Actual Pop Sequence: 30, 20, 10 - Test Passed");
            Console.WriteLine("Explanation: 'Stack<int>' in .NET does not have an 'IsEmpty' method, so we use 'stack.Count == 0' to check for emptiness.");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Each Pop operation is O(1), regardless of stack size, due to LIFO.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void Enqueue_AddsElementToQueue()
        {
            var queue = new IntermediateExamples.Queue<int>();
            queue.Enqueue(10);

            Assert.False(queue.IsEmpty());

            // Print results to console
            Console.WriteLine("Test: Enqueue_AddsElementToQueue");
            Console.WriteLine("Enqueued Element: 10");
            Console.WriteLine("Expected: Queue is not empty");
            Console.WriteLine("Actual: Queue is not empty - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The Enqueue operation adds an element to the end of the queue, which is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void Dequeue_RemovesAndReturnsFirstElement()
        {
            var queue = new IntermediateExamples.Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);

            int result = queue.Dequeue();

            Assert.Equal(10, result);

            // Print results to console
            Console.WriteLine("Test: Dequeue_RemovesAndReturnsFirstElement");
            Console.WriteLine("Enqueued Elements: 10, 20");
            Console.WriteLine("Dequeued Element: 10");
            Console.WriteLine("Expected Result: 10");
            Console.WriteLine($"Actual Result: {result} - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. The Dequeue operation removes the first element, which is O(n) due to the list reindexing.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void Dequeue_EmptyQueue_ThrowsInvalidOperationException()
        {
            var queue = new IntermediateExamples.Queue<int>();

            var exception = Assert.Throws<InvalidOperationException>(() => queue.Dequeue());

            // Print results to console
            Console.WriteLine("Test: Dequeue_EmptyQueue_ThrowsInvalidOperationException");
            Console.WriteLine("Attempted Dequeue on an Empty Queue");
            Console.WriteLine("Expected Exception: InvalidOperationException");
            Console.WriteLine($"Actual Exception: {exception.GetType().Name} - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Checking if the queue is empty and throwing an exception is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void IsEmpty_OnNewQueue_ReturnsTrue()
        {
            var queue = new IntermediateExamples.Queue<int>();

            Assert.True(queue.IsEmpty());

            // Print results to console
            Console.WriteLine("Test: IsEmpty_OnNewQueue_ReturnsTrue");
            Console.WriteLine("Expected: Queue is empty");
            Console.WriteLine("Actual: Queue is empty - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Checking if the queue is empty by evaluating isEmpty is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void IsEmpty_AfterEnqueueAndDequeue_ReturnsTrue()
        {
            var queue = new IntermediateExamples.Queue<int>();
            queue.Enqueue(10);
            queue.Dequeue();

            Assert.True(queue.IsEmpty());

            // Print results to console
            Console.WriteLine("Test: IsEmpty_AfterEnqueueAndDequeue_ReturnsTrue");
            Console.WriteLine("Enqueued and then Dequeued Element: 10");
            Console.WriteLine("Expected: Queue is empty after Dequeue");
            Console.WriteLine("Actual: Queue is empty - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Enqueue and Dequeue operations are O(1) and checking if empty is O(1).");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void Dequeue_OnQueueWithMultipleElements_RemovesElementsInFIFOOrder()
        {
            var queue = new IntermediateExamples.Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Assert.Equal(10, queue.Dequeue());
            Assert.Equal(20, queue.Dequeue());
            Assert.Equal(30, queue.Dequeue());
            Assert.True(queue.IsEmpty());

            // Print results to console
            Console.WriteLine("Test: Dequeue_OnQueueWithMultipleElements_RemovesElementsInFIFOOrder");
            Console.WriteLine("Enqueued Elements: 10, 20, 30");
            Console.WriteLine("Expected Dequeue Sequence: 10, 20, 30");
            Console.WriteLine("Actual Dequeue Sequence: 10, 20, 30 - Test Passed");
            Console.WriteLine("Time Complexity Analysis:");
            Console.WriteLine("1. Each Dequeue operation is O(n) due to list reindexing, but logically maintains FIFO.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LengthOfLongestSubstring_EmptyString_ReturnsZero()
        {
            // Arrange
            string input = "";

            // Act
            int result = IntermediateExamples.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(0, result);

            // Print results to console
            Console.WriteLine("Test: LengthOfLongestSubstring_EmptyString_ReturnsZero");
            Console.WriteLine("Input: Empty String");
            Console.WriteLine("Expected Result: 0");
            Console.WriteLine($"Actual Result: {result} - Test Passed");
            Console.WriteLine("Time Complexity Analysis: O(n), where n is the length of the string. In this case, n=0.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LengthOfLongestSubstring_SingleCharacter_ReturnsOne()
        {
            // Arrange
            string input = "a";

            // Act
            int result = IntermediateExamples.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(1, result);

            // Print results to console
            Console.WriteLine("Test: LengthOfLongestSubstring_SingleCharacter_ReturnsOne");
            Console.WriteLine("Input: 'a'");
            Console.WriteLine("Expected Result: 1");
            Console.WriteLine($"Actual Result: {result} - Test Passed");
            Console.WriteLine("Time Complexity Analysis: O(n), where n is the length of the string. In this case, n=1.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LengthOfLongestSubstring_AllUniqueCharacters_ReturnsLength()
        {
            // Arrange
            string input = "abcdef";

            // Act
            int result = IntermediateExamples.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(6, result);

            // Print results to console
            Console.WriteLine("Test: LengthOfLongestSubstring_AllUniqueCharacters_ReturnsLength");
            Console.WriteLine("Input: 'abcdef'");
            Console.WriteLine("Expected Result: 6");
            Console.WriteLine($"Actual Result: {result} - Test Passed");
            Console.WriteLine("Time Complexity Analysis: O(n), where n is the length of the string. In this case, n=6.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LengthOfLongestSubstring_RepeatingCharacters_ReturnsMaxLength()
        {
            // Arrange
            string input = "abcabcbb";

            // Act
            int result = IntermediateExamples.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(3, result);

            // Print results to console
            Console.WriteLine("Test: LengthOfLongestSubstring_RepeatingCharacters_ReturnsMaxLength");
            Console.WriteLine("Input: 'abcabcbb'");
            Console.WriteLine("Expected Result: 3");
            Console.WriteLine($"Actual Result: {result} - Test Passed");
            Console.WriteLine("Time Complexity Analysis: O(n), where n is the length of the string. In this case, n=8.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LengthOfLongestSubstring_StringWithSpaces_ReturnsMaxLength()
        {
            // Arrange
            string input = "a b c a b c";

            // Act
            int result = IntermediateExamples.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(3, result);

            // Print results to console
            Console.WriteLine("Test: LengthOfLongestSubstring_StringWithSpaces_ReturnsMaxLength");
            Console.WriteLine("Input: 'a b c a b c'");
            Console.WriteLine("Expected Result: 5");
            Console.WriteLine($"Actual Result: {result} - Test Passed");
            Console.WriteLine("Time Complexity Analysis: O(n), where n is the length of the string. In this case, n=11.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void LengthOfLongestSubstring_LongStringWithRepetition_ReturnsMaxLength()
        {
            // Arrange
            string input = "pwwkew";

            // Act
            int result = IntermediateExamples.LengthOfLongestSubstring(input);

            // Assert
            Assert.Equal(3, result);

            // Print results to console
            Console.WriteLine("Test: LengthOfLongestSubstring_LongStringWithRepetition_ReturnsMaxLength");
            Console.WriteLine("Input: 'pwwkew'");
            Console.WriteLine("Expected Result: 3");
            Console.WriteLine($"Actual Result: {result} - Test Passed");
            Console.WriteLine("Time Complexity Analysis: O(n), where n is the length of the string. In this case, n=6.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AddMatrices_ValidMatrices_ReturnsCorrectSum()
        {
            // Arrange
            int[,] matrixA = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            int[,] matrixB = {
                { 7, 8, 9 },
                { 10, 11, 12 }
            };
            int[,] expected = {
                { 8, 10, 12 },
                { 14, 16, 18 }
            };

            // Act
            var result = IntermediateExamples.AddMatrices(matrixA, matrixB);

            // Output for clarity
            Console.WriteLine("Test: AddMatrices_ValidMatrices_ReturnsCorrectSum");
            Console.WriteLine("Input Matrix A:");
            PrintMatrix(matrixA);
            Console.WriteLine("Input Matrix B:");
            PrintMatrix(matrixB);
            Console.WriteLine("Expected Result:");
            PrintMatrix(expected);
            Console.WriteLine($"Actual Result:");
            PrintMatrix(result);

            // Assert and output test passed status
            Assert.Equal(expected, result);
            Console.WriteLine("Test Passed: Yes");
            Console.WriteLine("Time Complexity Analysis: O(n), where n is the number of elements in the matrices. In this case, n=6.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        [Fact]
        public void AddMatrices_NegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int[,] matrixA = {
                { -1, -2, -3 },
                { -4, -5, -6 }
            };
            int[,] matrixB = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            int[,] expected = {
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            // Act
            var result = IntermediateExamples.AddMatrices(matrixA, matrixB);

            // Output for clarity
            Console.WriteLine("Test: AddMatrices_NegativeNumbers_ReturnsCorrectSum");
            PrintMatrix(matrixA);
            PrintMatrix(matrixB);
            Console.WriteLine("Expected Result:");
            PrintMatrix(expected);
            Console.WriteLine($"Actual Result:");
            PrintMatrix(result);

            // Assert and output test passed status
            Assert.Equal(expected, result);
            Console.WriteLine("Test Passed: Yes");
            Console.WriteLine("Time Complexity Analysis: O(n), where n is the number of elements in the matrices. In this case, n=6.");
            Console.WriteLine("==============================");
            Console.WriteLine();
        }

        private void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Console.WriteLine("-----------------");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],3} |"); // Right-align numbers with padding
                }
                Console.WriteLine(); // New line after each row
                Console.WriteLine("-----------------"); // Horizontal line for separation
            }
        }

        // Test for a simple graph
        [Fact]
        public void DepthFirstSearch_SimpleGraph_TraversesCorrectly()
        {
            // Arrange
            var graph = new Dictionary<int, List<int>>()
    {
        { 1, new List<int> { 2, 3 } },
        { 2, new List<int> { 4 } },
        { 3, new List<int> { 5 } },
        { 4, new List<int> { } },
        { 5, new List<int> { } }
    };
            var visited = new HashSet<int>();
            var expectedOutput = new List<int> { 1, 2, 4, 3, 5 };

            // Act
            IntermediateExamples.DepthFirstSearch(graph, 1, visited);

            // Assert
            Console.WriteLine("Test: DepthFirstSearch_SimpleGraph_TraversesCorrectly");
            Console.WriteLine("Input Graph: ");
            foreach (var node in graph)
            {
                Console.WriteLine($"{node.Key}: {string.Join(", ", node.Value)}");
            }
            Console.WriteLine("Expected DFS Output: " + string.Join(", ", expectedOutput));
            Console.WriteLine("Actual DFS Output: " + string.Join(", ", visited));
            Console.WriteLine("Test Passed: " + (expectedOutput.SequenceEqual(visited) ? "Yes" : "No"));
            Console.WriteLine("Time Complexity Analysis: O(V + E), where V is the number of vertices and E is the number of edges.");
            Console.WriteLine("==============================");

            Assert.True(expectedOutput.SequenceEqual(visited), "DFS output did not match expected output.");
        }


        // Test for cyclic graph
        [Fact]
        public void DepthFirstSearch_CyclicGraph_HandlesCycles()
        {
            // Arrange
            var graph = new Dictionary<int, List<int>>()
    {
        { 1, new List<int> { 2, 3 } },
        { 2, new List<int> { 1, 4 } },
        { 3, new List<int> { 5 } },
        { 4, new List<int> { 2 } },
        { 5, new List<int> { } }
    };
            var visited = new HashSet<int>();
            var expectedOutput = new List<int> { 1, 2, 4, 3, 5 };

            // Act
            IntermediateExamples.DepthFirstSearch(graph, 1, visited);

            // Assert
            Console.WriteLine("Test: DepthFirstSearch_CyclicGraph_HandlesCycles");
            Console.WriteLine("Input Graph: ");
            foreach (var node in graph)
            {
                Console.WriteLine($"{node.Key}: {string.Join(", ", node.Value)}");
            }
            Console.WriteLine("Expected DFS Output: " + string.Join(", ", expectedOutput));
            Console.WriteLine("Actual DFS Output: " + string.Join(", ", visited));
            Console.WriteLine("Test Passed: " + (expectedOutput.SequenceEqual(visited) ? "Yes" : "No"));
            Console.WriteLine("Time Complexity Analysis: O(V + E), where V is the number of vertices and E is the number of edges. The DFS handles cycles correctly by using a visited set.");
            Console.WriteLine("==============================");

            Assert.True(expectedOutput.SequenceEqual(visited), "DFS output did not match expected output.");
        }

        // Test for disconnected graph
        [Fact]
        public void DepthFirstSearch_DisconnectedGraph_TraversesCorrectly()
        {
            // Arrange
            var graph = new Dictionary<int, List<int>>()
    {
        { 1, new List<int> { 2 } },
        { 2, new List<int> { 1 } },
        { 3, new List<int> { 4 } },
        { 4, new List<int> { 3 } },
        { 5, new List<int> { } }
    };
            var visited = new HashSet<int>();
            var expectedOutput = new HashSet<int> { 1, 2 }; // Only connected component of 1

            // Act
            IntermediateExamples.DepthFirstSearch(graph, 1, visited);

            // Assert
            Console.WriteLine("Test: DepthFirstSearch_DisconnectedGraph_TraversesCorrectly");
            Console.WriteLine("Input Graph: ");
            foreach (var node in graph)
            {
                Console.WriteLine($"{node.Key}: {string.Join(", ", node.Value)}");
            }
            Console.WriteLine("Expected DFS Output: " + string.Join(", ", expectedOutput));
            Console.WriteLine("Actual DFS Output: " + string.Join(", ", visited));
            Console.WriteLine("Test Passed: " + (expectedOutput.SetEquals(visited) ? "Yes" : "No"));
            Console.WriteLine("Time Complexity Analysis: O(V + E), traverses all connected components.");
            Console.WriteLine("==============================");

            Assert.True(expectedOutput.SetEquals(visited), "DFS output did not match expected output.");
        }

        // Test for empty graph
        [Fact]
        public void DepthFirstSearch_EmptyGraph_DoesNotTraverse()
        {
            // Arrange
            var graph = new Dictionary<int, List<int>>();
            var visited = new HashSet<int>();

            // Act
            IntermediateExamples.DepthFirstSearch(graph, 1, visited);

            // Assert
            Console.WriteLine("Test: DepthFirstSearch_EmptyGraph_DoesNotTraverse");
            Console.WriteLine("Input Graph: Empty");
            Console.WriteLine("Expected DFS Output: (none)");
            Console.WriteLine("Actual DFS Output: (none)");
            Console.WriteLine("Test Passed: Yes");
            Console.WriteLine("Time Complexity Analysis: O(1), as no operations are performed on an empty graph.");
            Console.WriteLine("==============================");

            Assert.Empty(visited); // The visited set should remain empty
        }
    }
}
