using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFundamentals
{
    public class CoffeeAndDotnetFiltering
    {
        private List<int> coffeeStrengths;

        // Constructor to initialize the list of coffee strengths
        public CoffeeAndDotnetFiltering(List<int> coffeeStrengths)
        {
            this.coffeeStrengths = coffeeStrengths ?? new List<int>();
        }

        // Method to filter mild coffees (even-strength coffees)
        public List<int> FilterMildCoffees()
        {
            // Use LINQ's Where method to filter even-strength coffees
            return coffeeStrengths.Where(strength => strength % 2 == 0).ToList();
        }

        // New method to filter positive even numbers
        public List<int> FilterPositiveEvenNumbers()
        {
            // Use LINQ's Where method to filter positive even numbers
            return coffeeStrengths.Where(num => num > 0 && num % 2 == 0).ToList();
        }
    }
}
