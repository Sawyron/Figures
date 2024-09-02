namespace Figures.Domain.Basic;
public class Circle : IFigure
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; }

    public double GetSquare() => Math.PI * Math.Pow(Radius, 2);
}
