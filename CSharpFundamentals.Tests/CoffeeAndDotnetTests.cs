using System;
using Xunit;

// To run tests in this test file we do the following shown below and to run a single test we just add a "." with the test name and are good to go
// dotnet test --filter "FullyQualifiedName~CSharpFundamentals.Tests.CoffeeAndDotnetTests.TestNameGoesHere" --logger "console;verbosity=detailed"  
// dotnet test --filter "FullyQualifiedName~CSharpFundamentals.Tests.CoffeeAndDotnetTests" --logger "console;verbosity=detailed"  

namespace CSharpFundamentals.Tests
{
    public class CoffeeAndDotnetTests
    {
        [Fact]
        public void TestExplainDotNetAndCSharp()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = ".NET is the framework, like the coffee machine that brews everything together. C# is the language, like the coffee beans used to create your favorite cup.";

            // Informative console output
            Console.WriteLine("=== Testing ExplainDotNetAndCSharp ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.ExplainDotNetAndCSharp();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestCompareDotNetVersions()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = ".NET Framework is like a traditional coffee brewer, limited to certain beans (Windows). .NET Core is like a portable coffee maker—versatile and runs anywhere. .NET 5 is the upgraded machine, blending everything to make it streamlined.";

            // Informative console output
            Console.WriteLine("=== Testing CompareDotNetVersions ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.CompareDotNetVersions();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainILCode()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "IL Code is like ground coffee, partially prepared, ready for the brewing process by the JIT (Just In Time) compiler.";

            // Informative console output
            Console.WriteLine("=== Testing ExplainILCode ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.ExplainILCode();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainJIT()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "JIT compiles IL code to machine language, like the hot water extracting flavor from coffee grounds to make the final drink.";

            // Informative console output
            Console.WriteLine("=== Testing ExplainJIT ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.ExplainJIT();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestCanViewILCode()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "Yes, using tools like IL DASM, which is like inspecting the ground coffee before brewing.";

            // Informative console output
            Console.WriteLine("=== Testing CanViewILCode ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.CanViewILCode();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestBenefitOfIL()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "IL code adapts to the runtime environment, optimizing your coffee brew temperature and flavor based on location.";

            // Informative console output
            Console.WriteLine("=== Testing BenefitOfIL ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.BenefitOfIL();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestSupportsMultipleLanguages()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            bool expected = true;

            // Informative console output
            Console.WriteLine("=== Testing SupportsMultipleLanguages ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            bool result = coffeeDotnet.SupportsMultipleLanguages();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainCLR()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "CLR is like the barista, handling the brewing process, managing resources, and cleaning up (Garbage Collection).";

            // Informative console output
            Console.WriteLine("=== Testing ExplainCLR ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.ExplainCLR();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainManagedAndUnmanagedCode()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "Managed code is brewed within .NET (like espresso), while unmanaged code is like a separate, non-coffee drink (think tea) that doesn’t use the CLR process.";

            // Informative console output
            Console.WriteLine("=== Testing ExplainManagedAndUnmanagedCode ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.ExplainManagedAndUnmanagedCode();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestImportanceOfGarbageCollector()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "Garbage Collector cleans unused resources, like a barista clearing used coffee grounds.";

            // Informative console output
            Console.WriteLine("=== Testing ImportanceOfGarbageCollector ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.ImportanceOfGarbageCollector();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestCanGarbageCollectorClaimUnmanagedObjects()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            bool expected = false;

            // Informative console output
            Console.WriteLine("=== Testing CanGarbageCollectorClaimUnmanagedObjects ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            bool result = coffeeDotnet.CanGarbageCollectorClaimUnmanagedObjects();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainCTS()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "CTS ensures that all .NET languages can share data types, like having a universal coffee recipe book so every barista makes the same brew.";

            // Informative console output
            Console.WriteLine("=== Testing ExplainCTS ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.ExplainCTS();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainCLS()
        {
            // Arrange
            var coffeeDotnet = new CoffeeAndDotnet();
            string expected = "CLS is a set of rules ensuring .NET languages work together, like a shared coffee protocol so all cafes produce compatible flavors.";

            // Informative console output
            Console.WriteLine("=== Testing ExplainCLS ===");
            Console.WriteLine($"Expected Output: '{expected}'");

            // Act
            string result = coffeeDotnet.ExplainCLS();

            // Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine($"Actual Output: '{result}'");
            Console.WriteLine("Test passed: The output matches the expected value.");
            Console.WriteLine("=============================================");
        }
    }
}
