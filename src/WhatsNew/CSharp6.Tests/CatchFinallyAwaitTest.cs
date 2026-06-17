namespace CSharp6.Tests;

public class CatchFinallyAwaitTest
{
    [Test]
    public async Task CatchFinallyAwaitTests(CancellationToken cancellationToken)
    {
        var x = 0;
        using var cts = new CancellationTokenSource();
        cts.CancelAfter(TimeSpan.FromMilliseconds(10));
        try
        {
            await Task.Delay(100, cancellationToken);
            x++;
        }
        catch (OperationCanceledException)
        {
            await Task.Delay(100, cancellationToken);
            x++;
            await Assert.That(x).IsEqualTo(1);
        }
        finally
        {
            await Task.Delay(1, cancellationToken);
            x++;
            await Assert.That(x).IsEqualTo(2);
        }
    }
}
