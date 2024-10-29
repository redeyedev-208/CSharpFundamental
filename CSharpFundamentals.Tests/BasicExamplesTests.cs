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

        // Act
        string result = BasicExamples.ReverseString(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseString_ThrowsArgumentNullException_WhenInputIsNull()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => BasicExamples.ReverseString(null));
    }
}
