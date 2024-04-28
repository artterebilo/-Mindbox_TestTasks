using FiguresArea.Figures;

namespace FiguresArea.Services;

public static class FigureAreaService
{
    public static double CalculateArea(IFigure figure)
    {
        if (figure == null)
        {
            throw new ArgumentNullException(nameof(figure));
        }

        return figure.CalculateArea();
    }

}
