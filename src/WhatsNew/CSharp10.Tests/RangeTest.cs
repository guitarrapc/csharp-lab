namespace CSharp10.Tests;

public class RangeTest
{
    [Fact]
    public void Dotnet6_Range()
    {
        IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
        IEnumerable<int> taken = numbers.Take(2..4);
        taken.Should().BeEquivalentTo(new[] { 3, 4 });

        IEnumerable<int> taken2 = numbers.Take(..3);
        taken2.Should().BeEquivalentTo(new[] { 1, 2, 3 });

        IEnumerable<int> taken3 = numbers.Take(3..);
        taken3.Should().BeEquivalentTo(new[] { 4, 5 });
    }

    [Fact]
    public void Dotnet5_NoRange()
    {
        IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
        IEnumerable<int> taken = numbers.Skip(2).Take(2);
        taken.Should().BeEquivalentTo(new[] { 3, 4 });

        IEnumerable<int> taken2 = numbers.Take(3);
        taken2.Should().BeEquivalentTo(new[] { 1, 2, 3 });

        IEnumerable<int> taken3 = numbers.Skip(3).Take(3);
        taken3.Should().BeEquivalentTo(new[] { 4, 5 });
    }
}
