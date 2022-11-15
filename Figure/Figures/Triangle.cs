using Figure.Base;

namespace Figure.Figures;

public class Triangle : FigureBase
{
    public double A
    {
        get => Sides[0];
        set => Sides[0] = value;
    }

    public double B
    {
        get => Sides[1];
        set => Sides[1] = value;
    }

    public double C
    {
        get => Sides[2];
        set => Sides[2] = value;
    }

    private List<double> Sides { get; }
    private readonly Lazy<bool> _isRightAngle;
    public bool IsRightAngle => _isRightAngle.Value;

    public Triangle(params double[] sides)
    {
        if (sides.Length != 3)
        {
            throw new ArgumentException("Triangle must have 3 sides");
        }

        Sides = sides.ToList();

        var orderedSides = sides.OrderBy(x => x).ToArray();
        if (orderedSides[2] >= orderedSides[0] + orderedSides[1])
        {
            throw new ArgumentException("Sum of two sides of triangle must be greater than third");
        }

        _isRightAngle = new Lazy<bool>(CalculateRightAngle);
    }

    protected override double CalculateArea()
    {
        var p = Sides.Sum() / 2;
        return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) *
                         (p - Sides[2]));
    }

    private bool CalculateRightAngle()
    {
        var rez = Math.Abs(Math.Pow(Sides[2], 2) -
                           (Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2)));
        return rez < Tolerance;
    }
}