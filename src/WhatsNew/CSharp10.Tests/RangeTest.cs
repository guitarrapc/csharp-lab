using System.Threading.Tasks;

namespace CSharp10.Tests;

public class RangeTest
{
    [Test]
    public async Task Dotnet6_Range()
    {
        IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
        IEnumerable<int> taken = numbers.Take(2..4);
        await Assert.That(taken).IsEquivalentTo(new[] { 3, 4 });

        IEnumerable<int> taken2 = numbers.Take(..3);
        await Assert.That(taken2).IsEquivalentTo(new[] { 1, 2, 3 });

        IEnumerable<int> taken3 = numbers.Take(3..);
        await Assert.That(taken3).IsEquivalentTo(new[] { 4, 5 });
    }

    [Test]
    public async Task Dotnet5_NoRange()
    {
        IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
        IEnumerable<int> taken = numbers.Skip(2).Take(2);
        await Assert.That(taken).IsEquivalentTo(new[] { 3, 4 });

        IEnumerable<int> taken2 = numbers.Take(3);
        await Assert.That(taken2).IsEquivalentTo(new[] { 1, 2, 3 });

        IEnumerable<int> taken3 = numbers.Skip(3).Take(3);
        await Assert.That(taken3).IsEquivalentTo(new[] { 4, 5 });
    }
}