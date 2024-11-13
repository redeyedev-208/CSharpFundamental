using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class CoffeeAndDotnet
    {
        // Sometimes going over stuff for a refresher or learning it for the first time can seem like a time sync
        // That is a normal feeling just relate it to something you like, for me I love coffee and hopefully this helps
        // These are interview questions and the play with the and change things around, change values to make tests break and fix them
        // With this type of exposure it can help with debugging and seeing common errors. 
        // The next set of questions will be a bit more involved and will cover more code as examples
        public string ExplainDotNetAndCSharp()
        {
            // Question 1: Difference between .NET and C#
            return ".NET is the framework, like the coffee machine that brews everything together. C# is the language, like the coffee beans used to create your favorite cup.";
        }

        public string CompareDotNetVersions()
        {
            // Question 2: .NET Framework vs .NET Core vs .NET 5.0
            return ".NET Framework is like a traditional coffee brewer, limited to certain beans (Windows). .NET Core is like a portable coffee maker—versatile and runs anywhere. .NET 5 is the upgraded machine, blending everything to make it streamlined.";
        }

        public string ExplainILCode()
        {
            // Question 3: What is IL (Intermediate Language) Code?
            return "IL Code is like ground coffee, partially prepared, ready for the brewing process by the JIT (Just In Time) compiler.";
        }

        public string ExplainJIT()
        {
            // Question 4: What is the use of JIT?
            return "JIT compiles IL code to machine language, like the hot water extracting flavor from coffee grounds to make the final drink.";
        }

        public string CanViewILCode()
        {
            // Question 5: Is it possible to view IL code?
            return "Yes, using tools like IL DASM, which is like inspecting the ground coffee before brewing.";
        }

        public string BenefitOfIL()
        {
            // Question 6: Benefit of compiling into IL code?
            return "IL code adapts to the runtime environment, optimizing your coffee brew temperature and flavor based on location.";
        }

        public bool SupportsMultipleLanguages()
        {
            // Question 7: Does .NET support multiple languages?
            return true; // Multiple languages like C#, F#, etc., just as we can have different types of coffee beans.
        }

        public string ExplainCLR()
        {
            // Question 8: What is CLR?
            return "CLR is like the barista, handling the brewing process, managing resources, and cleaning up (Garbage Collection).";
        }

        public string ExplainManagedAndUnmanagedCode()
        {
            // Question 9: Managed vs. Unmanaged code
            return "Managed code is brewed within .NET (like espresso), while unmanaged code is like a separate, non-coffee drink (think tea) that doesn’t use the CLR process.";
        }

        public string ImportanceOfGarbageCollector()
        {
            // Question 10: Importance of Garbage Collector
            return "Garbage Collector cleans unused resources, like a barista clearing used coffee grounds.";
        }

        public bool CanGarbageCollectorClaimUnmanagedObjects()
        {
            // Question 11: Can garbage collector claim unmanaged objects?
            return false; // Just as a barista can't clean up tea bags in a coffee shop.
        }

        public string ExplainCTS()
        {
            // Question 12: Importance of CTS (Common Type System)
            return "CTS ensures that all .NET languages can share data types, like having a universal coffee recipe book so every barista makes the same brew.";
        }

        public string ExplainCLS()
        {
            // Question 13: Explain CLS (Common Language Specification)
            return "CLS is a set of rules ensuring .NET languages work together, like a shared coffee protocol so all cafes produce compatible flavors.";
        }

        public string ExplainStackVsHeap()
        {
            // Question 14: Difference between Stack and Heap
            return "Stack is like a quick-access shelf for essentials (primitive data types), while Heap is the storage room for larger items like whole bags of coffee beans (objects).";
        }

        public string ExplainValueVsReferenceTypes()
        {
            // Question 15: Value types vs Reference types
            return "Value types hold data directly (like a single-use coffee pod), while Reference types hold a pointer to data (like a reusable coffee filter that points to the grounds).";
        }

        public string ExplainBoxingAndUnboxing()
        {
            // Question 16: Explain Boxing and Unboxing
            return "Boxing wraps a value type into a reference type (like packaging single-serve coffee), while unboxing unwraps it back to a value type.";
        }

        public string ConsequenceOfBoxingAndUnboxing()
        {
            // Question 17: Consequence of Boxing and Unboxing
            return "Boxing and unboxing add extra steps, slowing performance, like repackaging coffee multiple times before use.";
        }

        public string ExplainCasting()
        {
            // Question 18: Explain Casting, Implicit and Explicit Casting
            return "Casting is like changing coffee sizes. Implicit casting goes from small to large (safe to upsize), while explicit casting shrinks the size, risking overflow (data loss).";
        }

        public string ExplicitCastingRisks()
        {
            // Question 19: What can happen during explicit casting?
            return "Explicit casting risks data loss, like trying to fit a large brew into a small cup.";
        }
    }
}

