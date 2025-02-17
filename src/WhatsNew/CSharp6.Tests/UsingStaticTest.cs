// C#6 introduce using static. Now you can call static member without class.
using static System.Math;

namespace CSharp6.Tests;

public class UsingStaticTest
{
    [Fact]
    public void UsingStaticTests()
    {
        // C# 5
        Assert.Equal(4, Math.Pow(2, 2));

        // C# 6 can omit Math static class by `using static Math`.
        Assert.Equal(4, Pow(2, 2));
    }
}
