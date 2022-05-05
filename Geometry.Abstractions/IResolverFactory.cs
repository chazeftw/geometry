using System.Collections.Generic;

namespace Geometry.Abstractions;

public interface IResolverFactory<T>
{
    IEnumerable<T> CreateResolvers();
}