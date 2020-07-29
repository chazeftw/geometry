namespace Geometry.Abstractions.Triangle
{
    public interface ITriangleTypeResolver
    {
        ITriangleTypeMatch ResolveType(ITriangle triangle);
    }
}
