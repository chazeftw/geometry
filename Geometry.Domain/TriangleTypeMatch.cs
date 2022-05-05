using Geometry.Domain.Abstractions;

namespace Geometry.Domain;

public class TriangleTypeMatch : ITriangleTypeMatch
{
    public TriangleTypeMatch(TriangleType type, bool isMatch)
    {
        Type = type;
        IsMatch = isMatch;
    }

    public TriangleType Type { get; }
    public bool IsMatch { get; }
}