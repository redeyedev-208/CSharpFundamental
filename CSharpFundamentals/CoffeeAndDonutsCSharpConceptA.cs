using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class CoffeeAndDonutsCSharpConceptA
    {
        // Question 20: Differentiate between Array and ArrayList
        public string DifferentiateArrayAndArrayList()
        {
            return "Parameters    | Array                          | ArrayList                             \n" +
                   "-----------------------------------------------------------\n" +
                   "Fixed Length  | Yes                            | No (Flexible)                         \n" +
                   "Strongly Typed| Yes                            | No                                    \n" +
                   "Performance   | Better than ArrayList          | Slower because of boxing/unboxing     \n";
        }


        // Question 21: Which performance is better, Array or ArrayList?
        public string ArrayVsArrayListPerformance()
        {
            return "Array is faster because it's strongly typed, like having a set recipe for coffee that doesn't need any adjustments. " +
                   "ArrayList is slower, like making custom coffee orders that require extra steps (boxing/unboxing).\n";
        }

        // Question 22: What are Generic Collections?
        public string GenericCollections()
        {
            return "Generic Collections are like a specialized coffee brew that only accepts a specific type of beans (strongly typed), but you can adjust the amount (flexible size). " +
                   "This makes them more efficient than ArrayList, where you might have to deal with many different kinds of beans in a single brew.\n";
        }

        // Question 23: What are threads (Multithreading)?
        public string Threads()
        {
            return "Threads are like multiple coffee makers running in parallel, making different cups of coffee at the same time. " +
                   "This helps speed up coffee production, especially when you have a lot of orders.\n";
        }

        // Question 24: How are threads different from TPL (Task Parallel Library)?
        public string ThreadsVsTPL()
        {
            return "Threads are like different coffee makers working independently, while TPL is a manager who organizes the coffee makers efficiently, " +
                   "deciding which tasks (brewing) should be handled in parallel for the best efficiency.\n";
        }

        // Question 25: How do we handle exceptions in C# (try/catch)?
        public string HandleExceptions()
        {
            return "In C#, try/catch is like preparing coffee and keeping an eye out for problems (exceptions). " +
                   "If something goes wrong (an exception), you catch it and decide how to fix it, like adjusting the grind or temperature to ensure a perfect cup.\n";
        }

        // Question 26: What is the need of finally?
        public string Finally()
        {
            return "The finally block is like cleaning up your coffee station after brewing. It runs no matter what, ensuring everything is in order, " +
                   "even if something went wrong with the coffee making process.\n";
        }

        // Question 27: Why do we need the out keyword?
        public string OutKeyword()
        {
            return "The 'out' keyword is like offering a second cup of coffee to someone without knowing if they'll want it at first. " +
                   "It allows you to return multiple outputs, just like handing out multiple cups to a customer.\n";
        }
    }
}
