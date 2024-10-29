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
}
