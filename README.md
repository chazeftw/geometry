# Determine triangle types
Small exercise with a minor set of specifications to determine triangle types based on input.

## Project description
> Write a program that can determine the type of a triangle.
The solution must take three sides of a triangle as input parameters and return whether the triangle is equilateral, isosceles or scalene. Consider test, validation and potential errors.

The project is a console application written in C#, utilizing dependency injection and various sensible patterns.

As the description is very vague, it was necessary to think in a larger picture. The main challenge was to isolate the triangle type classifications in small self-contained components and add a supportive pattern to include supported types for determining matches. A triangle can be multiple types, so basic if/else statements for determinations, which was the first idea that popped up, was a no-go.

Abstractions has been included to make it possible in the future to add type determination of other forms (square types for instance). 

## How to Run the project
- Clone the repository
- [Install .NET 6.0](https://aka.ms/dotnet-download)
- Open applicable CLI in root of project and run following commands:
  - `cd Geometry.App`
  - `dotnet build .`
  - `dotnet run`