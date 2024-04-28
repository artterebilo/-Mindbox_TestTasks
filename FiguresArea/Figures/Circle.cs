namespace FiguresArea.Figures;

public class Circle : IFigure
{
    public int Radius { get; private set; }

    public Circle(int radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius));
        }
        Radius = radius;
    }
    public double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
}
