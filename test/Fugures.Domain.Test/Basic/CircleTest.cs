using Figures.Domain.Basic;

namespace Fugures.Domain.Test.Basic;

public class CircleTest
{
    [Fact]
    public void GetRadius_ShouldReturnCorrectResult()
    {
        var circle = new Circle(3);
        double expected = 28.2735;
        Assert.Equal(expected, circle.GetSquare(), 0.001);
    }
}
