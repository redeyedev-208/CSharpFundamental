using System;
using Xunit;

namespace CSharpFundamentals.Tests
{
    public class CoffeeAndDonutsCSharpConceptATests
    {
        [Fact]
        public void TestDifferentiateArrayAndArrayList()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.DifferentiateArrayAndArrayList();

            Console.WriteLine("=== Question 20: Differentiate between Array and ArrayList ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestArrayVsArrayListPerformance()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.ArrayVsArrayListPerformance();

            Console.WriteLine("=== Question 21: Which performance is better, Array or ArrayList? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestGenericCollections()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.GenericCollections();

            Console.WriteLine("=== Question 22: What are Generic Collections? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestThreads()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.Threads();

            Console.WriteLine("=== Question 23: What are threads (Multithreading)? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestThreadsVsTPL()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.ThreadsVsTPL();

            Console.WriteLine("=== Question 24: How are threads different from TPL (Task Parallel Library)? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestHandleExceptions()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.HandleExceptions();

            Console.WriteLine("=== Question 25: How do we handle exceptions in C# (try/catch)? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestFinally()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.Finally();

            Console.WriteLine("=== Question 26: What is the need of finally? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestOutKeyword()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.OutKeyword();

            Console.WriteLine("=== Question 27: Why do we need the out keyword? ===");
            Console.WriteLine($"Answer: {result}");
            Console.WriteLine("=============================================");
        }
    }
}
