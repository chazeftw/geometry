using Geometry.Abstractions;

namespace Geometry.Logic.Resolvers
{
    public class IsoscelesResolver : ITriangleTypeResolver
    {
        public TriangleType ResolveType(ITriangle triangle)
        {
            var isoscelesRequirements = (triangle.SideA == triangle.SideB && triangle.SideA == triangle.SideC) ||
                                        (triangle.SideB == triangle.SideA && triangle.SideB == triangle.SideC) ||
                                        (triangle.SideC == triangle.SideA && triangle.SideC == triangle.SideB);

            return isoscelesRequirements 
                ? TriangleType.Isosceles 
                : TriangleType.NotSupported;
        }
    }
}
