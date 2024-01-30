using Microsoft.Extensions.Logging;

namespace LoggerDefault;
public class FakeLoggerFactory : ILoggerFactory
{
    private readonly LogLevel _logLevel;

    public FakeLoggerFactory(LogLevel logLevel)
    {
        _logLevel = logLevel;
    }

    public void AddProvider(ILoggerProvider provider)
    {
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new FakeLogger(_logLevel);
    }

    public void Dispose()
    {
    }
}

public class FakeLogger : ILogger
{
    private readonly LogLevel _logLevel;

    public FakeLogger(LogLevel logLevel)
    {
        _logLevel = logLevel;
    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return NullDisposable.Instance;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return _logLevel <= logLevel;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
    }
}

public class NullDisposable : IDisposable
{
    public static readonly IDisposable Instance = new NullDisposable();

    NullDisposable()
    {

    }

    public void Dispose()
    {
    }
}
