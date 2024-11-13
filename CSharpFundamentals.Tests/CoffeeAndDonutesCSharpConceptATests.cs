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
            string expected = "Parameters    | Array                          | ArrayList                             \n" +
                              "-----------------------------------------------------------\n" +
                              "Fixed Length  | Yes                            | No (Flexible)                         \n" +
                              "Strongly Typed| Yes                            | No                                    \n" +
                              "Performance   | Better than ArrayList          | Slower because of boxing/unboxing     \n";

            // Informative console output
            Console.WriteLine("=== Testing Differentiate Array and ArrayList ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestArrayVsArrayListPerformance()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.ArrayVsArrayListPerformance();
            string expected = "Array is faster because it's strongly typed, like having a set recipe for coffee that doesn't need any adjustments. " +
                              "ArrayList is slower, like making custom coffee orders that require extra steps (boxing/unboxing).\n";

            // Informative console output
            Console.WriteLine("=== Testing Array vs ArrayList Performance ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestGenericCollections()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.GenericCollections();
            string expected = "Generic Collections are like a specialized coffee brew that only accepts a specific type of beans (strongly typed), but you can adjust the amount (flexible size). " +
                              "This makes them more efficient than ArrayList, where you might have to deal with many different kinds of beans in a single brew.\n";

            // Informative console output
            Console.WriteLine("=== Testing Generic Collections ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestThreads()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.Threads();
            string expected = "Threads are like multiple coffee makers running in parallel, making different cups of coffee at the same time. " +
                              "This helps speed up coffee production, especially when you have a lot of orders.\n";

            // Informative console output
            Console.WriteLine("=== Testing Threads ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestThreadsVsTPL()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.ThreadsVsTPL();
            string expected = "Threads are like different coffee makers working independently, while TPL is a manager who organizes the coffee makers efficiently, " +
                              "deciding which tasks (brewing) should be handled in parallel for the best efficiency.\n";

            // Informative console output
            Console.WriteLine("=== Testing Threads vs TPL ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestHandleExceptions()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.HandleExceptions();
            string expected = "In C#, try/catch is like preparing coffee and keeping an eye out for problems (exceptions). " +
                              "If something goes wrong (an exception), you catch it and decide how to fix it, like adjusting the grind or temperature to ensure a perfect cup.\n";

            // Informative console output
            Console.WriteLine("=== Testing Handle Exceptions ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestFinally()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.Finally();
            string expected = "The finally block is like cleaning up your coffee station after brewing. It runs no matter what, ensuring everything is in order, " +
                              "even if something went wrong with the coffee making process.\n";

            // Informative console output
            Console.WriteLine("=== Testing Finally Block ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestOutKeyword()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.OutKeyword();
            string expected = "The 'out' keyword is like offering a second cup of coffee to someone without knowing if they'll want it at first. " +
                              "It allows you to return multiple outputs, just like handing out multiple cups to a customer.\n";

            // Informative console output
            Console.WriteLine("=== Testing Out Keyword ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestDelegates()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.Delegates();
            string expected = "Delegates are like pointers to a function, allowing us to use callbacks to communicate between threads, " +
                              "like passing a brewing task to another coffee maker for a specific job.\n";

            // Informative console output
            Console.WriteLine("=== Testing Delegates ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestEvents()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.Events();
            string expected = "Events are encapsulations over delegates. They are like a coffee shop manager who listens to the needs of customers " +
                              "and triggers specific actions (brewing coffee) based on the customer's request.\n";

            // Informative console output
            Console.WriteLine("=== Testing Events ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }

        [Fact]
        public void TestAbstractVsInterface()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptA();
            string result = coffeeConcepts.AbstractVsInterface();
            string expected = "An abstract class is like a half-defined coffee recipe where you can customize some steps, while an interface is a contract " +
                              "that defines what must be done but not how (like a menu of available coffee drinks that must be followed).\n";

            // Informative console output
            Console.WriteLine("=== Testing Abstract vs Interface ===");
            Console.WriteLine("Expected Output:");
            Console.WriteLine(expected);

            // Act & Assert
            Assert.Equal(expected, result);

            // Output the result
            Console.WriteLine("Actual Output:");
            Console.WriteLine(result);
            Console.WriteLine("=============================================");
        }
    }
}
