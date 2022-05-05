using System.Collections.Generic;
using System.Linq;
using ITriangle = Geometry.Domain.Abstractions.ITriangle;
using ITriangleTypeResolverFactory = Geometry.Domain.Abstractions.ITriangleTypeResolverFactory;
using ITriangleTypeService = Geometry.Domain.Abstractions.ITriangleTypeService;

namespace Geometry.Domain;

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