using AreaCalculator.Figures;

namespace AreaCalculator;

public static class FigureFactory
{
    public static IFigure CreateFigure(params double[] numbers)
    {
        switch (numbers.Length)
        {
            case 1: return new Circule(numbers[0]);
            case 3: return new Triangle(numbers[0], numbers[1], numbers[2]);
            default: throw new ArgumentException("Can't create figure with this numbers.");
        }
    }
}
