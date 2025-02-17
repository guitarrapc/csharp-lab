namespace CSharp6.Tests;

public class IndexInitializerTest
{
    [Fact]
    public void IndexInitializerTests()
    {
        // C#5
        var dic5 = new Dictionary<string, int>();
        dic5["one"] = 1;
        dic5["two"] = 2;

        // C#6 introduce ObjectInitialiser with indexer.
        var dic6 = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
        };
    }
}
