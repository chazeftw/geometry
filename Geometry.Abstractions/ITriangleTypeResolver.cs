namespace Geometry.Abstractions
{
    public interface ITriangleTypeResolver
    {
        TriangleType ResolveType(ITriangle triangle);
    }
}
