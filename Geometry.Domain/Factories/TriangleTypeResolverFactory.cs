using System.Collections.Generic;
using Geometry.Domain.Resolvers;
using Geometry.Domain.Abstractions;

namespace Geometry.Domain.Factories;

public class TriangleTypeResolverFactory : ITriangleTypeResolverFactory
{
    public IReadOnlyCollection<ITriangleTypeResolver> CreateResolvers()
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