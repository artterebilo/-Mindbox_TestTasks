using FiguresArea.Figures;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Circle_NegativeRadius()
    {
        var radius = -1;
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }

    [Test]
    public void Circle_PositiveRadius()
    {
        var radius = 1;
        Assert.DoesNotThrow(() => new Circle(radius));
    }

    [Test]
    public void Circle_CalculatedArea()
    {
        var radius = 5;
        
        var circle = new Circle(radius);

        Assert.That(circle.CalculateArea(), Is.EqualTo(78.539815).Within(0.01));
    }
}