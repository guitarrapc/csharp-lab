namespace CSharp6.Tests;

public class NameofTest
{
    public int Property { get; set; }
    private int _field = 0;

    // C#6 introduce nameof() operator, which can get namespace, class, member and local as constats.

    [Fact]
    public void NameofTests()
    {
        var local = 5;
        // Namespace
        Assert.Equal("CSharp6", nameof(CSharp6));
        // Class
        Assert.Equal("NameofTest", nameof(NameofTest));
        // Method
        Assert.Equal("NameofTests", nameof(NameofTests));
        // Field
        Assert.Equal ("_field", (nameof(_field)));
        // Property
        Assert.Equal("Property", nameof(Property));
        // Local
        Assert.Equal("local", nameof(local));
    }
}
