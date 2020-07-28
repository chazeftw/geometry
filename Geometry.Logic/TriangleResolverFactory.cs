using System.Collections.Generic;
using Geometry.Abstractions;
using Geometry.Logic.Resolvers;

namespace Geometry.Logic
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