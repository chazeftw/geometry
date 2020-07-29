using System;
using Geometry.Abstractions.Triangle;
using Geometry.Logic;
using Microsoft.Extensions.DependencyInjection;

namespace Geometry.App
{
    internal class Program
    {
        static void Main()
        {
            StartService();
        }

        private static void StartService()
        {
            var serviceProvider = GetServiceProvider();

            serviceProvider.GetService<App>().Run();
        }

        private static IServiceProvider GetServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            AddDependencies(serviceCollection);

            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }

        private static void AddDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<App>();

            serviceCollection.AddScoped<ITriangleTypeResolverFactory, TriangleTypeResolverFactory>();
            serviceCollection.AddScoped<ITriangleTypeService, TriangleTypeService>();
        }
    }
}
