using System;
using Xunit;
using CSharpFundamentals;

namespace CSharpFundamentals.Tests
{
    public class CSharpCoffeeImaginedTests
    {
        private readonly CSharpCoffeeImagined _coffeeClass = new CSharpCoffeeImagined();

        [Fact]
        public void DrinkingCoffeeAllDay_ShouldOutputCorrectStatement()
        {
            // Arrange
            Console.WriteLine("=== Starting Test: DrinkingCoffeeAllDay ===");
            Console.WriteLine("Goal: To verify the method outputs the expected coffee statement.");

            // Act
            Console.WriteLine("Calling DrinkingCoffeeAllDay method...");
            _coffeeClass.DrinkingCoffeeAllDay();

            // Output expectation
            Console.WriteLine("Expected Output: 'I drink coffee every day and love dark roast the best.'\n");
            Console.WriteLine("Note: Please verify if the above output is displayed in the console during the test run.");
            Console.WriteLine("=== End of DrinkingCoffeeAllDay Test ===\n");
        }

        [Fact]
        public void ShowVariableExamples_ShouldDisplayVariableValues()
        {
            // Arrange
            Console.WriteLine("=== Starting Test: ShowVariableExamples ===");
            Console.WriteLine("Goal: To verify variable examples and data types display correctly.");

            // Act
            Console.WriteLine("Calling ShowVariableExamples method...");
            _coffeeClass.ShowVariableExamples();

            // Output expectation
            Console.WriteLine("Expected Output: Demonstration of different variable types (string, int, bool, etc.).");
            Console.WriteLine("Note: Please verify if the output matches variable examples displayed in the method.");
            Console.WriteLine("=== End of ShowVariableExamples Test ===\n");
        }

        [Fact]
        public void RecommendCoffee_ShouldReturnCorrectRecommendation()
        {
            // Arrange
            Console.WriteLine("=== Starting Test: RecommendCoffee ===");
            Console.WriteLine("Goal: To check if the coffee recommendation method returns expected results based on input preferences.");

            string strongPreference = "strong";
            string lightPreference = "light";
            string boldPreference = "bold";

            // Act
            Console.WriteLine("Calling RecommendCoffee method with preference: 'strong'...");
            var strongResult = _coffeeClass.RecommendCoffee(strongPreference);
            Console.WriteLine($"Output for 'strong': {strongResult}");

            Console.WriteLine("Calling RecommendCoffee method with preference: 'light'...");
            var lightResult = _coffeeClass.RecommendCoffee(lightPreference);
            Console.WriteLine($"Output for 'light': {lightResult}");

            Console.WriteLine("Calling RecommendCoffee method with preference: 'bold'...");
            var boldResult = _coffeeClass.RecommendCoffee(boldPreference);
            Console.WriteLine($"Output for 'bold': {boldResult}");

            // Expected Output
            Console.WriteLine("Expected Outputs:");
            Console.WriteLine("- For 'strong' preference: some coffee choice indicating strength.");
            Console.WriteLine("- For 'light' preference: some coffee choice indicating lightness.");
            Console.WriteLine("- For 'bold' preference: some coffee choice indicating boldness.");
            Console.WriteLine("Note: Please verify if each output matches expected coffee recommendations based on input preferences.");
            Console.WriteLine("=== End of RecommendCoffee Test ===\n");
        }
    }
}
