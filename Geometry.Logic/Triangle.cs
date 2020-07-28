using Geometry.Abstractions.Triangle;

namespace Geometry.Logic
{
    public class Triangle : ITriangle
    {
        public Triangle(uint sideA, uint sideB, uint sideC)
        {
            A = sideA;
            B = sideB;
            C = sideC;
        }

        public uint A { get; }
        public uint B { get; }
        public uint C { get; }
    }
}
