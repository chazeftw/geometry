using System.Collections.Generic;
using System.Linq;
using Geometry.Abstractions.Triangle;

namespace Geometry.Logic
{
    public class TriangleTypeService : ITriangleTypeService
    {
        private readonly ITriangleResolverFactory _factory;

        public TriangleTypeService()
        {
            _factory = new TriangleResolverFactory();
        }

        public IEnumerable<TriangleType> GetTypes(ITriangle triangle)
        {
            var resolvers = _factory.CreateResolvers();

            return resolvers
                .Select(resolver => resolver.ResolveType(triangle))
                .Where(type => type != TriangleType.None)
                .ToList();
        }

    }
}
