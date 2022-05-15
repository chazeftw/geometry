using FluentAssertions;
using Geometry.Domain;
using Xunit;

namespace Geometry.Logic.Tests;

public class TriangleTests
{
    [Fact]
    public void Given_triangle_When_measurements_doesnt_form_a_valid_triangle_Then_should_be_invalid()
    {
        var triangle = new Triangle(1, 10, 12);

        triangle.IsValidTriangle().Should().BeFalse();
    }
}