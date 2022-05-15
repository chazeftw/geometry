using Geometry.Domain.Abstractions;

namespace Geometry.Domain;

public class Triangle : ITriangle
{
    public Triangle(uint a, uint b, uint c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool IsValidTriangle()
    {
        return A + B > C && A + C > B && B + C > A;
    }

    public uint A { get; }
    public uint B { get; }
    public uint C { get; }
}