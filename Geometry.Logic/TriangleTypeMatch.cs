using Geometry.Abstractions.Triangle;

namespace Geometry.Logic
{
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
}
