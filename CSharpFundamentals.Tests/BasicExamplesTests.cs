using CSharpFundamentals;
using Xunit;

namespace CSharpFundamentals.Tests;

public class BasicExamplesTests
{
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
}
