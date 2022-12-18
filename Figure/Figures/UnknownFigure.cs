using System.Drawing;
using System.Numerics;
using Figure.Base;

namespace Figure.Figures;

public class UnknownFigure : FigureBase
{
    public Point[] Points;

    public UnknownFigure(params Point[] points)
    {
        Points = points;

        if (points.Length < 3)
        {
            throw new ArgumentException("Figure must contains at least 3 points");
        }
        //TODO Проверка на то, что многоугольник простой
    }

    protected override double CalculateArea()
    {
        double sum = 0;
        var cnt = Points.Length;
        for (int i = 0; i < cnt; i++)
        {
            var j = (i + 1) % cnt;
            var a = Points[i];
            var b = Points[j];

            sum += a.X * b.Y - a.Y * b.X;
        }

        return Math.Abs(sum) / 2;
    }
}