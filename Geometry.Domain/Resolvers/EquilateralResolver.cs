using ITriangle = Geometry.Domain.Abstractions.ITriangle;
using ITriangleTypeMatch = Geometry.Domain.Abstractions.ITriangleTypeMatch;
using ITriangleTypeResolver = Geometry.Domain.Abstractions.ITriangleTypeResolver;

namespace Geometry.Domain.Resolvers;

public class EquilateralResolver : ITriangleTypeResolver
{
    public ITriangleTypeMatch ResolveType(ITriangle triangle)
    {
        var isEquilateral = triangle.A == triangle.B
                            && triangle.B == triangle.C;

        return new TriangleTypeMatch(TriangleType.Equilateral, isEquilateral);
    }
}