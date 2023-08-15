``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                     Method |      Mean |     Error |   StdDev |       Min |       Max |  Gen 0 | Allocated |
|------------------------------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
|                         LogWithoutIfParams | 158.55 ns | 52.270 ns | 2.865 ns | 155.52 ns | 161.21 ns | 0.0045 |      88 B |
|                            LogWithIfParams | 165.65 ns |  9.827 ns | 0.539 ns | 165.11 ns | 166.19 ns | 0.0045 |      88 B |
|                  LogAdapterWithoutIfParams | 178.14 ns | 26.573 ns | 1.457 ns | 176.87 ns | 179.73 ns | 0.0045 |      88 B |
|                   LogDefineWithoutIfParams |  36.73 ns |  3.124 ns | 0.171 ns |  36.63 ns |  36.93 ns |      - |         - |
|                LogSourceGenWithoutIfParams |  32.81 ns |  5.090 ns | 0.279 ns |  32.50 ns |  33.04 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |  26.88 ns |  1.142 ns | 0.063 ns |  26.80 ns |  26.91 ns |      - |         - |
