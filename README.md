# CSharp Fundamentals

This repository contains a collection of basic C# examples along with corresponding unit tests designed to help individuals prepare for coding interviews and improve their testing skills using .NET. 

## C# Overview

The project includes various fundamental C# methods, each accompanied by unit tests that demonstrate how to verify their correctness. This serves as a practical resource for both new and experienced developers looking to refresh their skills or prepare for interviews.

## Type System
- **Strongly Typed**: C# is a statically typed language, meaning variable types are known at compile time. This can lead to fewer runtime errors and allows for more optimized code.
  - **Advantages**: Early error detection, better performance, and clear documentation of variable types.
  - **Disadvantages**: Requires more boilerplate code and can slow down rapid prototyping.

## Object-Oriented Features
- C# has rich support for object-oriented programming (OOP), including inheritance, interfaces, polymorphism, and encapsulation.
  - **Advantages**: Encourages code reuse and design patterns.
  - **Disadvantages**: The OOP paradigm can sometimes be more complex to understand for beginners compared to functional or procedural approaches.

## Performance
- C# generally offers better performance for applications that require high speed or processing power (e.g., game development with Unity, enterprise applications).
  - **Advantages**: Just-In-Time (JIT) compilation and optimizations in the .NET framework.
  - **Disadvantages**: More complex memory management, though features like garbage collection alleviate some concerns.

## Framework and Libraries
- C# is often used with the .NET framework, providing a vast library of pre-built functions and tools for various applications.
  - **Advantages**: Strong support for Windows applications, web development with ASP.NET, and more.
  - **Disadvantages**: Less flexible when it comes to cross-platform compatibility, although .NET Core has improved this.

## Concurrency
- C# has robust support for multi-threading and asynchronous programming (e.g., async/await).
  - **Advantages**: Better suited for high-performance applications requiring concurrency.
  - **Disadvantages**: More complex than Python's simpler threading model.

## C# Overview in the Context of .NET and .NET Core

### C# and .NET Framework
- **Strongly Typed Language**: C# is a statically typed language, meaning that types are defined at compile time. This can help catch errors early in the development process and allows for more optimized code.
  
- **Object-Oriented Programming**: C# is built around OOP principles, which encourages the use of classes and objects, allowing for modular and reusable code. This structure can lead to better maintainability and scalability in large applications.

- **Rich Ecosystem**: The .NET Framework provides a comprehensive library of built-in functions for various tasks, ranging from data access to networking. This can significantly speed up development time by leveraging existing components.

### Transition to .NET Core
- **Cross-Platform Compatibility**: .NET Core has revolutionized C# development by enabling cross-platform capabilities. This means you can now run C# applications on Windows, macOS, and Linux, which was more limited in the traditional .NET Framework.

- **Performance Improvements**: .NET Core is designed for high performance and low overhead. The modular design allows developers to include only the necessary components, making applications faster and more efficient.

