# LoggerBenchmark.Benchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method |      Mean |      Error |   StdDev |       Min |       Max |  Gen 0 | Allocated |
|------------------------------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
|                         LogWithoutIfParams | 162.73 ns |   6.002 ns | 0.329 ns | 162.36 ns | 162.99 ns | 0.0033 |      88 B |
|                            LogWithIfParams | 178.70 ns | 173.699 ns | 9.521 ns | 168.58 ns | 187.48 ns | 0.0033 |      88 B |
|                  LogAdapterWithoutIfParams | 183.30 ns |  40.673 ns | 2.229 ns | 181.32 ns | 185.72 ns | 0.0033 |      88 B |
|                   LogDefineWithoutIfParams |  37.82 ns |  10.703 ns | 0.587 ns |  37.24 ns |  38.41 ns |      - |         - |
|                LogSourceGenWithoutIfParams |  32.50 ns |  11.830 ns | 0.648 ns |  31.81 ns |  33.09 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |  28.05 ns |  15.997 ns | 0.877 ns |  27.44 ns |  29.06 ns |      - |         - |
