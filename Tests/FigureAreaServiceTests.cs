using FiguresArea.Figures;
using FiguresArea.Services;

namespace Tests;

 public class FigureAreaServiceTests
{
    [SetUp]
    public void Setup()
    {

    }
    
    [Test]
    public void FigureService_InputCircle()
    {
        var circle = new Circle(5);

        Assert.That(FigureAreaService.CalculateArea(circle), Is.EqualTo(78.539815).Within(0.01));
    }

    [Test]
    public void FigureService_InputTriangle()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.That(FigureAreaService.CalculateArea(triangle), Is.EqualTo(6));
    }

    [Test]
    public void FigureService_FigureIsNull()
    {
        Assert.Throws<ArgumentNullException>(() => FigureAreaService.CalculateArea(null));
    }
}


