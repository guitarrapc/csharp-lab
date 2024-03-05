using Microsoft.Extensions.ObjectPool;
using System.Threading.Tasks.Sources;

namespace NonAllocs.Core;

// inspired: https://gist.github.com/itn3000/9ba6671c1b590ecf999404d964ad8839
public static class ValueTaskExtension
{
    public static ValueTask Delay(TimeSpan timeout, CancellationToken ct = default)
    {
        var vts = DelayValueTaskSource.Pool.Get();
        vts.Timeout = timeout;
        vts.Token = ct;
        vts.Reset();
        ThreadPool.UnsafeQueueUserWorkItem(vts, false);
        return new ValueTask(vts, vts.Version);
    }

    public static ValueTask Delay(int milliseconds, CancellationToken ct = default)
    {
        return Delay(TimeSpan.FromMilliseconds(milliseconds), ct);
    }
}

internal sealed class DelayValueTaskSource : IValueTaskSource, IThreadPoolWorkItem
{
    public static readonly ObjectPool<DelayValueTaskSource> Pool = ObjectPool.Create<DelayValueTaskSource>();
    public TimeSpan Timeout = TimeSpan.Zero;
    public CancellationToken Token;

    private ManualResetValueTaskSourceCore<bool> _source;

    public short Version => _source.Version;

    public void GetResult(short token)
    {
        try
        {
            _source.GetResult(token);
        }
        finally
        {
            Pool.Return(this);
        }
    }

    public ValueTaskSourceStatus GetStatus(short token)
    {
        var st = _source.GetStatus(token);
        return st;
    }

    public void OnCompleted(Action<object?> continuation, object? state, short token, ValueTaskSourceOnCompletedFlags flags)
    {
        _source.OnCompleted(continuation, state, token, flags);
    }

    public void SetResult()
    {
        _source.SetResult(true);
    }

    public void Reset()
    {
        _source.Reset();
    }

    public void Execute()
    {
        try
        {
            if (Token.CanBeCanceled)
            {
                if (Token.WaitHandle.WaitOne(Timeout))
                {
                    _source.SetException(new OperationCanceledException());
                    return;
                }
            }
            else
            {
                Thread.Sleep(Timeout);
            }
            SetResult();
        }
        catch (Exception e)
        {
            _source.SetException(e);
        }
    }
}
