using System;

namespace CSharpFundamentals
{
    public class CoffeeAndDotnet
    {
        public string ExplainDotNetAndCSharp()
        {
            // Answer: .NET is the framework (the coffee machine), while C# is a language used within .NET (like the coffee beans).
            return ".NET is the framework, like the coffee machine that brews everything together. C# is the language, like the coffee beans used to create your favorite cup.";
        }

        public string CompareDotNetVersions()
        {
            // Answer: .NET Framework is Windows-only, .NET Core is cross-platform, and .NET 5 is the unified version.
            return ".NET Framework is like a traditional coffee brewer, limited to certain beans (Windows). .NET Core is like a portable coffee maker—versatile and runs anywhere. .NET 5 is the upgraded machine, blending everything to make it streamlined.";
        }

        public string ExplainILCode()
        {
            // Answer: IL Code serves as an intermediate step before compilation to machine code, making it versatile across platforms.
            return "IL Code is like ground coffee, partially prepared, ready for the brewing process by the JIT (Just In Time) compiler.";
        }

        public string ExplainJIT()
        {
            // Answer: JIT compiles IL to machine code at runtime, adapting to the system it's running on for performance gains.
            return "JIT compiles IL code to machine language, like the hot water extracting flavor from coffee grounds to make the final drink.";
        }

        public string CanViewILCode()
        {
            // Answer: Yes, IL code can be viewed using tools like IL DASM.
            return "Yes, using tools like IL DASM, which is like inspecting the ground coffee before brewing.";
        }

        public string BenefitOfIL()
        {
            // Answer: IL Code allows .NET to be platform-agnostic, compiling to the native environment with optimized performance.
            return "IL code adapts to the runtime environment, optimizing your coffee brew temperature and flavor based on location.";
        }

        public bool SupportsMultipleLanguages()
        {
            // Answer: .NET supports multiple languages like C#, F#, etc., just as we can have different types of coffee beans.
            return true;
        }

        public string ExplainCLR()
        {
            // Answer: The CLR is the core runtime, managing memory and execution, similar to a barista handling the coffee-making process.
            return "CLR is like the barista, handling the brewing process, managing resources, and cleaning up (Garbage Collection).";
        }

        public string ExplainManagedAndUnmanagedCode()
        {
            // Answer: Managed code runs within .NET's managed environment. Unmanaged code runs outside, without the CLR's memory management.
            return "Managed code is brewed within .NET (like espresso), while unmanaged code is like a separate, non-coffee drink (think tea) that doesn’t use the CLR process.";
        }

        public string ImportanceOfGarbageCollector()
        {
            // Answer: The Garbage Collector automatically cleans up unused resources, helping prevent memory leaks and optimizing memory use.
            return "Garbage Collector cleans unused resources, like a barista clearing used coffee grounds.";
        }

        public bool CanGarbageCollectorClaimUnmanagedObjects()
        {
            // Answer: No, the garbage collector cannot claim unmanaged objects.
            return false; // Just as a barista can't clean up tea bags in a coffee shop.
        }

        public string ExplainCTS()
        {
            // Answer: CTS provides a consistent type system across .NET languages, ensuring compatibility between languages.
            return "CTS ensures that all .NET languages can share data types, like having a universal coffee recipe book so every barista makes the same brew.";
        }

        public string ExplainCLS()
        {
            // Answer: CLS defines a subset of rules for language interoperability, making it easier for languages to communicate within .NET.
            return "CLS is a set of rules ensuring .NET languages work together, like a shared coffee protocol so all cafes produce compatible flavors.";
        }

        public string ExplainStackVsHeap()
        {
            // Answer: Stack is like a quick-access shelf for essentials (primitive data types), while Heap is the storage room for larger items like whole bags of coffee beans (objects).
            return "Stack is like a quick-access shelf for essentials (primitive data types), while Heap is the storage room for larger items like whole bags of coffee beans (objects).";
        }

        public string ExplainValueVsReferenceTypes()
        {
            // Answer: Value types hold data directly (like a single-use coffee pod), while Reference types hold a pointer to data (like a reusable coffee filter that points to the grounds).
            return "Value types hold data directly (like a single-use coffee pod), while Reference types hold a pointer to data (like a reusable coffee filter that points to the grounds).";
        }

        public string ExplainBoxingAndUnboxing()
        {
            // Answer: Boxing wraps a value type into a reference type (like packaging single-serve coffee), while unboxing unwraps it back to a value type.
            return "Boxing wraps a value type into a reference type (like packaging single-serve coffee), while unboxing unwraps it back to a value type.";
        }

        public string ConsequenceOfBoxingAndUnboxing()
        {
            // Answer: Boxing and unboxing add extra steps, slowing performance, like repackaging coffee multiple times before use.
            return "Boxing and unboxing add extra steps, slowing performance, like repackaging coffee multiple times before use.";
        }

        public string ExplainCasting()
        {
            // Answer: Casting is like changing coffee sizes. Implicit casting goes from small to large (safe to upsize), while explicit casting shrinks the size, risking overflow (data loss).
            return "Casting is like changing coffee sizes. Implicit casting goes from small to large (safe to upsize), while explicit casting shrinks the size, risking overflow (data loss).";
        }

        public string ExplicitCastingRisks()
        {
            // Answer: Explicit casting risks data loss, like trying to fit a large brew into a small cup.
            return "Explicit casting risks data loss, like trying to fit a large brew into a small cup.";
        }
    }
}
