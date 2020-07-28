using Geometry.Abstractions.Triangle;

namespace Geometry.Logic.Resolvers
{
    public class ScaleneResolver : ITriangleTypeResolver
    {
        public TriangleType ResolveType(ITriangle triangle)
        {
            var isScalene = triangle.A != triangle.B
                                && triangle.B != triangle.C
                                && triangle.C != triangle.A;

            if (isScalene)
            {
                return TriangleType.Scalene;
            }

            return TriangleType.None;
        }
    }
}
