using System.Collections.Generic;

namespace Geometry.Abstractions.Triangle
{
    public interface ITriangleTypeService
    {
        IEnumerable<TriangleType> GetTypes(ITriangle triangle);
    }
}
