using System;
using Geometry.Abstractions.Triangle;

namespace Geometry.Logic
{
    public class Triangle : ITriangle
    {
        public Triangle(uint a, uint b, uint c)
        {
            if (IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("Triangle measurements invalid");
            }

            A = a;
            B = b;
            C = c;
        }

        private bool IsValidTriangle(uint a, uint b, uint c)
        {
            return a + b <= c && a + c <= b && b + c <= a;
        }

        public uint A { get; }
        public uint B { get; }
        public uint C { get; }
    }
}
