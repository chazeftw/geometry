using ITriangle = Geometry.Domain.Abstractions.ITriangle;
using ITriangleTypeMatch = Geometry.Domain.Abstractions.ITriangleTypeMatch;
using ITriangleTypeResolver = Geometry.Domain.Abstractions.ITriangleTypeResolver;

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