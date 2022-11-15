namespace Figure.Base;

public abstract class FigureBase
{
    protected const double Tolerance = 0.00001;
    private readonly Lazy<double> _area;

    public double Square => _area.Value;

    protected FigureBase()
    {
        _area = new Lazy<double>(CalculateArea);
    }

    protected abstract double CalculateArea();
}