- **Decoupling Projects**: With .NET Core, you can structure your applications in a way that promotes decoupling. For example, separating your backend (C#) and frontend (React) into distinct projects can lead to faster development cycles. Each part of the application can be developed, tested, and deployed independently, improving collaboration and efficiency.

___

### Key Constraints and Considerations in C#
- **Type Safety and Strictness**: While the strong typing system of C# helps prevent many runtime errors, it can also lead to verbosity and the need for more boilerplate code. This can slow down rapid prototyping compared to dynamically typed languages.

- **Memory Management**: C# uses garbage collection to manage memory, which simplifies development but can introduce performance issues in scenarios requiring low-latency operations. Developers need to be aware of how and when memory is managed to optimize performance.

- **Dependency on the .NET Ecosystem**: While .NET Core provides great flexibility and performance, the overall experience is still tied to the .NET ecosystem. Understanding the nuances of the framework, including how it handles libraries and packages (e.g., NuGet), is crucial for effective development.

- **Concurrency and Asynchronous Programming**: C# supports multi-threading and asynchronous programming through features like async/await. While this is powerful for building responsive applications, it can introduce complexity in understanding how to manage state across threads and handle exceptions effectively.

### Practical Applications in a C# Development Context
- **Web Applications**: When developing web applications using ASP.NET Core, the ability to run C# on different platforms allows for greater flexibility in deployment and development environments. You can work on a macOS machine, for example, and develop applications that will run seamlessly on Windows servers.

- **Microservices Architecture**: C# and .NET Core are well-suited for microservices architecture. By decoupling services, each can be developed and maintained independently, enhancing scalability and resilience. This allows teams to use the best tools for their specific needs without being locked into a single framework.

- **Integration with Frontend Technologies**: Using C# with frameworks like React allows for a clean separation of concerns. The backend can handle business logic and data access, while the frontend focuses on user interaction and presentation. This separation can lead to better-organized codebases and faster development iterations.

___

### Key Features of this Repository

- **Basic Examples**: Implementations of common algorithms and utilities in C#.
- **Intermediate Examples**: Implementations of common algorithms and utilities in C#.
- **Difficult Examples**: Implementations of common algorithms and utilities in C#.
- **Unit Tests**: Comprehensive tests for each method, showcasing the use of xUnit for testing in .NET.
- **Detailed Logging**: Each method provides informative console output to illustrate the operations being performed.
- **Three test classes for testing practice**: Each class provides detailed logging to help walk through each method under test
- **Running individual test file**: Use this command and change the name of the test file under test `dotnet test --filter "FullyQualifiedName~CSharpFundamentals.Tests.CSharpCodingDSAlgosExamplesTests" --logger "console;verbosity=detailed"`
- **Running all the tests**:Use this command to run all of the test there should be a total of 184 tests `dotnet test --logger "console;verbosity=detailed"`

___

## Project Structure

CSharpFundamentals ├── CSharpFundamentals.sln # Solution file └── CSharpFundamentals.Tests # Test project containing unit tests

## Project Files

**Main Project: CSharpFundamentals.csproj**

```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```
- Target Framework: .NET 8.0
- Features: Implicit usings and nullable reference types enabled.

---

**Test Project: CSharpFundamentals.Tests.csproj**
```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <IsPackable>false</IsPackable>
    <IsTestProject>true</IsTestProject>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="coverlet.collector" Version="6.0.0" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.8.0" />
    <PackageReference Include="xunit" Version="2.5.3" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.5.3" />
  </ItemGroup>

  <ItemGroup>
    <Using Include="Xunit" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\CSharpFundamentals\CSharpFundamentals.csproj" />
  </ItemGroup>

</Project>
```
- <b>Target Framework:</b> .NET 8.0
- <b>Dependencies:</b>
  - coverlet.collector: For collecting code coverage data.
  - Microsoft.NET.Test.Sdk: Provides test execution support.
  - xunit: A popular testing framework for .NET.
  - xunit.runner.visualstudio: Integration with Visual Studio for running xUnit tests.

___

## Running the Tests
To run the tests in this project, you can use the following command in the terminal:
Make sure that you are in the tests directory to run the `dotnet test` comand

`dotnet test --logger "console;verbosity=detailed"`

The above command will run all of your tests. We have some extra information in the logging to help better understand what is going on for Visual Thinkers that sometimes have a challenge. 
I myself am a visual thinker and this helps me when working through test cases. 

Running a single test we can use:
`dotnet test --logger "console;verbosity=detailed" --filter "FullyQualifiedName~CSharpFundamentals.Tests.BasicExamplesTests.IsAllDigits_AllDigits_ReturnsTrue"`
Go to that test and switch the true to false and this test will fail. Return it and you'll see the failure. In fact it can be useful to switch one, two or all of them to get used to fixing tests. 
Isolating tests helps to ensure we are not receiving false positives.

___
## Test output for Basic Examples
The image below is a small section of what the test output should be. With the structure of this project you can feel free to add more to your own local environment to work on tests. 
This helps with what is needed when ensuring tests are passing before pushing to a repository in an enterprise project. 

![basic-examples-test-output](https://github.com/user-attachments/assets/d4e90c22-f58b-436f-95e0-283a4ab54c37)

___

## Examples of Basic Methods are as follows
- ReverseString: Reverses a given string.
- IsPalindrome: Checks if a given string is a palindrome.
- GenerateFibonacci: Generates Fibonacci numbers up to a specified count.
- SumArray: Calculates the sum of an array of integers.
- FindLargest: Finds the largest integer in an array.
- CountVowels: Counts the number of vowels in a string.
- RemoveDuplicates: Removes duplicate integers from an array.
- Power: Calculates the power of a base number raised to an exponent.
- IsAllDigits: Checks if a string contains only digits.
- CelciusToFahrenheit: Converts Celsius to Fahrenheit.
- CalculateAverage: Calculates the average of an array of integers.
- IsLeapYear: Determines if a year is a leap year.
- CountWords: Counts the number of words in a string.
- GenerateRandomNumber: Generates a random number within a specified range.
- SumOfDigits: Calculates the sum of the digits in an integer.

## Common Challenges in Online Coding Platform Assessments

While it may not seem like an issue at first glance, many individuals with disabilities—such as autism, dyslexia, ADHD, cognitive disabilities, and other forms of neurodivergence face significant challenges that online assessments often overlook. Problem statements can be misleading, and the way they are framed can greatly affect how individuals interpret and approach the challenges presented.

Understanding the connection between problem statements and their associated difficulty levels is crucial for navigating these assessments effectively. Below are some examples of common problem statements and strategies for breaking them down. 

My hope is that this resource provides support to others who, like me, encounter challenges due to invisible disabilities that may not be immediately apparent. By making coding assessments more inclusive, we can help reduce stress and create a more equitable environment for everyone, regardless of neurotype.


___

## Expanded Problem Statements with Related Problems
<b>Two Sum</b>

Common Problems:
- Three Sum: Find all unique triplets in an array that sum to zero.
- Two Sum II: Find two numbers such that they add up to a specific target (array is sorted).
- Subarray Sum Equals K: Find the number of continuous subarrays whose sum equals to K.
- Data Structures: Hash Map
- Edge Cases: Empty array, array with one element, negative numbers, large numbers.
- Time Complexity: O(n)
- Algorithmic Pattern: Hashing



<b>Reverse a String</b>

Common Problems:
- Reverse Words in a String: Given an input string, reverse the string word by word.
- Valid Palindrome: Check if a string is a palindrome.
- String Compression: Implement a method to compress strings by counting consecutive characters.
- Data Structures: Array, String (or List)
- Edge Cases: Empty string, single character, palindrome.
- Time Complexity: O(n)
- Algorithmic Pattern: Two Pointer Technique

<b>Valid Parentheses</b>

Common Problems:
- Generate Parentheses: Generate all combinations of well-formed parentheses.
- Longest Valid Parentheses: Find the length of the longest valid parentheses substring.
- Valid Mountain Array: Check if an array is a mountain array (increasing then decreasing).
- Data Structures: Stack
- Edge Cases: Empty string, strings with only opening/closing brackets, mismatched brackets.
- Time Complexity: O(n)
- Algorithmic Pattern: Stack

<b>Merge Intervals</b>

Common Problems:
- Insert Interval: Insert a new interval into a list of non-overlapping intervals and merge if necessary.
- Employee Free Time: Find the free time slots in a schedule.
- Meeting Rooms II: Find the minimum number of meeting rooms required.
- Data Structures: Array/List
- Edge Cases: No intervals, overlapping intervals, completely separate intervals.
- Time Complexity: O(n log n) (due to sorting)
- Algorithmic Pattern: Sorting, Greedy

<b>Group Anagrams</b>

- Common Problems:
- Anagram Mapping: Map each string to its sorted characters.
- Minimum Number of Steps to Make Two Strings Anagrams: Calculate the minimum number of steps to make two strings anagrams of each other.
- Longest Common Prefix: Find the longest common prefix string among an array of strings.
- Data Structures: Hash Map, List
- Edge Cases: Empty array, strings of varying lengths, special characters.
- Time Complexity: O(n * k log k), where n is the number of strings and k is the maximum length of a string.
- Algorithmic Pattern: Hashing

<b>Find Minimum in Rotated Sorted Array</b>

- Common Problems:
- Search in Rotated Sorted Array: Search for a target value in a rotated sorted array.
- Find Peak Element: Find a peak element in an array (element greater than its neighbors).
- Find K Closest Elements: Find k closest elements to a target in a sorted array.
- Data Structures: Array
- Edge Cases: Array of size 0 or 1, array that is not rotated.
- Time Complexity: O(log n) (using binary search)
- Algorithmic Pattern: Binary Search


<b>Climbing Stairs</b>

- Common Problems:
- Unique Paths: Count the number of unique paths from the top-left corner to the bottom-right corner of a grid.
- Minimum Path Sum: Find a path from the top-left to the bottom-right, minimizing the sum of the numbers.
- House Robber: Maximize the amount of money you can rob from houses, where adjacent houses cannot be robbed.
- Data Structures: Array (or can use variables for space optimization)
- Edge Cases: 0 or 1 steps, negative input (if applicable).
- Time Complexity: O(n)
- Algorithmic Pattern: Dynamic Programming


<b>Longest Substring Without Repeating Characters</b>

- Common Problems:
- Longest Repeating Character Replacement: Replace characters to achieve the longest substring with the same character.
- Find All Anagrams in a String: Find all start indices of anagrams of a pattern in a text.
- Minimum Window Substring: Find the smallest substring that contains all characters of another string.
- Data Structures: Hash Map, Array
- Edge Cases: Empty string, string with all unique characters.
- Time Complexity: O(n)
- Algorithmic Pattern: Sliding Window


<b>Product of Array Except Self</b>

- Common Problems:
- Max Product Subarray: Find the contiguous subarray within an array that has the largest product.
- Rotate Array: Rotate an array to the right by k steps.
- Best Time to Buy and Sell Stock: Find the maximum profit you can achieve from buying and selling stocks.
- Data Structures: Array
- Edge Cases: Array with zeros, array of size 0 or 1.
- Time Complexity: O(n)
- Algorithmic Pattern: Array Manipulation


<b>Maximum Subarray</b>

- Common Problems:
- Maximum Product Subarray: Find the contiguous subarray with the largest product.
- K-Concatenation Maximum Sum: Given an array, consider concatenating it k times and finding the maximum subarray sum.
- Subarray Sum Equals K: Count the number of subarrays that sum to a specific value.
- Data Structures: Array
- Edge Cases: All negative numbers, empty array.
- Time Complexity: O(n)
- Algorithmic Pattern: Dynamic Programming (Kadane's Algorithm)


<b>Height of Binary Tree</b>

- Common Problems:
- Symmetric Tree: Check if a tree is symmetric.
- Maximum Depth of Binary Tree: Find the maximum depth of a binary tree.
- Lowest Common Ancestor: Find the lowest common ancestor of two nodes in a binary tree.
- Data Structures: Tree
- Edge Cases: Empty tree, one-node tree.
- Time Complexity: O(n)
- Algorithmic Pattern: Recursion


<b>Kth Largest Element in an Array</b>

- Common Problems:
- Kth Smallest Element in a Sorted Matrix: Find the kth smallest element in a sorted 2D matrix.
- Top K Frequent Elements: Find the k most frequent elements in an array.
- Find Median from Data Stream: Design a data structure to find the median from a data stream.
- Data Structures: Array, Heap
- Edge Cases: Array with duplicate elements, k larger than the array size.
- Time Complexity: O(n log k) (using a min-heap)
- Algorithmic Pattern: Heap, QuickSelect


<b>Search in Rotated Sorted Array</b>

- Common Problems:
- Find Minimum in Rotated Sorted Array: Find the minimum element in a rotated sorted array.
- Find Peak Element: Find a peak element in an array.
- Count Occurrences of an Element: Count how many times a given element appears in a sorted array.
- Data Structures: Array
- Edge Cases: Empty array, target not present, array of size 1.
- Time Complexity: O(log n)
- Algorithmic Pattern: Binary Search


<b>Palindrome Linked List</b>

- Common Problems:
- Remove Nth Node From End of List: Remove the nth node from the end of a linked list.
- Merge Two Sorted Lists: Merge two sorted linked lists into one sorted list.
- Linked List Cycle II: Detect the start node of the cycle in a linked list.
- Data Structures: Linked List, Stack (optional)
- Edge Cases: Empty list, single-node list, two nodes without a cycle.
- Time Complexity: O(n)
- Algorithmic Pattern: Fast and Slow Pointer, Stack


<b>Diameter of Binary Tree</b>

- Common Problems:
- Maximum Depth of Binary Tree: Find the maximum depth of a binary tree.
- Path Sum: Determine if the tree has a root-to-leaf path such that the sum of the values along the path equals a target sum.
- Binary Tree Maximum Path Sum: Find the maximum path sum in a binary tree.
- Data Structures: Tree
- Edge Cases: Empty tree, single-node tree.
- Time Complexity: O(n)
- Algorithmic Pattern: Recursion

## Conclusion

Understanding C# within the context of .NET and .NET Core equips you with the tools to navigate its strengths and weaknesses effectively. Recognizing the advantages of cross-platform capabilities, performance enhancements, and the importance of project decoupling can lead to more efficient development practices and a more robust software architecture.

This repository aims to provide a granular understanding of C# to assist you in coding algorithms and tackling problems by choosing the best approaches that align with your personal preferences. I hope you find this resource useful! If it has made your learning experience a bit less stressful, please consider giving it a star. Cheers, and remember: the only limits we place on ourselves come from not accepting that we can't possibly know everything.

