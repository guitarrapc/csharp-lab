```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **61.08 ns** | **21.435 ns** | **1.175 ns** |  **59.91 ns** |  **62.26 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.89 ns |  4.272 ns | 0.234 ns |  59.70 ns |  60.15 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  62.35 ns | 31.713 ns | 1.738 ns |  60.35 ns |  63.46 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.89 ns |  0.227 ns | 0.012 ns |  19.88 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.99 ns |  0.977 ns | 0.054 ns |  19.96 ns |  20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.31 ns |  2.461 ns | 0.135 ns |  19.23 ns |  19.47 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  58.18 ns |  8.357 ns | 0.458 ns |  57.67 ns |  58.55 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  59.39 ns | 20.566 ns | 1.127 ns |  58.12 ns |  60.26 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.38 ns | 14.994 ns | 0.822 ns |  57.56 ns |  59.20 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.96 ns |  2.232 ns | 0.122 ns |  19.86 ns |  20.10 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.46 ns |  7.011 ns | 0.384 ns |  20.02 ns |  20.69 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.70 ns |  9.606 ns | 0.527 ns |  19.28 ns |  20.29 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **180.53 ns** | **39.219 ns** | **2.150 ns** | **178.05 ns** | **181.79 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 178.61 ns |  5.711 ns | 0.313 ns | 178.41 ns | 178.97 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 177.48 ns | 18.828 ns | 1.032 ns | 176.46 ns | 178.52 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.20 ns |  0.268 ns | 0.015 ns |  59.19 ns |  59.21 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.52 ns |  0.371 ns | 0.020 ns |  58.50 ns |  58.54 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.49 ns |  0.639 ns | 0.035 ns |  57.45 ns |  57.52 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 173.88 ns | 21.072 ns | 1.155 ns | 172.85 ns | 175.13 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 176.18 ns | 19.817 ns | 1.086 ns | 175.04 ns | 177.20 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 181.62 ns | 25.196 ns | 1.381 ns | 180.11 ns | 182.81 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.24 ns |  0.153 ns | 0.008 ns |  59.23 ns |  59.25 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.72 ns |  2.789 ns | 0.153 ns |  58.62 ns |  58.89 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.01 ns |  0.940 ns | 0.052 ns |  57.97 ns |  58.07 ns |      - |         - |
