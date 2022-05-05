namespace Geometry.Domain.Abstractions;

public interface ITriangleTypeResolver
{
    ITriangleTypeMatch ResolveType(ITriangle triangle);
}