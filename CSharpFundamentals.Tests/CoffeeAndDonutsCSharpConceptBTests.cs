using System;
using Xunit;

namespace CSharpFundamentals.Tests
{
    public class CoffeeAndDonutsCSharpConceptBTests
    {
        [Fact]
        public void TestDelegateExplanation()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "Delegate is a pointer to a function. We can create a delegate in two steps:\n" +
                              "Step 1: Declare the delegate.\n" +
                              "[Access modifier] delegate [return type] [delegate name] ([parameters])\n" +
                              "For example:\n" +
                              "public delegate void methodName(string message);\n" +
                              "Step 2: Create an instance of the delegate.\n" +
                              "public methodName publisher = null;\n";

            // Act
            string result = coffeeConcepts.DelegateExplanation();

            // Assert with console output
            Console.WriteLine("=== Testing Delegate Explanation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWhereToUseDelegates()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "Delegates are useful wherever we need non-blocking calls and want to communicate back asynchronously. Some examples include HTTP calls, File Search, Task Schedulers, and so on.\n";

            // Act
            string result = coffeeConcepts.WhereToUseDelegates();

            // Assert with console output
            Console.WriteLine("=== Testing Where to Use Delegates ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMulticastDelegateExplanation()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "A multicast delegate allows multiple functions to be attached to a single delegate, so that when the delegate is called, it invokes all the functions attached to it.\n";

            // Act
            string result = coffeeConcepts.MulticastDelegateExplanation();

            // Assert with console output
            Console.WriteLine("=== Testing Multicast Delegate Explanation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestEventExplanation()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "An event uses delegates internally. It encapsulates delegates to make them safer and ensures that only the publisher can trigger the event.\n";

            // Act
            string result = coffeeConcepts.EventExplanation();

            // Assert with console output
            Console.WriteLine("=== Testing Event Explanation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCreateEvent()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "To create an event, we use the event keyword. The syntax is as follows:\n" +
                              "[Access modifier] event [delegate name] Variable_Name;\n" +
                              "For example:\n" +
                              "public delegate void delegateName(string search); // delegate\n" +
                              "public event delegateName Variable_Name = null; // event\n";

            // Act
            string result = coffeeConcepts.CreateEvent();

            // Assert with console output
            Console.WriteLine("=== Testing Create Event ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestDelegateVsEvent()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "It’s unfair to compare delegates and events directly, as events use delegates internally. Events encapsulate delegates to create a publisher-subscriber model. In real-time applications, delegates are rarely used directly, and are mostly used in the form of events.\n";

            // Act
            string result = coffeeConcepts.DelegateVsEvent();

            // Assert with console output
            Console.WriteLine("=== Testing Delegate vs Event ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWhyOOPIsNeeded()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "Object-Oriented Programming (OOP) helps us think about real-world objects and is essential for solving real-world problems. It allows for better modeling, reusability, and maintainability of code.\n";

            // Act
            string result = coffeeConcepts.WhyOOPIsNeeded();

            // Assert with console output
            Console.WriteLine("=== Testing Why OOP is Needed ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestOOPPillars()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "The four important pillars of Object-Oriented Programming (OOP) are:\n1. Abstraction\n2. Polymorphism\n3. Inheritance\n4. Encapsulation\n";

            // Act
            string result = coffeeConcepts.OOPPillars();

            // Assert with console output
            Console.WriteLine("=== Testing OOP Pillars ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestClassAndObjectExplanation()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "A class is a type or blueprint for creating objects. It defines the properties and behaviors that objects created from the class will have.\n" +
                              "An object is an instance of a class. It represents a specific entity with its own values and behaviors defined by the class.\n";

            // Act
            string result = coffeeConcepts.ClassAndObjectExplanation();

            // Assert with console output
            Console.WriteLine("=== Testing Class and Object Explanation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAbstractionVsEncapsulation()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string expected = "Abstraction is the concept of hiding the complexity and showing only the essential features of an object. It helps reduce complexity by focusing on what is necessary.\n" +
                              "Encapsulation, on the other hand, involves hiding the internal details of an object and restricting access to certain components, thus providing data protection and enhancing modularity.\n";

            // Act
            string result = coffeeConcepts.AbstractionVsEncapsulation();

            // Assert with console output
            Console.WriteLine("=== Testing Abstraction vs Encapsulation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }
    }
}
