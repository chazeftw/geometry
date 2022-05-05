using System.Collections.Generic;
using Geometry.Domain.Resolvers;
using ITriangleTypeResolver = Geometry.Domain.Abstractions.ITriangleTypeResolver;
using ITriangleTypeResolverFactory = Geometry.Domain.Abstractions.ITriangleTypeResolverFactory;

namespace Geometry.Domain;

public class TriangleTypeResolverFactory : ITriangleTypeResolverFactory
{
    public IEnumerable<ITriangleTypeResolver> CreateResolvers()
    {
        var resolvers = new List<ITriangleTypeResolver>
        {
            new EquilateralResolver(),
            new IsoscelesResolver(),
            new ScaleneResolver()
        };

        return resolvers;
    }
}