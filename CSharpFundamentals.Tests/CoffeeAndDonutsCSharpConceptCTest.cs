using System;
using Xunit;

namespace CSharpFundamentals.Tests
{
    public class CoffeeAndDonutsCSharpConceptCTests
    {
        [Fact]
        public void TestInheritanceExplanation()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "Inheritance defines the parent-child relationship.";

            // Act
            string result = coffeeConcepts.InheritanceExplanation();

            // Assert
            Console.WriteLine("=== Testing Inheritance Explanation ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestVirtualKeywordExplanation()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "Virtual Keyword helps us to define some logic in the parent class which can be overridden in the child class.";

            // Act
            string result = coffeeConcepts.VirtualKeywordExplanation();

            // Assert
            Console.WriteLine("=== Testing Virtual Keyword Explanation ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAbstractClassVsInterface()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "In abstract class, some methods are defined, and some are not defined. In an interface, there are only empty methods.\n" +
                              "Interface vs Abstract Class:\n" +
                              "- Interface is a contract. Abstract class is a half-defined parent class.\n" +
                              "- Interface is for planning abstraction; abstract class is for sharing common logic in child classes.\n" +
                              "- Interface is implemented, abstract class is inherited.\n" +
                              "- Multiple inheritance is possible for interface but not for abstract class.";

            // Act
            string result = coffeeConcepts.AbstractClassVsInterface();

            // Assert
            Console.WriteLine("=== Testing Abstract Class vs Interface ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestConstructorExplanation()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "Constructors are special methods that are invoked automatically when an instance of a class is created, and they are used to initialize variables.";

            // Act
            string result = coffeeConcepts.ConstructorExplanation();

            // Assert
            Console.WriteLine("=== Testing Constructor Explanation ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestParentChildConstructorOrder()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "First, the parent constructor fires, then the child.";

            // Act
            string result = coffeeConcepts.ParentChildConstructorOrder();

            // Assert
            Console.WriteLine("=== Testing Parent-Child Constructor Order ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestInitializerExecutionOrder()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "Initializers are executed first in the child, then in the parent.";

            // Act
            string result = coffeeConcepts.InitializerExecutionOrder();

            // Assert
            Console.WriteLine("=== Testing Initializer Execution Order ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestStaticConstructorExecutionOrder()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "Static constructors are executed first in the child, then in the parent.";

            // Act
            string result = coffeeConcepts.StaticConstructorExecutionOrder();

            // Assert
            Console.WriteLine("=== Testing Static Constructor Execution Order ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestStaticConstructorTiming()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "A static constructor fires the first time the class is accessed.";

            // Act
            string result = coffeeConcepts.StaticConstructorTiming();

            // Assert
            Console.WriteLine("=== Testing Static Constructor Timing ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAssociationAggregationComposition()
        {
            // Arrange
            var coffeeConcepts = new CoffeeAndDonutsCSharpConceptC();
            string expected = "Association indicates a dependency between objects. Aggregation and Composition are subsets of Association.\n" +
                              "- Aggregation: Part-whole relationship, independent lifetime, no ownership.\n" +
                              "- Composition: Part-whole relationship, dependent lifetime, parent object has ownership, death relationship.";

            // Act
            string result = coffeeConcepts.AssociationAggregationComposition();

            // Assert
            Console.WriteLine("=== Testing Association, Aggregation, and Composition ===");
            Console.WriteLine($"Expected: {expected}\nActual: {result}");
            Assert.Equal(expected, result);
        }
    }
}
