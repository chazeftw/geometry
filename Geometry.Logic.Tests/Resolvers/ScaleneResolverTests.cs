using FluentAssertions;
using Geometry.Abstractions.Triangle;
using Geometry.Logic.Resolvers;
using Xunit;

namespace Geometry.Logic.Tests.Resolvers
{
    public class ScaleneResolverTests
    {
        [Fact]
        public void Given_triangle_When_three_sides_are_equal_length_Then_return_equilateral()
        {
            // Arrange
            var triangle = new Triangle(1, 1, 1);
            var isoscelesResolver = new ScaleneResolver();

            // Act
            var type = isoscelesResolver.ResolveType(triangle);

            // Assert
            type.Should().NotBe(TriangleType.Scalene);
        }

        [Fact]
        public void Given_triangle_When_two_sides_are_equal_length_Then_do_not_return_equilateral()
        {
            // Arrange
            var triangle = new Triangle(1, 1, 2);
            var isoscelesResolver = new ScaleneResolver();

            // Act
            var type = isoscelesResolver.ResolveType(triangle);

            // Assert
            type.Should().NotBe(TriangleType.Scalene);
        }

        [Fact]
        public void Given_triangle_When_no_sides_are_equal_length_Then_do_not_return_equilateral()
        {
            // Arrange
            var triangle = new Triangle(1, 5, 2);
            var isoscelesResolver = new ScaleneResolver();

            // Act
            var type = isoscelesResolver.ResolveType(triangle);

            // Assert
            type.Should().Be(TriangleType.Scalene);
        }
    }
}
