using System.Threading.Tasks;

namespace CSharp6.Tests;

public class CatchFilterTest
{
    [Test]
    public async Task CatchFilterTests()
    {
        try
        {
            M(10);
        }
        catch (ArgumentException ex) when (ex.ParamName == "x")
        {
            await Assert.That(ex.ParamName).IsEqualTo("x");
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