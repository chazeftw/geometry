using Geometry.Abstractions.Triangle;

namespace Geometry.Logic.Resolvers
{
    public class EquilateralResolver : ITriangleTypeResolver
    {
        public TriangleType ResolveType(ITriangle triangle)
        {
            var isEquilateral = triangle.A == triangle.B 
                                    && triangle.B == triangle.C;

            if (isEquilateral)
            {
                return TriangleType.Equilateral;
            }

            return TriangleType.None;
        }
    }
}
