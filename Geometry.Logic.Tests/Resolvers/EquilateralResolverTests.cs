using FluentAssertions;
using Geometry.Abstractions.Triangle;
using Geometry.Logic.Resolvers;
using Xunit;

namespace Geometry.Logic.Tests.Resolvers
{
    public class EquilateralResolverTests
    {
        [Fact]
        public void Given_triangle_When_three_sides_are_equal_length_Then_return_equilateral()
        {
            // Arrange
            var triangle = new Triangle(1, 1 ,1);
            var equilateralResolver = new EquilateralResolver();
            
            // Act
            var type = equilateralResolver.ResolveType(triangle);

            // Assert
            type.Should().Be(TriangleType.Equilateral);
        }

        [Fact]
        public void Given_triangle_When_two_sides_are_equal_length_Then_do_not_return_equilateral()
        {
            // Arrange
            var triangle = new Triangle(1, 1, 2);
            var equilateralResolver = new EquilateralResolver();

            // Act
            var type = equilateralResolver.ResolveType(triangle);

            // Assert
            type.Should().NotBe(TriangleType.Equilateral);
        }

        [Fact]
        public void Given_triangle_When_no_sides_are_equal_length_Then_do_not_return_equilateral()
        {
            // Arrange
            var triangle = new Triangle(1, 5, 2);
            var equilateralResolver = new EquilateralResolver();

            // Act
            var type = equilateralResolver.ResolveType(triangle);

            // Assert
            type.Should().NotBe(TriangleType.Equilateral);
        }
    }
}