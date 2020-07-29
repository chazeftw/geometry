using System;
using System.Linq;
using Geometry.Abstractions.Triangle;
using Geometry.App.Utility;
using Geometry.Logic;

namespace Geometry.App
{
    public class App
    {
        private readonly ITriangleTypeService _triangleTypeService;

        public App(ITriangleTypeService triangleTypeService)
        {
            _triangleTypeService = triangleTypeService;
        }

        public void Run()
        {
            Console.WriteLine("Please input 3 sides of a triangle");

            var triangle = GetTriangleFromInput();

            var triangleTypes = _triangleTypeService.DetermineTypes(triangle);

            Console.WriteLine($"The triangle is the following type{(triangleTypes.Count() > 1 ? "s" : string.Empty)}:");
            foreach (var triangleType in triangleTypes)
            {
                Console.WriteLine(triangleType);
            }
        }

        private static Triangle GetTriangleFromInput()
        {
            uint a, b, c;

            do
            {
                a = GetSideFromConsole("A: ");
                b = GetSideFromConsole("B: ");
                c = GetSideFromConsole("C: ");

            } while (!CanCreateValidTriangle(a, b, c));

            return new Triangle(a, b, c);
        }

        private static uint GetSideFromConsole(string inputMessage)
        {
            string side;

            do
            {
                Console.Write(inputMessage);
                side = Console.ReadLine();

            } while (!InputValidator.IsValidTriangleSide(side));

            return uint.Parse(side);
        }

        private static bool CanCreateValidTriangle(uint a, uint b, uint c)
        {
            try
            {
                var triangle = new Triangle(a, b, c);

                return true;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Measurements does not form a valid triangle. Please try again.");

                return false;
            }
        }
    }
}