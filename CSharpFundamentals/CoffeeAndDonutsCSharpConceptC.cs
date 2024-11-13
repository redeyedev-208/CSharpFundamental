using System;

namespace CSharpFundamentals
{
    public class CoffeeAndDonutsCSharpConceptC
    {
        // 41. Explain Inheritance
        public string InheritanceExplanation()
        {
            return "Inheritance defines the parent-child relationship.";
        }

        // 42. Explain virtual keyword
        public string VirtualKeywordExplanation()
        {
            return "Virtual Keyword helps us to define some logic in the parent class which can be overridden in the child class.";
        }

        // 43. What is overriding
        public string OverridingExplanation()
        {
            return "Methods having same name and same signature but are in different class and these classes must have the parent-child relationship.";
        }

        // 44. Explain overloading
        public string OverloadingExplanation()
        {
            return "Method overloading means same method names with different signature in the same class.";
        }

        // 45. Overloading vs Overriding
        public string OverloadingVsOverriding()
        {
            return "Overloading: Method with same names with different signatures in the same class.\n" +
                   "Overriding: Methods having same name and same signature but are in different class and these classes must have the parent-child relationship.";
        }

        // 46. What is polymorphism
        public string PolymorphismExplanation()
        {
            return "Polymorphism means the ability of an object to act differently under different conditions.";
        }

        // 47. Can polymorphism work without inheritance
        public string PolymorphismWithoutInheritance()
        {
            return "No, polymorphism requires inheritance.";
        }

        // 48. Explain static vs dynamic polymorphism
        public string StaticVsDynamicPolymorphism()
        {
            return "Static polymorphism is implemented by Method overloading.\n" +
                   "Dynamic polymorphism is implemented by Method overriding.";
        }

        // 49. Explain operator overloading
        public string OperatorOverloadingExplanation()
        {
            return "Operator overloading helps to redefine additional functionalities for plus, minus, multiplication and division.";
        }

        // 50. Why do we need Abstract classes
        public string AbstractClassExplanation()
        {
            return "Abstract class is a partially defined parent class.";
        }

        // 51. Are Abstract methods virtual
        public string AbstractMethodsVirtual()
        {
            return "Yes, abstract methods of the abstract class are by default virtual.";
        }

        // 52. Can we create an instance of Abstract classes
        public string CreateAbstractClassInstance()
        {
            return "No, we can't create an instance of an abstract class.";
        }

        // 53. Abstract Class vs Interface
        public string AbstractClassVsInterface()
        {
            return "In abstract class, some methods are defined, and some are not defined. In an interface, there are only empty methods.\n" +
                   "Interface vs Abstract Class:\n" +
                   "- Interface is a contract. Abstract class is a half-defined parent class.\n" +
                   "- Interface is for planning abstraction; abstract class is for sharing common logic in child classes.\n" +
                   "- Interface is implemented, abstract class is inherited.\n" +
                   "- Multiple inheritance is possible for interface but not for abstract class.";
        }

        // 54. Why do we need constructors?
        public string ConstructorExplanation()
        {
            return "Constructors are special methods that are invoked automatically when an instance of a class is created, and they are used to initialize variables.";
        }

        // 55. In parent-child, which constructor fires first?
        public string ParentChildConstructorOrder()
        {
            return "First, the parent constructor fires, then the child.";
        }

        // 56. How are initializers executed?
        public string InitializerExecutionOrder()
        {
            return "Initializers are executed first in the child, then in the parent.";
        }

        // 57. How are static constructors executed in Parent-Child?
        public string StaticConstructorExecutionOrder()
        {
            return "Static constructors are executed first in the child, then in the parent.";
        }

        // 58. When does a static constructor fire?
        public string StaticConstructorTiming()
        {
            return "A static constructor fires the first time the class is accessed.";
        }

        // 59. Explain Association, Aggregation, and Composition
        public string AssociationAggregationComposition()
        {
            return "Association indicates a dependency between objects. Aggregation and Composition are subsets of Association.\n" +
                   "- Aggregation: Part-whole relationship, independent lifetime, no ownership.\n" +
                   "- Composition: Part-whole relationship, dependent lifetime, parent object has ownership, death relationship.";
        }
    }
}
