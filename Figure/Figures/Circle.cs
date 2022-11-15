using Figure.Base;

namespace Figure.Figures;

public class Circle : FigureBase
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Radius must be positive");
        }
        this.Radius = radius;
    }

    protected override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }
}