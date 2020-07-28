using Geometry.Abstractions;

namespace Geometry.Logic.Resolvers
{
    public class EquilateralResolver : ITriangleTypeResolver
    {
        public TriangleType ResolveType(ITriangle triangle)
        {
            var isEquilateral = triangle.SideA == triangle.SideB 
                                && triangle.SideB == triangle.SideC 
                                && triangle.SideC == triangle.SideA;

            return isEquilateral 
                ? TriangleType.Equilateral 
                : TriangleType.NotSupported;
        }
    }
}
