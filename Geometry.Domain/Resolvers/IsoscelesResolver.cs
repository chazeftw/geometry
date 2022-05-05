using ITriangle = Geometry.Domain.Abstractions.ITriangle;
using ITriangleTypeMatch = Geometry.Domain.Abstractions.ITriangleTypeMatch;
using ITriangleTypeResolver = Geometry.Domain.Abstractions.ITriangleTypeResolver;

namespace Geometry.Domain.Resolvers;

public class IsoscelesResolver : ITriangleTypeResolver
{
    public ITriangleTypeMatch ResolveType(ITriangle triangle)
    {
        var isIsosceles = (triangle.A == triangle.B && triangle.A != triangle.C)
                          || (triangle.B == triangle.C && triangle.B != triangle.A)
                          || (triangle.C == triangle.A && triangle.C != triangle.B);

        return new TriangleTypeMatch(TriangleType.Isosceles, isIsosceles);
    }
}