using System.Collections.Generic;
using Geometry.Abstractions.Triangle;

namespace Geometry.Logic.Resolvers
{
    public class TriangleResolverFactory : ITriangleResolverFactory
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
}