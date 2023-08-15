using BenchmarkDotNet.Attributes;
using LoggerDefault;
using Microsoft.Extensions.Logging;

namespace LoggerBenchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
public class Benchmarks
{
    private const string LogMessageWithPrameter = "This is a log message with paramters {First}, {Second}";

    // Use FakeLogger instead of NullLogger to measure LogLevel difference.
    private readonly ILoggerFactory _loggerFactory = new FakeLoggerFactory(LogLevel.Information);
    private readonly ILogger<Benchmarks> _logger;
    private readonly ILoggerAdapter<Benchmarks> _loggerAdapter;

    [Params(1, 10, 100)]
    public int Number { get; set; }

    public Benchmarks()
    {
        _logger = _loggerFactory.CreateLogger<Benchmarks>();
        _loggerAdapter = new LoggerAdapter<Benchmarks>(_logger);
    }

    [Benchmark]
    public void LogWithoutIfParams()
    {
        for (byte i = 0; i < Number; i++)
        {
            _logger.LogInformation(LogMessageWithPrameter, 100, 5640);
        }
    }

    [Benchmark]
    public void LogWithIfParams()
    {
        for (byte i = 0; i < Number; i++)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation(LogMessageWithPrameter, 100, 5640);
            }
        }
    }

    [Benchmark]
    public void LogAdapterWithoutIfParams()
    {
        for (byte i = 0; i < Number; i++)
        {
            _loggerAdapter.LogInformation(LogMessageWithPrameter, 100, 5640);
        }
    }

    [Benchmark]
    public void LogDefineWithoutIfParams()
    {
        for (byte i = 0; i < Number; i++)
        {
            _logger.LogDefineMessage(100, 5640);
        }
    }

    [Benchmark]
    public void LogSourceGenWithoutIfParams()
    {
        for (byte i = 0; i < Number; i++)
        {
            _logger.LogSourceGenMessage(100, 5640);
        }
    }

    [Benchmark]
    public void LogSourceGenSkipEnableCheckWithoutIfParams()
    {
        for (byte i = 0; i < Number; i++)
        {
            _logger.LogSourceGenMessageSkipEnableCheck(100, 5640);
        }
    }
}
