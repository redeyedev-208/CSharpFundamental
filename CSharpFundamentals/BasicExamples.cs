namespace CSharpFundamentals;

public class BasicExamples
{
  // Method to reverse a string
  public static string ReverseString(string? input)
  {
    ArgumentNullException.ThrowIfNull(input); // Throws if input is null

    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
  }
}
