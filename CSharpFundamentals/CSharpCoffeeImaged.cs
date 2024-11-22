using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class CSharpCoffeeImagined
    {
        // 1. Introduction to C# with `DrinkingCoffeeAllDay` Method
        // C# uses curly braces `{}` for code blocks and semicolons `;` at the end of statements.
        // Developed by Microsoft and now open-source with .NET Core.
        public void DrinkingCoffeeAllDay()
        {
            Console.WriteLine("I drink coffee every day and love dark roast the best.");
        }

        // 2. Variables and Data Types
        // Declaring variables with different types, showing how `var` works in C# vs. JavaScript.
        public void ShowVariableExamples()
        {
            int cupsPerDay = 3;                  // Integer
            string coffeeType = "Dark Roast";    // String
            double pricePerCup = 2.50;           // Double
            bool needsMilk = false;              // Boolean
            var roastDescription = "Smooth";     // Var - inferred as String

            Console.WriteLine($"Cups: {cupsPerDay}, Coffee Type: {coffeeType}, Price: {pricePerCup}, Needs Milk: {needsMilk}, Description: {roastDescription}");
        }

        // 3. Class, Struct, and Record Data Types
        // Each of these data types has different usage patterns and performance characteristics.

        // Class - reference type, best for complex objects
        public class Coffee
        {
            public string BeanType { get; set; }
            public string Roast { get; set; }
            public Coffee(string beanType, string roast)
            {
                BeanType = beanType;
                Roast = roast;
            }
            public override string ToString() => $"{Roast} roast made from {BeanType} beans";
        }

        // Struct - value type, efficient for small data pieces
        public struct CoffeeSize
        {
            public int Milliliters;
            public string Description;
            public CoffeeSize(int milliliters, string description)
            {
                Milliliters = milliliters;
                Description = description;
            }
        }

        // Record - immutable, concise, great for representing data
        public record CoffeeOrder(string Customer, string CoffeeType, bool HasSugar);

        // 4. Access Modifiers and Inheritance Example
        // Classes can have public, private, protected, and internal modifiers to control access.
        // Here, we show inheritance by extending a base Coffee class.
        public class CoffeeBase
        {
            protected string BrewMethod { get; set; }
            public CoffeeBase(string brewMethod) => BrewMethod = brewMethod;
        }

        public class Espresso : CoffeeBase
        {
            public Espresso() : base("Espresso Machine") { }
            public void Brew()
            {
                Console.WriteLine($"Brewing with: {BrewMethod}");
            }
        }

        // 5. Interface Example - Defining a Contract
        public interface ICoffee
        {
            string Type { get; }
            void Brew();
        }

        public class Latte : ICoffee
        {
            public string Type => "Latte";
            public void Brew()
            {
                Console.WriteLine($"Brewing a {Type} with steamed milk.");
            }
        }

        // 6. Abstract Class Example - Implementing Common Functionality
        public abstract class Beverage
        {
            public abstract string DrinkType { get; }
            public abstract void Serve();
        }

        public class IcedCoffee : Beverage
        {
            public override string DrinkType => "Iced Coffee";
            public override void Serve()
            {
                Console.WriteLine($"Serving a chilled {DrinkType}.");
            }
        }

        // 7. Readonly Properties with Lambda Expressions
        public class CoffeePreference
        {
            public string FavoriteBlend { get; }
            public CoffeePreference(string favoriteBlend) => FavoriteBlend = favoriteBlend;
            public string Preference => $"{FavoriteBlend} is my favorite blend!";
        }

        // 8. Control Flow: if, else if, switch
        public string RecommendCoffee(string preference)
        {
            if (preference == "strong")
            {
                return "Try an Espresso!";
            }
            else if (preference == "light")
            {
                return "How about a Light Roast?";
            }
            else
            {
                return preference switch
                {
                    "bold" => "Dark Roast all the way!",
                    "decaf" => "Decaf for the evening.",
                    _ => "House blend is always a safe bet."
                };
            }
        }

        // 9. Collections: List, Dictionary, and Queue
        public void ShowCollections()
        {
            var coffeeList = new List<string> { "Espresso", "Latte", "Cappuccino" };
            var coffeeStock = new Dictionary<string, int> { { "Espresso", 10 }, { "Latte", 5 } };
            var coffeeQueue = new Queue<string>();
            coffeeQueue.Enqueue("Americano");

            Console.WriteLine($"Coffee List: {string.Join(", ", coffeeList)}");
            Console.WriteLine($"Coffee Stock: {string.Join(", ", coffeeStock)}");
            Console.WriteLine($"Coffee Queue: {string.Join(", ", coffeeQueue)}");
        }

        // 10. Async/Await Example
        public async Task<string> CoolDownCoffeeAsync()
        {
            await Task.Delay(2000); // Simulate waiting
            return "Coffee is now cool enough to drink.";
        }

        // 11. Generics Example
        public T ServeGeneric<T>(T coffeeType)
        {
            Console.WriteLine($"Serving a {coffeeType}.");
            return coffeeType;
        }
    }
}
