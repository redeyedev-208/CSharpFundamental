using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class CoffeeAndDonutsCSharpConceptB
    {
        // Question 31 - What is a Delegate and how to create a Delegate?
        public string DelegateExplanation()
        {
            return "Delegate is a pointer to a function. " +
                   "We can create a delegate in two steps:\n" +
                   "Step 1: Declare the delegate.\n" +
                   "[Access modifier] delegate [return type] [delegate name] ([parameters])\n" +
                   "For example:\n" +
                   "public delegate void methodName(string message);\n" +
                   "Step 2: Create an instance of the delegate.\n" +
                   "public methodName publisher = null;\n";
        }

        // Question 32 - Where have you used Delegates?
        public string WhereToUseDelegates()
        {
            return "Delegates are useful wherever we need non-blocking calls and want to communicate back asynchronously. " +
                   "Some examples include HTTP calls, File Search, Task Schedulers, and so on.\n";
        }

        // Question 33 - What is a Multicast Delegate?
        public string MulticastDelegateExplanation()
        {
            return "A multicast delegate allows multiple functions to be attached to a single delegate, so that when the delegate is called, " +
                   "it invokes all the functions attached to it.\n";
        }

        // Question 34 - What is an Event?
        public string EventExplanation()
        {
            return "An event uses delegates internally. It encapsulates delegates to make them safer and ensures that only the publisher can trigger the event.\n";
        }

        // Question 35 - How to Create an Event?
        public string CreateEvent()
        {
            return "To create an event, we use the event keyword. The syntax is as follows:\n" +
                   "[Access modifier] event [delegate name] Variable_Name;\n" +
                   "For example:\n" +
                   "public delegate void delegateName(string search); // delegate\n" +
                   "public event delegateName Variable_Name = null; // event\n";
        }

        // Question 36 - Delegate VS Events
        public string DelegateVsEvent()
        {
            return "It’s unfair to compare delegates and events directly, as events use delegates internally. " +
                   "Events encapsulate delegates to create a publisher-subscriber model. In real-time applications, delegates are rarely used directly, " +
                   "and are mostly used in the form of events.\n";
        }

        // Question 37 - Why do we need Object-Oriented Programming (OOP)?
        public string WhyOOPIsNeeded()
        {
            return "Object-Oriented Programming (OOP) helps us think about real-world objects and is essential for solving real-world problems. " +
                   "It allows for better modeling, reusability, and maintainability of code.\n";
        }

        // Question 38 - What are the important pillars of OOP?
        public string OOPPillars()
        {
            return "The four important pillars of Object-Oriented Programming (OOP) are:\n" +
                   "1. Abstraction\n" +
                   "2. Polymorphism\n" +
                   "3. Inheritance\n" +
                   "4. Encapsulation\n";
        }

        // Question 39 - What is a class and object?
        public string ClassAndObjectExplanation()
        {
            return "A class is a type or blueprint for creating objects. It defines the properties and behaviors that objects created from the class will have.\n" +
                   "An object is an instance of a class. It represents a specific entity with its own values and behaviors defined by the class.\n";
        }

        // Question 40 - Abstraction vs Encapsulation
        public string AbstractionVsEncapsulation()
        {
            return "Abstraction is the concept of hiding the complexity and showing only the essential features of an object. " +
                   "It helps reduce complexity by focusing on what is necessary.\n" +
                   "Encapsulation, on the other hand, involves hiding the internal details of an object and restricting access to certain components, " +
                   "thus providing data protection and enhancing modularity.\n";
        }
    }
}