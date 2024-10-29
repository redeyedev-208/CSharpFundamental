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
}
