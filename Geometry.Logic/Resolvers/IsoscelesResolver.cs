using Geometry.Abstractions.Triangle;

namespace Geometry.Logic.Resolvers
{
    public class IsoscelesResolver : ITriangleTypeResolver
    {
        public TriangleType ResolveType(ITriangle triangle)
        {
            var isIsosceles = (triangle.A == triangle.B && triangle.A != triangle.C)
                                  || (triangle.B == triangle.C && triangle.B != triangle.A)
                                  || (triangle.C == triangle.A && triangle.C != triangle.B);

            if (isIsosceles)
            {
                return TriangleType.Isosceles;
            }

            return TriangleType.None;
        }
    }
}
