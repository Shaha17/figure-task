using Figure.Figures;

namespace Figure.Test;

public class CircleTest
{
    [Fact]
    public void CircleWithWrondRadiusTest()
    {
        //
        var radius = -3;

        //
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Fact]
    public void CircleAreaCalculateTest()
    {
        //
        var radius = 3;

        //
        var circle = new Circle(radius);

        //
        var expected = 28.274333882308138;
        Assert.Equal(expected, circle.Square);
    }
}