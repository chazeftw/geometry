using System.Collections.Generic;
using System.Linq;
using Geometry.Abstractions.Triangle;

namespace Geometry.Logic
{
    public class TriangleTypeService : ITriangleTypeService
    {
        private readonly ITriangleTypeResolverFactory _factory;

        public TriangleTypeService(ITriangleTypeResolverFactory factory)
        {
            _factory = factory;
        }

        public IEnumerable<TriangleType> DetermineTypes(ITriangle triangle)
        {
            var resolvers = _factory.CreateResolvers();

            var types = resolvers
                .Select(triangleTypeResolver => triangleTypeResolver.ResolveType(triangle));

            return types
                .Where(match => match.IsMatch)
                .Select(type => type.Type);
        }
    }
}
