using System;
using Geometry.Domain.Abstractions;
using Geometry.Domain.Factories;
using Geometry.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Geometry.App;

internal static class Program
{
    private static void Main()
    {
        StartService();
    }

    private static void StartService()
    {
        var serviceProvider = BuildServiceProvider();

        serviceProvider
            .GetService<App>()!
            .Run();
    }

    private static IServiceProvider BuildServiceProvider()
    {
        var serviceCollection = new ServiceCollection();

        ConfigureServices(serviceCollection);

        var serviceProvider = serviceCollection.BuildServiceProvider();

        return serviceProvider;
    }

    private static void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<App>();

        serviceCollection.AddScoped<ITriangleTypeResolverFactory, TriangleTypeResolverFactory>();
        serviceCollection.AddScoped<ITriangleTypeService, TriangleTypeService>();
    }
}