﻿using System.Collections.Generic;
using Geometry.Abstractions.Triangle;
using Geometry.Logic.Resolvers;

namespace Geometry.Logic
{
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
}