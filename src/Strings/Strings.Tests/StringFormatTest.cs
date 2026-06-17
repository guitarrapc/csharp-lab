using Strings.Core;
using System.Threading.Tasks;

namespace Strings.Tests;

public class StringFormatTest
{
    [Test]
    public async Task CompositeTest()
    {
        var formatter = new StringFormat();
        var datetime = DateTime.Now;
        await Assert.That(formatter.Composite(datetime, "foo", 100)).IsEqualTo($"{datetime:t}: Hello, foo! I'll give you 100 apples.");
    }

    [Test]
    public async Task FormatTest()
    {
        var formatter = new StringFormat();
        var datetime = DateTime.Now;
        await Assert.That(formatter.Format(datetime, "foo", 100)).IsEqualTo($"{datetime:t}: Hello, foo! I'll give you 100 apples.");
    }
}