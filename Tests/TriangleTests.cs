using FiguresArea.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests;

public class TriangleTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void NegativeSideA()
    {
        var sideA = -1;
        var sideB = 2;
        var sideC = 3;

        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Test]
    public void NegativeSideB()
    {
        var sideA = 1;
        var sideB = -2;
        var sideC = 3;

        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Test]
    public void NegativeSideC()
    {
        var sideA = 1;
        var sideB = 2;
        var sideC = -3;

        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Test]
    public void Triangle_SidesEveryThinkOkey()
    {
        var sideA = 1;
        var sideB = 2;
        var sideC = 3;
        Assert.DoesNotThrow(() => new Triangle(sideA, sideB, sideC));
    }

    [Test]
    public void Triangle_IsNotStraightAngleTriangle()
    {
        var sideA = 1;
        var sideB = 2;
        var sideC = 3;

        var triangle = new Triangle(sideA, sideB, sideC);
        
        Assert.IsFalse(triangle.IsStraightAngleTriangle());
    }

    [Test]
    public void Triangle_StraightAngleTriangle()
    {
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;

        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.IsTrue(triangle.IsStraightAngleTriangle());
    }

    [Test]
    public void Triangle_StraightAngleCalculateArea()
    {
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;

        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.That(triangle.CalculateArea(), Is.EqualTo(6));
    }

    [Test]
    public void Triangle_NotStraightAngleCalculateArea()
    {
        var sideA = 2;
        var sideB = 4;
        var sideC = 5;

        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.That(triangle.CalculateArea(), Is.EqualTo(3.8).Within(0.001));
    }

    [Test]
    public void Triangle_CalculatePerimeter()
    {
        var sideA = 2;
        var sideB = 4;
        var sideC = 5;

        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.That(triangle.CalculatePerimeter, Is.EqualTo(11));
    }
}
