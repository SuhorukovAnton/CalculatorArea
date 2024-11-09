using AreaCalculator;
using AreaCalculator.Figures;

using NUnit.Framework;

namespace NUnitAreaCalculator;

[TestFixture]
public class Tests
{
    [Test]
    public void SuccessTestGetCirculeArea()
    {
        var circule = new Circule(10);
        Assert.That(circule.Area, Is.EqualTo(100 * Math.PI));
    }

    [Test]
    public void SuccessTestGetTriangleArea()
    {
        var triangle = new Triangle(10, 10, 10);
        Assert.That(triangle.Area, Is.EqualTo(15));
    }

    [Test]
    public void ThrowTestInitCircule()
    {
        Assert.Throws<ArgumentException>(() => new Circule(-1));
    }

    [TestCase(-1, 2, 3)]
    [TestCase(1, -2, 3)]
    [TestCase(1, 2, -3)]
    [TestCase(100, 10, 10)]
    public void ThrowTestInitTriangle(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(3, 4, 6, ExpectedResult = false)]
    public bool SuccessTestIsRightTriangle(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        return triangle.IsRight;
    }

    [Test]
    public void SuccessTestCreateCircule()
    {
        var figure = FigureFactory.CreateFigure(3);
        Assert.IsTrue(figure is Circule);
    }

    [Test]
    public void SuccessTestCreateTriangle()
    {
        var figure = FigureFactory.CreateFigure(3, 4, 5);
        Assert.IsTrue(figure is Triangle);
    }
}