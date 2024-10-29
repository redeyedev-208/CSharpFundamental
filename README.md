# CSharp Fundamentals

This repository contains a collection of basic C# examples along with corresponding unit tests designed to help individuals prepare for coding interviews and improve their testing skills using .NET. 

## Overview

The project includes various fundamental C# methods, each accompanied by unit tests that demonstrate how to verify their correctness. This serves as a practical resource for both new and experienced developers looking to refresh their skills or prepare for interviews.

### Key Features

- **Basic Examples**: Implementations of common algorithms and utilities in C#.
- **Unit Tests**: Comprehensive tests for each method, showcasing the use of xUnit for testing in .NET.
- **Detailed Logging**: Each method provides informative console output to illustrate the operations being performed.

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

## Examples of Intermediate Methods are as follows (Coming soon)
