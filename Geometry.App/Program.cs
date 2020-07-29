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
            var serviceProvider = BuildServiceProvider();

            serviceProvider.GetService<App>().Run();
        }

        private static IServiceProvider BuildServiceProvider()
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
