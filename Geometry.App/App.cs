using System;
using Geometry.App.Validation;
using Geometry.Domain;
using Geometry.Domain.Abstractions;

namespace Geometry.App;

public class App
{
    private readonly ITriangleTypeService _triangleTypeService;

    public App(ITriangleTypeService triangleTypeService)
    {
        _triangleTypeService = triangleTypeService;
    }

    public void Run()
    {
        var triangle = GetTriangleFromInput();

        var triangleTypes = _triangleTypeService.DetermineTypes(triangle);

        Console.WriteLine($"The triangle is the following type{(triangleTypes.Count > 1 ? "s" : string.Empty)}:");
        foreach (var triangleType in triangleTypes)
        {
            Console.WriteLine(triangleType);
        }
    }

    private static ITriangle GetTriangleFromInput()
    {
        Triangle triangle;

        do
        {
            Console.WriteLine("Input 3 sides of a valid triangle");

            var a = GetSideFromConsole("A: ");
            var b = GetSideFromConsole("B: ");
            var c = GetSideFromConsole("C: ");
            triangle = new Triangle(a, b, c);
        } while (!triangle.IsValidTriangle());

        return triangle;
    }

    private static uint GetSideFromConsole(string inputMessage)
    {
        string side;

        do
        {
            Console.Write(inputMessage);
            side = Console.ReadLine()!;

        } while (!InputValidator.IsValidTriangleSide(side));

        return uint.Parse(side);
    }
}