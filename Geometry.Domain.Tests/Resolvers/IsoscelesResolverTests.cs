using FluentAssertions;
using Geometry.Domain;
using Geometry.Domain.Resolvers;
using Xunit;

namespace Geometry.Logic.Tests.Resolvers;

public class IsoscelesResolverTests
{
    [Fact]
    public void Given_triangle_When_three_sides_are_equal_length_Then_return_equilateral()
    {
        // Arrange
        var triangle = new Triangle(1, 1, 1);
        var isoscelesResolver = new IsoscelesResolver();
        var expectedResult = new TriangleTypeMatch(TriangleType.Isosceles, false);

        // Act
        var type = isoscelesResolver.ResolveType(triangle);

        // Assert
        type.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Given_triangle_When_two_sides_are_equal_length_Then_do_not_return_equilateral()
    {
        // Arrange
        var triangle = new Triangle(3, 3, 2);
        var isoscelesResolver = new IsoscelesResolver();
        var expectedResult = new TriangleTypeMatch(TriangleType.Isosceles, true);

        // Act
        var type = isoscelesResolver.ResolveType(triangle);

        // Assert
        type.Should().BeEquivalentTo(expectedResult);
    }

    [Fact]
    public void Given_triangle_When_no_sides_are_equal_length_Then_do_not_return_equilateral()
    {
        // Arrange
        var triangle = new Triangle(4, 5, 2);
        var isoscelesResolver = new IsoscelesResolver();
        var expectedResult = new TriangleTypeMatch(TriangleType.Isosceles, false);

        // Act
        var type = isoscelesResolver.ResolveType(triangle);

        // Assert
        type.Should().BeEquivalentTo(expectedResult);
    }
}