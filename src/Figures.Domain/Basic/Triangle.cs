namespace Figures.Domain.Basic;

public class Triangle : IFigure
{
    private const double CosRight = 0;

    private readonly double _tolerance;

    public Triangle(double a, double b, double c, double tolerance = 0.001) =>
        (A, B, C, _tolerance) = (a, b, c, tolerance);

    public double A { get; }
    public double B { get; }
    public double C { get; }

    public double GetSquare()
    {
        IEnumerable<(double A, double B, double C)> sides = [(A, B, C), (A, C, B), (B, C, A)];
        foreach (var side in sides)
        {
            if (Math.Abs(CosRight - GetCosBySides(side.A, side.B, side.C)) < _tolerance)
            {
                return side.A * side.B / 2;
            }
        }
        return GetSquareByHeron();
    }

    private double GetSquareByHeron()
    {
        double semiperimeter = (A + B + C) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
    }

    private static double GetCosBySides(double a, double b, double c) =>
        (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b);
}
