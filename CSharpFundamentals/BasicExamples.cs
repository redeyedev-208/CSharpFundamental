using System.Xml.XPath;

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
}
