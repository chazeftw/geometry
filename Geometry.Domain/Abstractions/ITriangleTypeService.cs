using System.Collections.Generic;

namespace Geometry.Domain.Abstractions;

public interface ITriangleTypeService
{
    IReadOnlyCollection<TriangleType> DetermineTypes(ITriangle triangle);
}