using Geometry.Domain.Abstractions;

namespace Geometry.Domain.Resolvers;

public class ScaleneResolver : ITriangleTypeResolver
{
    public ITriangleTypeMatch ResolveType(ITriangle triangle)
    {
        var isScalene = triangle.A != triangle.B
                        && triangle.B != triangle.C
                        && triangle.C != triangle.A;

        return new TriangleTypeMatch(TriangleType.Scalene, isScalene);
    }
}