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
            var serviceCollection = new ServiceCollection();

            // Add app
            serviceCollection.AddTransient<App>();

            // Add services
            serviceCollection.AddScoped<ITriangleResolverFactory, TriangleResolverFactory>();
            serviceCollection.AddScoped<ITriangleTypeService, TriangleTypeService>();

            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            serviceProvider.GetService<App>().Run();
        }
    }
}
