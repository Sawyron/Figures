using Figures.Domain.Basic;

namespace Fugures.Domain.Test.Basic;

public class TriangleTest
{
    [Fact]
    public void WhenHeronTriangleIsGeven_ThenGetSquareShouldReturnCorrectResult()
    {
        var triangle = new Triangle(6, 5, 2.2);
        double expected = 5.28;
        Assert.Equal(expected, triangle.GetSquare(), 0.001);
    }

    [Theory]
    [InlineData(2, 3, 3.60555, 3)]
    [InlineData(2, 3.60555, 3, 3)]
    [InlineData(3, 3.60555, 2, 3)]
    public void WhenRightTriangleIsGiven_ThenGetSquareShouldReturnCorrectResult(double a, double b, double c, double expected)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(expected, triangle.GetSquare(), 0.001);
    }
}
