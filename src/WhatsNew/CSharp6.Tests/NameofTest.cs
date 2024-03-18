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
        nameof(CSharp6).Should().Be("CSharp6");
        // Class
        nameof(NameofTest).Should().Be("NameofTest");
        // Method
        nameof(NameofTests).Should().Be("NameofTests");
        // Field
        nameof(_field).Should().Be("_field");
        // Property
        nameof(Property).Should().Be("Property");
        // Local
        nameof(local).Should().Be("local");
    }
}
