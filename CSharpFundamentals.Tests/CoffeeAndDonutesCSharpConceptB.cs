using System;
using Xunit;

namespace CSharpFundamentals.Tests
{
    public class CoffeeAndDonutsCSharpConceptBTests
    {
        [Fact]
        public void TestDelegateExplanation()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.DelegateExplanation();
            string expected = "Delegate is a pointer to a function. We can create a delegate in two steps:\nStep 1: Declare the delegate.\n[Access modifier] delegate [return type] [delegate name] ([parameters])\nFor example:\npublic delegate void methodName(string message);\nStep 2: Create an instance of the delegate.\npublic methodName publisher = null;\n";

            // Informative console output
            Console.WriteLine("=== Testing Delegate Explanation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWhereToUseDelegates()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.WhereToUseDelegates();
            string expected = "Delegates are useful wherever we need non-blocking calls and want to communicate back asynchronously. Some examples include HTTP calls, File Search, Task Schedulers, and so on.\n";

            // Informative console output
            Console.WriteLine("=== Testing Where to Use Delegates ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMulticastDelegateExplanation()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.MulticastDelegateExplanation();
            string expected = "A multicast delegate allows multiple functions to be attached to a single delegate, so that when the delegate is called, it invokes all the functions attached to it.\n";

            // Informative console output
            Console.WriteLine("=== Testing Multicast Delegate Explanation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestEventExplanation()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.EventExplanation();
            string expected = "An event uses delegates internally. It encapsulates delegates to make them safer and ensures that only the publisher can trigger the event.\n";

            // Informative console output
            Console.WriteLine("=== Testing Event Explanation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCreateEvent()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.CreateEvent();
            string expected = "To create an event, we use the event keyword. The syntax is as follows:\n[Access modifier] event [delegate name] Variable_Name;\nFor example:\npublic delegate void delegateName(string search); // delegate\npublic event delegateName Variable_Name = null; // event\n";

            // Informative console output
            Console.WriteLine("=== Testing Create Event ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestDelegateVsEvent()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.DelegateVsEvent();
            string expected = "It’s unfair to compare delegates and events directly, as events use delegates internally. Events encapsulate delegates to create a publisher-subscriber model. In real-time applications, delegates are rarely used directly, and are mostly used in the form of events.\n";

            // Informative console output
            Console.WriteLine("=== Testing Delegate vs Event ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestWhyOOPIsNeeded()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.WhyOOPIsNeeded();
            string expected = "Object-Oriented Programming (OOP) helps us think about real-world objects and is essential for solving real-world problems. It allows for better modeling, reusability, and maintainability of code.\n";

            // Informative console output
            Console.WriteLine("=== Testing Why OOP is Needed ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestOOPPillars()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.OOPPillars();
            string expected = "The four important pillars of Object-Oriented Programming (OOP) are:\n1. Abstraction\n2. Polymorphism\n3. Inheritance\n4. Encapsulation\n";

            // Informative console output
            Console.WriteLine("=== Testing OOP Pillars ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestClassAndObjectExplanation()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.ClassAndObjectExplanation();
            string expected = "A class is a type or blueprint for creating objects. It defines the properties and behaviors that objects created from the class will have.\nAn object is an instance of a class. It represents a specific entity with its own values and behaviors defined by the class.\n";

            // Informative console output
            Console.WriteLine("=== Testing Class and Object Explanation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAbstractionVsEncapsulation()
        {
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptB();
            string result = coffeeConcepts.AbstractionVsEncapsulation();
            string expected = "Abstraction is the concept of hiding the complexity and showing only the essential features of an object. It helps reduce complexity by focusing on what is necessary.\nEncapsulation, on the other hand, involves hiding the internal details of an object and restricting access to certain components, thus providing data protection and enhancing modularity.\n";

            // Informative console output
            Console.WriteLine("=== Testing Abstraction vs Encapsulation ===");
            Console.WriteLine($"Expected: {expected}");
            Console.WriteLine($"Actual: {result}");
            Assert.Equal(expected, result);
        }
    }
}
