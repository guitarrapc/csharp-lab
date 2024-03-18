namespace CSharp6.Tests;

public class CatchFinallyAwaitTest
{
    [Fact]
    public async Task CatchFinallyAwaitTests()
    {
        var x = 0;
        using (var cts = new CancellationTokenSource())
        {
            cts.CancelAfter(TimeSpan.FromMilliseconds(10));
            try
            {
                await Task.Delay(100);
                x++;
            }
            catch (OperationCanceledException e)
            {
                await Task.Delay(1);
                x++;
                x.Should().Be(1);
            }
            finally
            {
                await Task.Delay(1);
                x++;
                x.Should().Be(2);
            }
        }
    }
}
