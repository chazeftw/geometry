using Geometry.Abstractions;

namespace Geometry.Logic
{
    public class Triangle : ITriangle
    {
        public Triangle(uint sideA, uint sideB, uint sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public uint SideA { get; }
        public uint SideB { get; }
        public uint SideC { get; }
    }
}
