using System;
using System.Collections.Generic;
using System.Linq;
using Geometry.Abstractions;
using Geometry.Logic;

namespace Geometry.App
{
    internal class Program
    {
        static void Main()
        {
            new Runner().Start();
        }

        
    }

    internal class Runner
    {
        public void Start()
        {
            Console.WriteLine("Please input 3 sides of a triangle");

            var triangle = GetTriangleFromInput();

            var list = GetTypes(triangle);

            Console.WriteLine($"The triangle is the following type{(list.Count() > 1 ? "s" : String.Empty)}:");
            foreach (var triangleType in list)
            {
                Console.WriteLine(triangleType);
            }
        }

        private static Triangle GetTriangleFromInput()
        {
            var a = GetSideFromConsole("A: ");
            var b = GetSideFromConsole("B: ");
            var c = GetSideFromConsole("C: ");

            var triangle = new Triangle(a, b, c);
            return triangle;
        }

        private static IEnumerable<TriangleType> GetTypes(Triangle triangle)
        {
            var factory = new TriangleResolverFactory();
            var resolvers = factory.CreateResolvers();

            return resolvers
                .Select(resolver => resolver.ResolveType(triangle))
                .Where(type => type != TriangleType.None)
                .ToList();
        }

        private static uint GetSideFromConsole(string message)
        {
            uint sideValue;
            string side;

            do
            {
                Console.Write(message);
                side = Console.ReadLine();
            } while (IsValidTriangleSide(side, out sideValue));

            return sideValue;
        }

        private static bool IsValidTriangleSide(string side, out uint sideValue)
        {
            return !uint.TryParse(side, out sideValue);
        }
    }
}
