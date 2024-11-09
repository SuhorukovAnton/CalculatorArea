namespace AreaCalculator.Figures;

public class Circule : IFigure
{
    public double radius { get; }
    public double Area 
    {
        get
        {
            if (_area == 0)
            {
                _area = Math.PI * radius * radius;
            }
            return _area;
        } 
    }
    private double _area;

    public Circule(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("radius must be greater than 0");
        }
        this.radius = radius;
    }
}
