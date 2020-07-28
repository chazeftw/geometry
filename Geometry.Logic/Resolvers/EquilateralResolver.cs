using Geometry.Abstractions.Triangle;

namespace Geometry.Logic.Resolvers
{
    public class EquilateralResolver : ITriangleTypeResolver
    {
        public TriangleType ResolveType(ITriangle triangle)
        {
            var isEquilateral = triangle.SideA == triangle.SideB 
                                && triangle.SideB == triangle.SideC;

            return isEquilateral 
                ? TriangleType.Equilateral 
                : TriangleType.None;
        }
    }
}
