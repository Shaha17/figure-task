using Figure.Base;
using Figure.Figures;

namespace Figure.Test;

public class TriangleTest
{
    [Fact]
    public void TriangleWithWrongSides()
    {
        var firstSide = 3;
        var secondSide = 4;
        var thirdSide = 10;

        Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }

    [Fact]
    public void TriangleCheckRightAngleTrueTest()
    {
        //
        var firstSide = 3;
        var secondSide = 4;
        var thirdSide = 5;

        //
        var triangle = new Triangle(firstSide, secondSide, thirdSide);

        //
        var expect = true;
        Assert.Equal(expect, triangle.IsRightAngle);
    }

    [Fact]
    public void TriangleCheckRightAngleFalseTest()
    {
        //
        var firstSide = 4;
        var secondSide = 5;
        var thirdSide = 6;

        //
        var triangle = new Triangle(firstSide, secondSide, thirdSide);

        //
        var expect = false;

        Assert.Equal(expect, triangle.IsRightAngle);
    }

    [Fact]
    public void TriangleCheckCorrectSquare()
    {
        //
        var firstSide = 3;
        var secondSide = 4;
        var thirdSide = 5;

        //
        var triangle = new Triangle(firstSide, secondSide, thirdSide);

        //
        var expected = 6;
        Assert.Equal(expected, triangle.Square);
    }
}