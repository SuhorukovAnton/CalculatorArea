namespace AreaCalculator.Figures;

public class Triangle : IFigure
{
    public double a { get; }
    public double b { get; }
    public double c { get; }

    public double Area
    {
        get
        {
            if (_area == 0)
            {
                _area = (a + b + c) / 2;
            }
            return _area;
        }
    }
    private double _area;

    public bool IsRight
    {
        get
        {
            if (!_isRight.HasValue)
            {
                double[] sides = { a, b, c };
                Array.Sort(sides);
                _isRight = sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1]) < 1e-10;
            }
            return _isRight.Value;
        }
    }
    private bool? _isRight;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b < 0)
        {
            throw new ArgumentException("a, b and c must be greater than 0.");
        }
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ArgumentException("The sum of two sides must be greater than the third side.");
        }
        this.a = a;
        this.b = b;
        this.c = c;
    }
}
