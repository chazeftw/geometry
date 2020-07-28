using Geometry.Abstractions.Triangle;

namespace Geometry.Logic.Resolvers
{
    public class ScaleneResolver : ITriangleTypeResolver
    {
        public TriangleType ResolveType(ITriangle triangle)
        {
            var scaleneRequirements = triangle.SideA != triangle.SideB 
                                      && triangle.SideB != triangle.SideC 
                                      && triangle.SideC != triangle.SideA;

            return scaleneRequirements 
                ? TriangleType.Scalene 
                : TriangleType.None;
        }
    }
}
