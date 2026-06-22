// C#6 introduce using static. Now you can call static member without class.
using static System.Math;

namespace CSharp6.Tests;

public class UsingStaticTest
{
    [Test]
    public async Task UsingStaticTests()
    {
        // C# 5
        await Assert.That(Math.Pow(2, 2)).IsEqualTo(4);

        // C# 6 can omit Math static class by `using static Math`.
        await Assert.That(Pow(2, 2)).IsEqualTo(4);
    }
}
