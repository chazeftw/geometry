namespace Geometry.Abstractions.Triangle
{
    public interface ITriangle
    {
        uint SideA { get; }
        uint SideB { get; }
        uint SideC { get; }
    }
}