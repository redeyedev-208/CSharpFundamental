namespace CSharpFundamentals.Tests;

public class BasicExamplesTests
{
    // To run tests with more information we can use the following command:
    // dotnet test --logger "console;verbosity=detailed"
    [Fact]
    public void ReverseString_ReturnsReversedString()
    {
        // Arrange
        string input = "hello";
        string expected = "olleh";

        // Informative console output
        Console.WriteLine("=== Testing ReverseString ===");
        Console.WriteLine($"Input: '{input}' | Expected Output: '{expected}'");

        // Act
        string result = BasicExamples.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);

        // Output the result
        Console.WriteLine($"Actual Output: '{result}'");
        Console.WriteLine("Test passed: The output matches the expected value.");
    }

    [Fact]
    public void ReverseString_ThrowsArgumentNullException_WhenInputIsNull()
    {
        // Informative console output
        Console.WriteLine("=== Testing ReverseString for null input ===");

        // Act & Assert
        var exception = Assert.Throws<ArgumentNullException>(() => BasicExamples.ReverseString(null));
        Console.WriteLine("Test passed: ArgumentNullException was thrown as expected.");
        Console.WriteLine($"Exception message: {exception.Message}");
    }

    [Fact]
    public void IsPalindrome_ReturnsTrue_ForPalindrome()
    {
        // Arrange
        string input = "Racecar";
        bool expected = true;

        // Informative console output 
        Console.WriteLine("=== Testing IsPalindrom ===");
        Console.WriteLine($"Input: '{input}' | Expected Output: {expected}");

        // Act
        bool result = BasicExamples.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
        Console.WriteLine($"Actual Output: {result}");
        Console.WriteLine("Test passed: The output matches the expected value.");
    }

    [Fact]
    public void IsPalindrome_ReturnsFalse_ForNonPalindrome()
    {
        // Arrange
        string input = "Hello";
        bool expected = false;

        // Informative console output
        Console.WriteLine("=== Testing IsPalindrome ===");
        Console.WriteLine($"Input: '{input}' | Expected Output: {expected}");

        // Act
        bool result = BasicExamples.IsPalindrome(input);

        // Assert
        Assert.Equal(expected, result);
        Console.WriteLine($"Actual Output: {result}");
        Console.WriteLine("Test passed: The output matches the expected value.");
    }

    [Fact]
    public void GenerateFibonacci_ReturnsCorrectSequence()
    {
        // Arrange
        int count = 5;
        int[] expected = { 0, 1, 1, 2, 3 };

        // Informative console output
        Console.WriteLine("=== Testing GenerateFibonacci ===");
        Console.WriteLine($"Count: {count} | Expected Output: {string.Join(",", expected)}");

        // Act
        int[] result = BasicExamples.GenerateFibonacci(count);

        // Assert
        Assert.Equal(expected, result);
        Console.WriteLine($"Actual Output: {string.Join(",", result)}");
        Console.WriteLine("Test passed: The output matches the expected value.");
    }

    [Fact]
    public void GenerateFibonacci_ThrowsArgumentException_WhenCountIsZero()
    {
        // Informative console output
        Console.WriteLine("=== Testing Generate Fibonacci for count = 0 ===");

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => BasicExamples.GenerateFibonacci(0));
        Console.WriteLine("Test passed: ArgumentException was thrown as expected.");
        Console.WriteLine($"Exception message: {exception.Message}");
    }

    [Fact]
    public void SumArray_ReturnsCorrectSum()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int expected = 15;

        // Informative console output
        Console.WriteLine("=== Testing SumArray ===");
        Console.WriteLine($"Input Array: {string.Join(", ", input)} | Expected Sum: {expected}");

        // Act
        int result = BasicExamples.SumArray(input);

        // Assert
        Assert.Equal(expected, result);
        Console.WriteLine($"Actual Sum: {result}");
        Console.WriteLine("Test passed: The output matches the expected value.");
    }

    [Fact]
    public void SumArray_ThrowsArgumentNullException_WhenInputIsNull()
    {
        // Informative console output
        Console.WriteLine("=== Testing SumArray for null input ===");

        // Act & Assert
        var exception = Assert.Throws<ArgumentNullException>(() => BasicExamples.SumArray(null));
        Console.WriteLine("Test passed: ArgumentNullException was thrown as expected.");
        Console.WriteLine($"Exception message: {exception.Message}");
    }

    [Fact]
    public void SumArray_ReturnsZero_WhenArrayIsEmpty()
    {
        // Arrange
        int[] input = [];
        int expected = 0;

        // Informative console output
        Console.WriteLine("=== Testing SumArray with an empty array ===");
        Console.WriteLine($"Input Array: {string.Join(", ", input)} | Expected Sum: {expected}");

        // Act
        int result = BasicExamples.SumArray(input);

        // Assert
        Assert.Equal(expected, result);
        Console.WriteLine($"Actual Sum: {result}");
        Console.WriteLine("Test passed: The output matches the expected value.");
    }

    [Fact]
    public void FindLargest_ReturnsCorrectLargestValue()
    {
        // Arrange
        int[] input = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
        int expected = 9;

        // Informative console output
        Console.WriteLine("=== Testing FindLargest ===");
        Console.WriteLine($"Input Array: {string.Join(", ", input)} | Expected Largest: {expected}");

        // Act
        int result = BasicExamples.FindLargest(input);

        // Assert
        Assert.Equal(expected, result);
        Console.WriteLine($"Actual Largest: {result}");
        Console.WriteLine("Test passed: The output matches the expected value.");
    }

    [Fact]
    public void FindLargest_ThrowsArgumentNullException_WhenInputIsNull()
    {
        // Informative console output
        Console.WriteLine("=== Testing FindLargest for null input ===");

        // Act & Assert
        var exception = Assert.Throws<ArgumentNullException>(() => BasicExamples.FindLargest(null));
        Console.WriteLine("Test passed: ArgumentNullException was thrown as expected.");
        Console.WriteLine($"Exception message: {exception.Message}");
    }

    [Fact]
    public void FindLargest_ThrowsArgumentNullException_WhenArrayIsEmpty()
    {
        // Arrange
        int[] input = { };

        // Informative console output
        Console.WriteLine("=== Testing FindLargest with an empty array ===");
        Console.WriteLine($"Input Array: {string.Join(", ", input)}");

        // Act & Assert
        var exception = Assert.Throws<ArgumentNullException>(() => BasicExamples.FindLargest(input));
        Console.WriteLine("Test passed: ArgumentNullException was thrown as expected.");
        Console.WriteLine($"Exception message: {exception.Message}");
    }

    [Fact]
    public void CountVowels_WithVowelsInInput_ReturnsCorrectCount()
    {
        // Arrange
        string input = "Hello World";
        int expectedCount = 3;

        // Informative console output
        Console.WriteLine("=== Testing CountVowels with a string containing vowels ===");
        Console.WriteLine($"Input String: \"{input}\"");
        Console.WriteLine($"Expected Vowel Count: {expectedCount}");

        // Act
        int actualCount = BasicExamples.CountVowels(input);

        // Assert
        Assert.Equal(expectedCount, actualCount);
        Console.WriteLine("Test passed: Vowel count is correct.");
        Console.WriteLine($"Actual Vowel Count: {actualCount}");
    }

    [Fact]
    public void CountVowels_EmptyString_ReturnsZero()
    {
        // Arrange
        string input = "";
        int expectedCount = 0;

        // Informative console output
        Console.WriteLine("=== Testing CountVowels with an empty string ===");
        Console.WriteLine("Input String is empty.");
        Console.WriteLine($"Expected Vowel Count: {expectedCount}");

        // Act
        int actualCount = BasicExamples.CountVowels(input);

        // Assert
        Assert.Equal(expectedCount, actualCount);
        Console.WriteLine("Test passed: Vowel count is zero as expected.");
    }

    [Fact]
    public void CountVowels_NoVowelsInInput_ReturnsZero()
    {
        // Arrange
        string input = "bcdfghjklmnpqrstvwxyz";
        int expectedCount = 0;

        // Informative console output
        Console.WriteLine("=== Testing CountVowels with a string containing no vowels ===");
        Console.WriteLine($"Input String: \"{input}\"");
        Console.WriteLine($"Expected Vowel Count: {expectedCount}");

        // Act
        int actualCount = BasicExamples.CountVowels(input);

        // Assert
        Assert.Equal(expectedCount, actualCount);
        Console.WriteLine("Test passed: Vowel count is zero as expected.");
    }

    [Fact]
    public void CountVowels_AllVowelsInInput_ReturnsCorrectCount()
    {
        // Arrange
        string input = "aeiouAEIOU";
        int expectedCount = 10;

        // Informative console output
        Console.WriteLine("=== Testing CountVowels with a string of all vowels ===");
        Console.WriteLine($"Input String: \"{input}\"");
        Console.WriteLine($"Expected Vowel Count: {expectedCount}");

        // Act
        int actualCount = BasicExamples.CountVowels(input);

        // Assert
        Assert.Equal(expectedCount, actualCount);
        Console.WriteLine("Test passed: Vowel count is correct.");
        Console.WriteLine($"Actual Vowel Count: {actualCount}");
    }

    [Fact]
    public void RemoveDuplicates_WithDuplicates_ReturnsArrayWithoutDuplicates()
    {
        // Arrange
        int[] input = { 1, 2, 2, 3, 3, 3, 4 };
        int[] expectedOutput = { 1, 2, 3, 4 };

        // Informative console output
        Console.WriteLine("=== Testing RemoveDuplicates with an array containing duplicates ===");
        Console.WriteLine($"Input Array: {string.Join(", ", input)}");
        Console.WriteLine($"Expected Output: {string.Join(", ", expectedOutput)}");

        // Act
        int[] actualOutput = BasicExamples.RemoveDuplicates(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
        Console.WriteLine("Test passed: Duplicates removed as expected.");
        Console.WriteLine($"Actual Output: {string.Join(", ", actualOutput)}");
    }

    [Fact]
    public void RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = { };
        int[] expectedOutput = { };

        // Informative console output
        Console.WriteLine("=== Testing RemoveDuplicates with an empty array ===");
        Console.WriteLine("Input Array is empty.");
        Console.WriteLine("Expected Output is an empty array.");

        // Act
        int[] actualOutput = BasicExamples.RemoveDuplicates(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
        Console.WriteLine("Test passed: Returned an empty array as expected.");
    }

    [Fact]
    public void RemoveDuplicates_NoDuplicates_ReturnsSameArray()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expectedOutput = { 1, 2, 3, 4, 5 };

        // Informative console output
        Console.WriteLine("=== Testing RemoveDuplicates with an array containing no duplicates ===");
        Console.WriteLine($"Input Array: {string.Join(", ", input)}");
        Console.WriteLine($"Expected Output: {string.Join(", ", expectedOutput)}");

        // Act
        int[] actualOutput = BasicExamples.RemoveDuplicates(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
        Console.WriteLine("Test passed: No duplicates found, array remains unchanged.");
    }

    [Fact]
    public void RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] input = { 7, 7, 7, 7, 7 };
        int[] expectedOutput = { 7 };

        // Informative console output
        Console.WriteLine("=== Testing RemoveDuplicates with an array of all identical elements ===");
        Console.WriteLine($"Input Array: {string.Join(", ", input)}");
        Console.WriteLine($"Expected Output: {string.Join(", ", expectedOutput)}");

        // Act
        int[] actualOutput = BasicExamples.RemoveDuplicates(input);

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
        Console.WriteLine("Test passed: All duplicates removed, only one instance remains.");
    }

    [Fact]
    public void Power_PositiveExponent_ReturnsCorrectResult()
    {
        // Arrange
        double baseNum = 2;
        int exponent = 3;
        double expected = 8;

        // Informative console output
        Console.WriteLine("=== Testing Power with a positive exponent ===");
        Console.WriteLine($"Base: {baseNum}, Exponent: {exponent}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        double actual = BasicExamples.Power(baseNum, exponent);

        // Assert
        Assert.Equal(expected, actual, precision: 5);
        Console.WriteLine("Test passed: Power calculated correctly.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void Power_ZeroExponent_ReturnsOne()
    {
        // Arrange
        double baseNum = 5;
        int exponent = 0;
        double expected = 1;

        // Informative console output
        Console.WriteLine("=== Testing Power with zero exponent ===");
        Console.WriteLine($"Base: {baseNum}, Exponent: {exponent}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        double actual = BasicExamples.Power(baseNum, exponent);

        // Assert
        Assert.Equal(expected, actual, precision: 5);
        Console.WriteLine("Test passed: Any number to the power of zero is 1.");
    }

    [Fact]
    public void Power_NegativeExponent_ReturnsCorrectReciprocal()
    {
        // Arrange
        double baseNum = 2;
        int exponent = -2;
        double expected = 0.25;

        // Informative console output
        Console.WriteLine("=== Testing Power with a negative exponent ===");
        Console.WriteLine($"Base: {baseNum}, Exponent: {exponent}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        double actual = BasicExamples.Power(baseNum, exponent);

        // Assert
        Assert.Equal(expected, actual, precision: 5);
        Console.WriteLine("Test passed: Negative exponent calculated correctly.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void Power_ExponentOfOne_ReturnsBase()
    {
        // Arrange
        double baseNum = 9;
        int exponent = 1;
        double expected = baseNum;

        // Informative console output
        Console.WriteLine("=== Testing Power with exponent of one ===");
        Console.WriteLine($"Base: {baseNum}, Exponent: {exponent}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        double actual = BasicExamples.Power(baseNum, exponent);

        // Assert
        Assert.Equal(expected, actual, precision: 5);
        Console.WriteLine("Test passed: Number to the power of one is the number itself.");
    }

    [Fact]
    public void Power_BaseZeroPositiveExponent_ReturnsZero()
    {
        // Arrange
        double baseNum = 0;
        int exponent = 5;
        double expected = 0;

        // Informative console output
        Console.WriteLine("=== Testing Power with base zero and positive exponent ===");
        Console.WriteLine($"Base: {baseNum}, Exponent: {exponent}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        double actual = BasicExamples.Power(baseNum, exponent);

        // Assert
        Assert.Equal(expected, actual, precision: 5);
        Console.WriteLine("Test passed: Zero raised to any positive power is zero.");
    }

    [Fact]
    public void Power_BaseZeroExponentZero_ReturnsOne()
    {
        // Arrange
        double baseNum = 0;
        int exponent = 0;
        double expected = 1;  // By convention in most systems

        // Informative console output
        Console.WriteLine("=== Testing Power with both base and exponent zero ===");
        Console.WriteLine($"Base: {baseNum}, Exponent: {exponent}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        double actual = BasicExamples.Power(baseNum, exponent);

        // Assert
        Assert.Equal(expected, actual, precision: 5);
        Console.WriteLine("Test passed: Zero to the power of zero conventionally returns one.");
    }
}
