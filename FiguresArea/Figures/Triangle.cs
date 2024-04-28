namespace FiguresArea.Figures;

public class Triangle : IFigure
{
    public int SideA { get; private set; }
    public int SideB { get; private set; }
    public int SideC { get; private set; }

    public Triangle(int sideA, int sideB, int sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public bool IsStraightAngleTriangle()
    {
        var list = LessSides();

        var maxSide = MaxSide();

        list.Remove(maxSide);

        return Math.Pow(maxSide, 2) == Math.Pow(list[0], 2) + Math.Pow(list[1], 2);
    }

    public double CalculateArea()
    {
        if (IsStraightAngleTriangle())
        {
            var lessSides = LessSides();
            return 0.5 * lessSides[0] * lessSides[1];    
        }

        var p = CalculatePerimeter() / 2;

        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public double CalculatePerimeter() => SideA + SideB + SideC;

    private int MaxSide()
    {
        var list = new List<int> { SideA, SideB, SideC };

        return list.Max();
    }

    private List<int> LessSides()
    {
        var list = new List<int> { SideA, SideB, SideC };

        list.Remove(MaxSide());

        return list;
    }
}
