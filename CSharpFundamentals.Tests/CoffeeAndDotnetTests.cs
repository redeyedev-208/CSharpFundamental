using System;
using Xunit;

namespace CSharpFundamentals.Tests
{
    public class CoffeeAndDotnetTests
    {
        // To run a single test do so like this: dotnet test --filter "FullyQualifiedName~CSharpFundamentals.Tests.CoffeeAndDotnetTests.TestExplainDotNetAndCSharp" --logger "console;verbosity=detailed"
        // To run the tests for the whole class we do so like this:
        // dotnet test --filter "FullyQualifiedName~CSharpFundamentals.Tests.CoffeeAndDotnetTests" --logger "console;verbosity=detailed"
        [Fact]
        public void TestExplainDotNetAndCSharp()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainDotNetAndCSharp();

            Console.WriteLine("=== Question 1: Difference between .NET and C# ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("Key Insight:");
            Console.WriteLine(".NET is the framework (the coffee machine), while C# is a language used within .NET (like the coffee beans).");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestCompareDotNetVersions()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.CompareDotNetVersions();

            Console.WriteLine("=== Question 2: .NET Framework vs .NET Core vs .NET 5.0 ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("When to Use:");
            Console.WriteLine(".NET Framework is best for Windows-only applications. .NET Core is cross-platform, and .NET 5 is the unified version.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainILCode()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainILCode();

            Console.WriteLine("=== Question 3: What is IL (Intermediate Language) Code? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("IL Code serves as an intermediate step before compilation to machine code, making it versatile across platforms.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainJIT()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainJIT();

            Console.WriteLine("=== Question 4: What is the use of JIT? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("JIT compiles IL to machine code at runtime, adapting to the system it's running on for performance gains.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestCanViewILCode()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.CanViewILCode();

            Console.WriteLine("=== Question 5: Is it possible to view IL code? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("You can view IL code with tools like IL DASM. Viewing IL can help understand how C# code is translated under the hood.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestBenefitOfIL()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.BenefitOfIL();

            Console.WriteLine("=== Question 6: Benefit of compiling into IL code? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("IL Code allows .NET to be platform-agnostic, compiling to the native environment with optimized performance.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestSupportsMultipleLanguages()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            bool result = coffeeDotnet.SupportsMultipleLanguages();

            Console.WriteLine("=== Question 7: Does .NET support multiple languages? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine(".NET supports languages like C#, F#, and VB.NET, making it versatile.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainCLR()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainCLR();

            Console.WriteLine("=== Question 8: What is CLR? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("The CLR is the core runtime, managing memory and execution, similar to a barista handling the coffee-making process.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainManagedAndUnmanagedCode()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainManagedAndUnmanagedCode();

            Console.WriteLine("=== Question 9: Managed vs. Unmanaged Code ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("Managed code runs within .NET's managed environment. Unmanaged code runs outside, without the CLR's memory management.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestImportanceOfGarbageCollector()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ImportanceOfGarbageCollector();

            Console.WriteLine("=== Question 10: Importance of Garbage Collector ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("The Garbage Collector automatically cleans up unused resources, helping prevent memory leaks and optimizing memory use.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestCanGarbageCollectorClaimUnmanagedObjects()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            bool result = coffeeDotnet.CanGarbageCollectorClaimUnmanagedObjects();

            Console.WriteLine("=== Question 11: Can Garbage Collector Claim Unmanaged Objects? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("The Garbage Collector cannot manage unmanaged resources. These need to be manually released to avoid memory issues.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainCTS()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainCTS();

            Console.WriteLine("=== Question 12: Importance of CTS (Common Type System) ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("CTS provides a consistent type system across .NET languages, ensuring compatibility between languages.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainCLS()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainCLS();

            Console.WriteLine("=== Question 13: Explain CLS (Common Language Specification) ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("CLS defines a subset of rules for language interoperability, making it easier for languages to communicate within .NET.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainStackVsHeap()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainStackVsHeap();

            Console.WriteLine("=== Question 14: Difference between Stack and Heap ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("The Stack is a quick-access memory storage for small data. The Heap is used for larger data that needs dynamic allocation.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainValueVsReferenceTypes()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainValueVsReferenceTypes();

            Console.WriteLine("=== Question 15: Value Types vs. Reference Types ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("Value types store data directly. Reference types store a reference to the data location.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainBoxingAndUnboxing()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainBoxingAndUnboxing();

            Console.WriteLine("=== Question 16: Explain Boxing and Unboxing ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("Boxing wraps a value type as an object. Unboxing extracts the value back from the object type.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestConsequenceOfBoxingAndUnboxing()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ConsequenceOfBoxingAndUnboxing();

            Console.WriteLine("=== Question 17: Consequence of Boxing and Unboxing ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("Boxing and unboxing add overhead, which can impact performance.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplainCasting()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplainCasting();

            Console.WriteLine("=== Question 18: Explain Casting, Implicit and Explicit ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("Casting changes data types. Implicit casting is safe and automatic, explicit casting may risk data loss.");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestExplicitCastingRisks()
        {
            var coffeeDotnet = new CoffeeAndDotnet();
            string result = coffeeDotnet.ExplicitCastingRisks();

            Console.WriteLine("=== Question 19: Risks of Explicit Casting ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("Explicit casting can lead to data loss or overflow if the target type is smaller.");
            Console.WriteLine("=============================================");
        }
    }
}
