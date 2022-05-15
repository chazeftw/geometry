namespace Geometry.Domain.Abstractions;

public interface ITriangle
{
    uint A { get; }
    uint B { get; }
    uint C { get; }

    bool IsValidTriangle();
}