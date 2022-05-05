using System.Collections.Generic;

namespace Geometry.Domain.Abstractions;

public interface IResolverFactory<T>
{
    IReadOnlyCollection<T> CreateResolvers();
}