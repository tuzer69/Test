using System.Reflection;
using NUnit.Framework;
using Test;
using Test.Base;

namespace Figure.Tests;

[TestFixture]
public class FigureTests
{

    [Test]
    public void Calculate_circle_square()
    {
        // Arrange
        var radius = 4;
        var pi = 3.1415926535;
        var expected = pi * (radius * radius);
        IFigure circle = new Circle(radius);


        // Act
        var actual = circle.GetSquare();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Triangle_circle_square()
    {
        // Arrange
        var sides = (3, 5, 6);
        var p  = (sides.Item1 + sides.Item2 + sides.Item3) / 2;
        var result = p * (p - sides.Item1) * (p - sides.Item2) * (p - sides.Item3);
        var expected = result * result;

        IFigure triangle = new Triangle(sides);
        
        // Act
        var actual = triangle.GetSquare();

        // Assert
        Assert.AreEqual(expected, actual);
    }
}