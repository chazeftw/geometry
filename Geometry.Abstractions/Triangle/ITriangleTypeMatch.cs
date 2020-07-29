namespace Geometry.Abstractions.Triangle
{
    public interface ITriangleTypeMatch
    {
        TriangleType Type { get; }
        bool IsMatch { get; }
    }
}
