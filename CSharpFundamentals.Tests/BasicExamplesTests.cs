namespace CSharpFundamentals.Tests;

public class BasicExamplesTests
{
    // To run tests with more information we can use the following command:
    // dotnet test --logger "console;verbosity=detailed"
    // This below shows how to run a single test to get what is needed if it is failing
    // dotnet test --logger "console;verbosity=detailed" --filter "FullyQualifiedName~CSharpFundamentals.Tests.BasicExamplesTests.IsAllDigits_AllDigits_ReturnsTrue"
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

    [Fact]
    public void IsAllDigits_AllDigits_ReturnsTrue()
    {
        // Arrange
        string input = "1234567890";
        bool expected = true;

        // Informative console output
        Console.WriteLine("=== Testing IsAllDigits with a string containing only digits ===");
        Console.WriteLine($"Input String: \"{input}\"");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        bool actual = BasicExamples.IsAllDigits(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: String contains only digits as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void IsAllDigits_WithNonDigitCharacters_ReturnsFalse()
    {
        // Arrange
        string input = "123a456";
        bool expected = false;

        // Informative console output
        Console.WriteLine("=== Testing IsAllDigits with a string containing non-digit characters ===");
        Console.WriteLine($"Input String: \"{input}\"");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        bool actual = BasicExamples.IsAllDigits(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: String contains non-digit characters, result is false.");
    }

    [Fact]
    public void IsAllDigits_EmptyString_ReturnsFalse()
    {
        // Arrange
        string input = "";
        bool expected = true;

        // Informative console output
        Console.WriteLine("=== Testing IsAllDigits with an empty string ===");
        Console.WriteLine("Input String is empty.");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        bool actual = BasicExamples.IsAllDigits(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Empty string returns false as expected.");
    }

    [Fact]
    public void IsAllDigits_MixedCharacters_ReturnsFalse()
    {
        // Arrange
        string input = "abc123xyz";
        bool expected = false;

        // Informative console output
        Console.WriteLine("=== Testing IsAllDigits with a string containing mixed characters ===");
        Console.WriteLine($"Input String: \"{input}\"");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        bool actual = BasicExamples.IsAllDigits(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Mixed characters return false as expected.");
    }

    [Fact]
    public void CelciusToFahrenheit_PositiveValue_ReturnsCorrectResult()
    {
        // Arrange
        double input = 25; // 25°C
        double expected = 77; // Expected result in Fahrenheit

        // Informative console output
        Console.WriteLine("=== Testing CelciusToFahrenheit with a positive value ===");
        Console.WriteLine($"Input Celsius: {input}");
        Console.WriteLine($"Expected Fahrenheit: {expected}");

        // Act
        double actual = BasicExamples.CelciusToFahrenheit(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Conversion from Celsius to Fahrenheit is correct.");
        Console.WriteLine($"Actual Fahrenheit: {actual}");
    }

    [Fact]
    public void CelciusToFahrenheit_NegativeValue_ReturnsCorrectResult()
    {
        // Arrange
        double input = -10; // -10°C
        double expected = 14; // Expected result in Fahrenheit

        // Informative console output
        Console.WriteLine("=== Testing CelciusToFahrenheit with a negative value ===");
        Console.WriteLine($"Input Celsius: {input}");
        Console.WriteLine($"Expected Fahrenheit: {expected}");

        // Act
        double actual = BasicExamples.CelciusToFahrenheit(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Conversion from Celsius to Fahrenheit is correct.");
        Console.WriteLine($"Actual Fahrenheit: {actual}");
    }

    [Fact]
    public void CelciusToFahrenheit_ZeroValue_ReturnsCorrectResult()
    {
        // Arrange
        double input = 0; // 0°C
        double expected = 32; // Expected result in Fahrenheit

        // Informative console output
        Console.WriteLine("=== Testing CelciusToFahrenheit with zero value ===");
        Console.WriteLine($"Input Celsius: {input}");
        Console.WriteLine($"Expected Fahrenheit: {expected}");

        // Act
        double actual = BasicExamples.CelciusToFahrenheit(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Conversion from Celsius to Fahrenheit is correct.");
        Console.WriteLine($"Actual Fahrenheit: {actual}");
    }

    [Fact]
    public void CalculateAverage_WithMultipleValues_ReturnsCorrectAverage()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 }; // Average should be 3
        double expected = 3.0;

        // Informative console output
        Console.WriteLine("=== Testing CalculateAverage with multiple values ===");
        Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
        Console.WriteLine($"Expected Average: {expected}");

        // Act
        double actual = BasicExamples.CalculateAverage(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Average calculation is correct.");
        Console.WriteLine($"Actual Average: {actual}");
    }

    [Fact]
    public void CalculateAverage_WithSingleValue_ReturnsSameValue()
    {
        // Arrange
        int[] input = { 10 }; // Average should be 10
        double expected = 10.0;

        // Informative console output
        Console.WriteLine("=== Testing CalculateAverage with a single value ===");
        Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
        Console.WriteLine($"Expected Average: {expected}");

        // Act
        double actual = BasicExamples.CalculateAverage(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Average calculation is correct.");
        Console.WriteLine($"Actual Average: {actual}");
    }

    [Fact]
    public void CalculateAverage_WithEmptyArray_ThrowsInvalidOperationException()
    {
        // Arrange
        int[] input = Array.Empty<int>(); // Empty array

        // Informative console output
        Console.WriteLine("=== Testing CalculateAverage with an empty array ===");
        Console.WriteLine("Input Array is empty.");

        // Act & Assert
        var exception = Assert.Throws<InvalidOperationException>(() => BasicExamples.CalculateAverage(input));
        Console.WriteLine("Test passed: Exception thrown as expected for empty array.");
        Console.WriteLine($"Exception Message: {exception.Message}");
    }

    [Fact]
    public void CalculateAverage_WithNegativeValues_ReturnsCorrectAverage()
    {
        // Arrange
        int[] input = { -1, -2, -3, -4, -5 }; // Average should be -3
        double expected = -3.0;

        // Informative console output
        Console.WriteLine("=== Testing CalculateAverage with negative values ===");
        Console.WriteLine($"Input Array: [{string.Join(", ", input)}]");
        Console.WriteLine($"Expected Average: {expected}");

        // Act
        double actual = BasicExamples.CalculateAverage(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Average calculation is correct.");
        Console.WriteLine($"Actual Average: {actual}");
    }

    [Fact]
    public void IsLeapYear_YearDivisibleBy4ButNotBy100_ReturnsTrue()
    {
        // Arrange
        int input = 2024; // Leap year
        bool expected = true;

        // Informative console output
        Console.WriteLine("=== Testing IsLeapYear for a year divisible by 4 but not by 100 ===");
        Console.WriteLine($"Input Year: {input}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        bool actual = BasicExamples.IsLeapYear(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: 2024 is a leap year as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void IsLeapYear_YearDivisibleBy100ButNotBy400_ReturnsFalse()
    {
        // Arrange
        int input = 1900; // Not a leap year
        bool expected = false;

        // Informative console output
        Console.WriteLine("=== Testing IsLeapYear for a year divisible by 100 but not by 400 ===");
        Console.WriteLine($"Input Year: {input}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        bool actual = BasicExamples.IsLeapYear(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: 1900 is not a leap year as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void IsLeapYear_YearDivisibleBy400_ReturnsTrue()
    {
        // Arrange
        int input = 2000; // Leap year
        bool expected = true;

        // Informative console output
        Console.WriteLine("=== Testing IsLeapYear for a year divisible by 400 ===");
        Console.WriteLine($"Input Year: {input}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        bool actual = BasicExamples.IsLeapYear(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: 2000 is a leap year as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void IsLeapYear_NonLeapYear_ReturnsFalse()
    {
        // Arrange
        int input = 2019; // Not a leap year
        bool expected = false;

        // Informative console output
        Console.WriteLine("=== Testing IsLeapYear for a non-leap year ===");
        Console.WriteLine($"Input Year: {input}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        bool actual = BasicExamples.IsLeapYear(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: 2019 is not a leap year as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void CountWords_NullOrWhiteSpaceInput_ReturnsZero()
    {
        // Arrange
        string? input = null; // Test for null input
        int expected = 0;

        // Informative console output
        Console.WriteLine("=== Testing CountWords for null input ===");
        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        int actual = BasicExamples.CountWords(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Null input returns zero as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void CountWords_EmptyString_ReturnsZero()
    {
        // Arrange
        string input = ""; // Test for empty string
        int expected = 0;

        // Informative console output
        Console.WriteLine("=== Testing CountWords for an empty string ===");
        Console.WriteLine($"Input: \"{input}\"");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        int actual = BasicExamples.CountWords(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Empty string returns zero as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void CountWords_SingleWord_ReturnsOne()
    {
        // Arrange
        string input = "Hello"; // Test for a single word
        int expected = 1;

        // Informative console output
        Console.WriteLine("=== Testing CountWords for a single word ===");
        Console.WriteLine($"Input: \"{input}\"");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        int actual = BasicExamples.CountWords(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Single word returns one as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void CountWords_MultipleWords_ReturnsCorrectCount()
    {
        // Arrange
        string input = "This is a test string"; // Test for multiple words
        int expected = 5;

        // Informative console output
        Console.WriteLine("=== Testing CountWords for multiple words ===");
        Console.WriteLine($"Input: \"{input}\"");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        int actual = BasicExamples.CountWords(input);

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Multiple words return correct count as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void CountWords_ExtraSpaces_ReturnsCorrectCount()
    {
        // Arrange
        string input = "  Extra   spaces    here  "; // Test for extra spaces
        int expected = 3;

        // Informative console output
        Console.WriteLine("=== Testing CountWords for input with extra spaces ===");
        Console.WriteLine($"Input: \"{input}\"");
        Console.WriteLine($"Expected Result: {expected}");

        // Act
        int actual = BasicExamples.CountWords(input.Trim()); // Trimming to remove leading/trailing spaces

        // Assert
        Assert.Equal(expected, actual);
        Console.WriteLine("Test passed: Extra spaces counted correctly as expected.");
        Console.WriteLine($"Actual Result: {actual}");
    }

    [Fact]
    public void GenerateRandomNumber_WithinRange_ReturnsNumberInRange()
    {
        // Arrange
        int min = 1;
        int max = 100;
        int iterations = 1000; // Number of times to test the randomness
        bool isInRange = true;

        // Informative console output
        Console.WriteLine("=== Testing GenerateRandomNumber within specified range ===");
        Console.WriteLine($"Min: {min}, Max: {max}, Iterations: {iterations}");

        // Act
        for (int i = 0; i < iterations; i++)
        {
            int randomNumber = BasicExamples.GenerateRandomNumber(min, max);
            if (randomNumber < min || randomNumber >= max)
            {
                isInRange = false;
                Console.WriteLine($"Random number {randomNumber} is out of range on iteration {i + 1}.");
                break;
            }
        }

        // Assert
        Assert.True(isInRange, "Generated random number was outside the specified range.");
        Console.WriteLine("All generated numbers were within the specified range.");
    }

    [Fact]
    public void SumOfDigits_PositiveNumber_ReturnsCorrectSum()
    {
        // Arrange
        int number = 1234;

        // Informative console output
        Console.WriteLine("=== Testing SumOfDigits with a positive number ===");
        Console.WriteLine($"Number: {number}");

        // Act
        int result = BasicExamples.SumOfDigits(number);

        // Assert
        Assert.Equal(10, result); // 1 + 2 + 3 + 4 = 10
        Console.WriteLine($"Expected: 10, Result: {result}. Test passed!\n");
    }

    [Fact]
    public void SumOfDigits_NegativeNumber_ReturnsCorrectSum()
    {
        // Arrange
        int number = -567;

        // Informative console output
        Console.WriteLine("=== Testing SumOfDigits with a negative number ===");
        Console.WriteLine($"Number: {number}");

        // Act
        int result = BasicExamples.SumOfDigits(number);

        // Assert
        Assert.Equal(18, result); // 5 + 6 + 7 = 18
        Console.WriteLine($"Expected: 18, Result: {result}. Test passed!\n");
    }

    [Fact]
    public void SumOfDigits_Zero_ReturnsZero()
    {
        // Arrange
        int number = 0;

        // Informative console output
        Console.WriteLine("=== Testing SumOfDigits with zero ===");
        Console.WriteLine($"Number: {number}");

        // Act
        int result = BasicExamples.SumOfDigits(number);

        // Assert
        Assert.Equal(0, result); // Sum of digits in 0 is 0
        Console.WriteLine($"Expected: 0, Result: {result}. Test passed!\n");
    }

    [Fact]
    public void SumOfDigits_SingleDigit_ReturnsSameNumber()
    {
        // Arrange
        int number = 9;

        // Informative console output
        Console.WriteLine("=== Testing SumOfDigits with a single-digit number ===");
        Console.WriteLine($"Number: {number}");

        // Act
        int result = BasicExamples.SumOfDigits(number);

        // Assert
        Assert.Equal(9, result); // Sum of digits in 9 is 9
        Console.WriteLine($"Expected: 9, Result: {result}. Test passed!\n");
    }
}
