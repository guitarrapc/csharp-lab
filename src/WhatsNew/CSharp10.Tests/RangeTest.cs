namespace CSharp10.Tests;

public class RangeTest
{
    [Fact]
    public void Dotnet6_Range()
    {
        IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
        IEnumerable<int> taken = numbers.Take(2..4);
        Assert.Equivalent(new[] { 3, 4 }, taken);

        IEnumerable<int> taken2 = numbers.Take(..3);
        Assert.Equivalent(new[] { 1, 2, 3 }, taken2);

        IEnumerable<int> taken3 = numbers.Take(3..);
        Assert.Equivalent(new[] { 4, 5 }, taken3);
    }

    [Fact]
    public void Dotnet5_NoRange()
    {
        IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5 };
        IEnumerable<int> taken = numbers.Skip(2).Take(2);
        Assert.Equivalent(new[] { 3, 4 }, taken);

        IEnumerable<int> taken2 = numbers.Take(3);
        Assert.Equivalent(new[] { 1, 2, 3 }, taken2);

        IEnumerable<int> taken3 = numbers.Skip(3).Take(3);
        Assert.Equivalent(new[] { 4, 5 }, taken3);
    }
}
