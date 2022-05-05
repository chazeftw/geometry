using System.Collections.Generic;
using System.Linq;
using Geometry.Domain.Abstractions;

namespace Geometry.Domain.Services;

public class TriangleTypeService : ITriangleTypeService
{
    private readonly ITriangleTypeResolverFactory _factory;

    public TriangleTypeService(ITriangleTypeResolverFactory factory)
    {
        _factory = factory;
    }

    public IReadOnlyCollection<TriangleType> DetermineTypes(ITriangle triangle)
    {
        var resolvers = _factory.CreateResolvers();

        var types = resolvers
            .Select(triangleTypeResolver => triangleTypeResolver.ResolveType(triangle));

        return types
            .Where(match => match.IsMatch)
            .Select(type => type.Type)
            .ToList();
    }
}