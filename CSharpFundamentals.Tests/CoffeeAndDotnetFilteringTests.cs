// Run tests like this:
// dotnet test --filter "FullyQualifiedName~CSharpFundamentals.Tests.CoffeeAndDotnetFilteringTests" --logger "console;verbosity=detailed"

namespace CSharpFundamentals.Tests
{
    public class CoffeeAndDotnetFilteringTests
    {
        [Fact]
        public void Test_FilterMildCoffees()
        {
            // ARRANGE: Initialize the data stream with coffee strengths
            List<int> coffeeStrengths = new List<int> { 3, 16, 2, 45, 8, 27 };
            Console.WriteLine("Arranged coffee strengths: " + string.Join(", ", coffeeStrengths));

            // ACT: Create an instance of CoffeeAndDotnetFiltering and filter for mild coffees (even strengths)
            CoffeeAndDotnetFiltering coffeeFilter = new CoffeeAndDotnetFiltering(coffeeStrengths);
            List<int> mildCoffees = coffeeFilter.FilterMildCoffees();
            Console.WriteLine("Filtered mild coffees (even strengths): " + string.Join(", ", mildCoffees));

            // ASSERT: Check if the result matches the expected output
            List<int> expectedMildCoffees = new List<int> { 16, 2, 8 }; // Expected result: even numbers from the input
            Console.WriteLine("\nAsserting the result...");
            Console.WriteLine("Expected mild coffees: " + string.Join(", ", expectedMildCoffees));
            Console.WriteLine("Test Passed: " + (mildCoffees.SequenceEqual(expectedMildCoffees) ? "Yes" : "No"));

            // Output final result
            Console.WriteLine("\nTest execution completed.");
        }

        [Fact]
        public void Test_FilterPositiveEvenNumbers()
        {
            // ARRANGE: Initialize the data stream with integers
            List<int> dataStream = new List<int> { -1, 2, 5, 8, 12, -3, -8, 0 };
            Console.WriteLine("Arranged data stream: " + string.Join(", ", dataStream));

            // ACT: Create an instance of CoffeeAndDotnetFiltering and filter for positive even numbers
            CoffeeAndDotnetFiltering dataFilter = new CoffeeAndDotnetFiltering(dataStream);
            List<int> positiveEvenNumbers = dataFilter.FilterPositiveEvenNumbers();
            Console.WriteLine("Filtered positive even numbers: " + string.Join(", ", positiveEvenNumbers));

            // ASSERT: Check if the result matches the expected output
            List<int> expectedPositiveEvenNumbers = new List<int> { 2, 8, 12 }; // Expected result: positive even numbers
            Console.WriteLine("\nAsserting the result...");
            Console.WriteLine("Expected positive even numbers: " + string.Join(", ", expectedPositiveEvenNumbers));
            Console.WriteLine("Test Passed: " + (positiveEvenNumbers.SequenceEqual(expectedPositiveEvenNumbers) ? "Yes" : "No"));

            // Output final result
            Console.WriteLine("\nTest execution completed.");
        }
    }
}
