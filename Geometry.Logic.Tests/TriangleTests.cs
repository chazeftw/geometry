using System;
using Xunit;

namespace Geometry.Logic.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Given_triangle_When_measurements_invalid_Then_throw_argument_exception()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
        }
    }
}
