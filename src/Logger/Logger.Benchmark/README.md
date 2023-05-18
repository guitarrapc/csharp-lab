# LoggerBenchmark

Environment

```
// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1766 (21H2)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3
```


## LogInformation with LogLevel.Information


|                                     Method |     Mean |     Error |   StdDev |      Min |      Max |  Gen 0 | Allocated |
|------------------------------------------- |---------:|----------:|---------:|---------:|---------:|-------:|----------:|
|                         LogWithoutIfParams | 75.52 ns | 47.746 ns | 2.617 ns | 72.69 ns | 77.86 ns | 0.0105 |      88 B |
|                            LogWithIfParams | 76.77 ns | 62.543 ns | 3.428 ns | 73.30 ns | 80.16 ns | 0.0105 |      88 B |
|                  LogAdapterWithoutIfParams | 81.37 ns | 48.014 ns | 2.632 ns | 79.56 ns | 84.39 ns | 0.0105 |      88 B |
|                   LogDefineWithoutIfParams | 17.31 ns | 12.617 ns | 0.692 ns | 16.85 ns | 18.10 ns |      - |         - |
|                LogSourceGenWithoutIfParams | 16.01 ns |  2.047 ns | 0.112 ns | 15.94 ns | 16.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 14.20 ns |  3.352 ns | 0.184 ns | 13.99 ns | 14.35 ns |      - |         - |

## LogInformation with LogLevel.Warning

|                                     Method |      Mean |      Error |    StdDev |       Min |       Max |  Gen 0 | Allocated |
|------------------------------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
|                         LogWithoutIfParams | 74.774 ns | 39.8371 ns | 2.1836 ns | 72.305 ns | 76.450 ns | 0.0105 |      88 B |
|                            LogWithIfParams |  2.306 ns |  0.0197 ns | 0.0011 ns |  2.305 ns |  2.307 ns |      - |         - |
|                  LogAdapterWithoutIfParams | 10.487 ns |  6.7505 ns | 0.3700 ns | 10.060 ns | 10.706 ns |      - |         - |
|                   LogDefineWithoutIfParams |  3.840 ns |  0.8586 ns | 0.0471 ns |  3.791 ns |  3.884 ns |      - |         - |
|                LogSourceGenWithoutIfParams |  2.587 ns |  1.4816 ns | 0.0812 ns |  2.529 ns |  2.680 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | 13.852 ns |  0.3882 ns | 0.0213 ns | 13.834 ns | 13.876 ns |      - |         - |
