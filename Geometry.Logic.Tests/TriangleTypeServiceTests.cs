using System.Collections.Generic;
using FluentAssertions;
using Geometry.Abstractions.Triangle;
using Geometry.Logic.Resolvers;
using Moq;
using Xunit;

namespace Geometry.Logic.Tests
{
    public class TriangleTypeServiceTests
    {
        [Fact]
        public void Given_only_one_resolver_When_triangle_is_isosceles_type_Then_return_isosceles()
        {
            // Arrange
            var factoryMock = new Mock<ITriangleResolverFactory>();
            factoryMock.Setup(x => x.CreateResolvers()).Returns(new List<ITriangleTypeResolver>
            {
                new IsoscelesResolver()
            });

            var triangleTypeService = new TriangleTypeService(factoryMock.Object);

            var triangle = new Triangle(1, 1, 2);

            var expectedTypes = new List<TriangleType> { TriangleType.Isosceles };

            // Act
            var types = triangleTypeService.GetTypes(triangle);

            // Assert
            types.Should().BeEquivalentTo(expectedTypes);
        }
    }
}
