namespace CSharp6.Tests;

public class CatchFilterTest
{
    [Fact]
    public void CatchFilterTests()
    {
        try
        {
            M(10);
        }
        catch (ArgumentException ex) when (ex.ParamName == "x")
        {
            ex.ParamName.Should().Be("x");
        }
        catch (ArgumentException)
        {
            throw;
        }
    }

    private static void M(int x)
    {
        if (x < 0) throw new ArgumentException(nameof(x));
    }
}
