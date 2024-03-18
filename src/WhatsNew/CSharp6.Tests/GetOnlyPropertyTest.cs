namespace CSharp6.Tests;

public class GetOnlyPropertyTest
{
    [Fact]
    public void GetOnlyPropertyTests()
    {
        var p5 = new PointCsharp5();
        var p6auto = new PointCsharp6Auto();
        var p6 = new PointCsharp6(10, 20);

        p5.Should().BeEquivalentTo(p6);
        p6.Should().BeEquivalentTo(p6auto);
    }

    // Until C# 5, you need backing field.
    public class PointCsharp5
    {
        private readonly int _x = 10;
        public int X { get { return _x; } }

        private readonly int _y = 20;
        public int Y { get { return _y; } }
    }

    // Get only Auto property
    public class PointCsharp6Auto
    {
        // C# 6 introduce Get Only Auto Property.
        public int X { get; } = 10;
        public int Y { get; } = 20;
    }

    // Get only init by ctor.
    public class PointCsharp6
    {
        // C# 6 introduce Get Auto Property, require initialize by .ctor.
        public int X { get; }
        public int Y { get; }

        public PointCsharp6(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
