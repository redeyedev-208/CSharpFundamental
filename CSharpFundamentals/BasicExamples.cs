namespace CSharpFundamentals;

public class BasicExamples
{
  // Method to reverse a string
  public static string ReverseString(string? input)
  {
    ArgumentNullException.ThrowIfNull(input);

    Console.WriteLine("=== Reverse String ===");
    Console.WriteLine($"Input: {input}");

    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    string result = new(charArray);

    Console.WriteLine($"Reversed: {result}");
    return result;
  }

  // Method to check if a string is a palindrome
  public static bool IsPalindrome(string? input)
  {
    ArgumentNullException.ThrowIfNull(input);
    Console.WriteLine("=== Palindrome Check ===");
    Console.WriteLine($"Input: {input}");

    string reversed = ReverseString(input);
    bool isPalindrome = input.Equals(reversed, StringComparison.OrdinalIgnoreCase);

    Console.WriteLine($"Is Palindrom: {isPalindrome}");
    return isPalindrome;
  }

  // Method to generate Fibonacci numbers
  public static int[] GenerateFibonacci(int count)
  {
    if (count < 1)
      throw new ArgumentException("Count must be greater than 0.");

    int[] fibonacci = new int[count];
    fibonacci[0] = 0;

    if (count > 1)
      fibonacci[1] = 1;

    for (int i = 2; i < count; i++)
    {
      fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
    }
    Console.WriteLine("=== Fibonacci Series ===");
    Console.WriteLine($"Generate Fibonacci: {string.Join(",", fibonacci)}");
    return fibonacci;
  }

  // Method to find the sum of an array
  public static int SumArray(int[]? numbers)
  {

    ArgumentNullException.ThrowIfNull(numbers);

    Console.WriteLine("=== Sum Array ===");
    Console.WriteLine($"Input Array: {string.Join(", ", numbers)}");

    int sum = numbers.Sum();
    Console.WriteLine($"Sum: {sum}");
    return sum;
  }

  // Method to find the largest int or number
  public static int FindLargest(int[]? numbers)
  {

    if (numbers == null || numbers.Length == 0)
      throw new ArgumentNullException(nameof(numbers), "The array cannot be null or empty.");

    Console.WriteLine("=== Find Largest ===");
    Console.WriteLine($"Input Array: {string.Join(", ", numbers)}");

    int largest = numbers.Max();
    Console.WriteLine($"Largest: {largest}");
    return largest;
  }

  // Method to find the count of vowels in a string
  public static int CountVowels(string input)
  {
    return input.Count(c => "aeiouAEIOU".Contains(c));
  }

  // Method to remove any duplicates in an array
  public static int[] RemoveDuplicates(int[] numbers)
  {
    return numbers.Distinct().ToArray();
  }

  // Method to calculate the power of a number
  public static double Power(double baseNum, int exponent)
  {
    return Math.Pow(baseNum, exponent);
  }

  // Method to check if a string contains only digits
  public static bool IsAllDigits(string input)
  {
    return input.All(char.IsDigit);
  }

  // Method to convert temperature from celcius to fahrenheit
  public static double CelciusToFahrenheit(double celcius)
  {
    return (celcius * 9 / 5) + 32;
  }

  // Method to calculate the average of an array
  public static double CalculateAverage(int[] numbers)
  {
    return numbers.Average();
  }

  // Method to check if a year is a leap year
  public static bool IsLeapYear(int year)
  {
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
  }

  // Method to count the number of words in a string
  public static int CountWords(string input)
  {
    return string.IsNullOrWhiteSpace(input) ? 0 : input.Split(' ').Length;
  }

  //  Method to generate a random number
  public static int GenerateRandomNumber(int min, int max)
  {
    Random random = new();
    return random.Next(min, max);
  }

  // Method to calculate the sum of digits in a number
  public static int SumOfDigits(int number)
  {
    return number.ToString().Sum(c => c - '0');
  }

}
