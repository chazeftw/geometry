using Geometry.Abstractions.Triangle;

namespace Geometry.Logic
{
    public class Triangle : ITriangle
    {
        public Triangle(uint a, uint b, uint c)
        {
            A = a;
            B = b;
            C = c;
        }

        public uint A { get; }
        public uint B { get; }
        public uint C { get; }
    }
}
