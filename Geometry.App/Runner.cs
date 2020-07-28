using System;
using System.Linq;
using Geometry.App.Utility;
using Geometry.Logic;

namespace Geometry.App
{
    internal class Runner
    {
        public void Start()
        {
            Console.WriteLine("Please input 3 sides of a triangle");

            var triangle = GetTriangleFromInput();

            var typeService = new TriangleTypeService();
            var triangleTypes = typeService.GetTypes(triangle);

            Console.WriteLine("The triangle is the following type:"); 
            Console.WriteLine(triangleTypes.Single());
        }

        private static Triangle GetTriangleFromInput()
        {
            var a = GetSideFromConsole("A: ");
            var b = GetSideFromConsole("B: ");
            var c = GetSideFromConsole("C: ");

            var triangle = new Triangle(a, b, c);

            return triangle;
        }

        private static uint GetSideFromConsole(string message)
        {
            string side;

            do
            {
                Console.Write(message);
                side = Console.ReadLine();

            } while (!InputValidator.IsValidTriangleSide(side));

            return uint.Parse(side);
        }
    }
}