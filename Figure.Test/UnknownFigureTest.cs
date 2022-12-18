using System.Drawing;
using System.Runtime.InteropServices;
using Figure.Figures;

namespace Figure.Test;

public class UnknownFigureTest
{
    [Fact]
    public void UnknownFigureCheckCorrectSquare4Points()
    {
        //
        var firstPoint = new Point(2, 2);
        var secondPoint = new Point(4, 4);
        var thirdPoint = new Point(6, 4);
        var fourthPoint = new Point(7, 2);

        //
        var triangle = new UnknownFigure(firstPoint, secondPoint, thirdPoint, fourthPoint);

        //
        var expected = 7;
        Assert.Equal(expected, triangle.Square);
    }
    [Fact]
    public void UnknownFigureCheckCorrectSquare3Points()
    {
        //
        var firstPoint = new Point(1, 1);
        var secondPoint = new Point(1, 3);
        var thirdPoint = new Point(3, 1);

        //
        var triangle = new UnknownFigure(firstPoint, secondPoint, thirdPoint);

        //
        var expected = 2;
        Assert.Equal(expected, triangle.Square);
    }

    [Fact]
    public void UnknownFigureWithoutParamsShould()
    {
        //

        //

        //
        Assert.Throws<ArgumentException>(() => new UnknownFigure());
    }
}