using System.Collections.Generic;
using System.Linq;
using Geometry.Abstractions.Triangle;

namespace Geometry.Logic
{
    public class TriangleTypeService : ITriangleTypeService
    {
        private readonly ITriangleResolverFactory _factory;

        public TriangleTypeService(ITriangleResolverFactory factory)
        {
            _factory = factory;
        }

        public IEnumerable<TriangleType> GetTypes(ITriangle triangle)
        {
            var resolvers = _factory.CreateResolvers();

            var types = resolvers
                .Select(triangleTypeResolver => triangleTypeResolver.ResolveType(triangle))
                .ToList();

            return types
                .Where(match => match.IsMatch)
                .Select(type => type.Type)
                .ToList();
        }
    }
}
