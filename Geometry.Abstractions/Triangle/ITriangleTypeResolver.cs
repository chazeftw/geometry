namespace Geometry.Abstractions.Triangle
{
    public interface ITriangleTypeResolver
    {
        TriangleType ResolveType(ITriangle triangle);
    }
}
