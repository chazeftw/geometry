namespace Geometry.Domain.Abstractions;

public interface ITriangleTypeMatch
{
    TriangleType Type { get; }
    bool IsMatch { get; }
}