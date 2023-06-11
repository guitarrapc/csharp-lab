# Logger.Benchmark

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT
  ShortRun : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|                                     Method |      Mean |    Error |   StdDev |       Min |       Max |  Gen 0 | Allocated |
|------------------------------------------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
|                         LogWithoutIfParams | 140.21 ns | 4.630 ns | 0.254 ns | 140.04 ns | 140.50 ns | 0.0045 |      88 B |
|                            LogWithIfParams | 144.07 ns | 3.402 ns | 0.186 ns | 143.91 ns | 144.27 ns | 0.0045 |      88 B |
|                  LogAdapterWithoutIfParams | 151.65 ns | 6.164 ns | 0.338 ns | 151.28 ns | 151.93 ns | 0.0045 |      88 B |
|                   LogDefineWithoutIfParams |  29.46 ns | 0.267 ns | 0.015 ns |  29.45 ns |  29.47 ns |      - |         - |
|                LogSourceGenWithoutIfParams |  26.34 ns | 0.070 ns | 0.004 ns |  26.33 ns |  26.34 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |  21.74 ns | 0.101 ns | 0.006 ns |  21.73 ns |  21.74 ns |      - |         - |
