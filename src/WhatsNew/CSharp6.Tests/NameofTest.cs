using System.Threading.Tasks;

namespace CSharp6.Tests;

public class NameofTest
{
    public int Property { get; set; }
    private int _field = 0;

    // C#6 introduce nameof() operator, which can get namespace, class, member and local as constats.

    [Test]
    public async Task NameofTests()
    {
        var local = 5;
        // Namespace
        await Assert.That(nameof(CSharp6)).IsEqualTo("CSharp6");
        // Class
        await Assert.That(nameof(NameofTest)).IsEqualTo("NameofTest");
        // Method
        await Assert.That(nameof(NameofTests)).IsEqualTo("NameofTests");
        // Field
        await Assert.That((nameof(_field))).IsEqualTo("_field");
        // Property
        await Assert.That(nameof(Property)).IsEqualTo("Property");
        // Local
        await Assert.That(nameof(local)).IsEqualTo("local");
    }
}