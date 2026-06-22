namespace CSharp6.Tests;

public class ExpressionBodiesTest
{
    // C# 6 introduce Expression bodied member.
    [Test]
    public async Task ExpressionBodiedMethodTest()
    {
        var p = new Point(10, 20);
        var q = new Point(10, 20);
        var result = p.Product(q);
        var result2 = p.ProductExpressionBody(q);

        await Assert.That(result).IsEqualTo(result2);
    }

    [Test]
    public async Task ExpressionBodiedPropertyTest()
    {
        var points = new[] { new Point(10, 20), new Point(20, 30) };
        var csharp5 = new PolygonCSharp5(points);
        var csharp6 = new PolygonCSharp6(points);

        await Assert.That(csharp5.Count).IsEqualTo(csharp6.Count);
        await Assert.That(csharp5[0]).IsEqualTo(csharp6[0]);
    }

    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Product(Point p)
        {
            return X * p.X + Y * p.Y;
        }

        // C# 6 introduce Expression bodied method for 1 line.
        public int ProductExpressionBody(Point p) => X * p.X + Y * p.Y;
    }

    public class PolygonCSharp5
    {
        private Point[] _vertexes;

        public int Count { get { return _vertexes.Length; } }
        public Point this[int i] { get { return _vertexes[i]; } }

        public PolygonCSharp5(Point[] vertexes)
        {
            _vertexes = vertexes;
        }
    }

    public class PolygonCSharp6
    {
        private Point[] _vertexes;

        // C# 6 introduce Expression bodied property
        public int Count => _vertexes.Length;
        public Point this[int i] => _vertexes[i];

        public PolygonCSharp6(Point[] vertexes)
        {
            _vertexes = vertexes;
        }
    }
}
