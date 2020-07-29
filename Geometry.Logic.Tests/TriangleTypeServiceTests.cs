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
        public void Given_two_resolvers_When_triangle_is_isosceles_type_Then_return_isosceles()
        {
            // Arrange
            var factoryMock = new Mock<ITriangleTypeResolverFactory>();
            factoryMock.Setup(x => x.CreateResolvers()).Returns(new List<ITriangleTypeResolver>
            {
                new IsoscelesResolver(),
                new ScaleneResolver(),
            });

            var triangleTypeService = new TriangleTypeService(factoryMock.Object);

            var triangle = new Triangle(3, 3, 2);

            var expectedTypes = new List<TriangleType> { TriangleType.Isosceles };

            // Act
            var types = triangleTypeService.DetermineTypes(triangle);

            // Assert
            types.Should().BeEquivalentTo(expectedTypes);
        }

        [Fact]
        public void Given_equilateral_resolver_When_triangle_is_scalene_type_Then_return_no_matching_type()
        {
            // Arrange
            var factoryMock = new Mock<ITriangleTypeResolverFactory>();
            factoryMock.Setup(x => x.CreateResolvers()).Returns(new List<ITriangleTypeResolver>
            {
                new EquilateralResolver()
            });

            var triangleTypeService = new TriangleTypeService(factoryMock.Object);

            var triangle = new Triangle(2, 4, 3);

            // Act
            var types = triangleTypeService.DetermineTypes(triangle);

            // Assert
            types.Should().BeEmpty();
        }
    }
}
