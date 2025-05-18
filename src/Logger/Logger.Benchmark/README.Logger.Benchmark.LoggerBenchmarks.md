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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **60.33 ns** |  **6.682 ns** | **0.366 ns** |  **59.93 ns** |  **60.66 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.32 ns | 21.692 ns | 1.189 ns |  57.60 ns |  59.69 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.39 ns | 12.172 ns | 0.667 ns |  57.67 ns |  58.99 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.88 ns |  0.260 ns | 0.014 ns |  19.87 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.00 ns |  0.360 ns | 0.020 ns |  19.98 ns |  20.02 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.40 ns |  3.157 ns | 0.173 ns |  19.29 ns |  19.60 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.61 ns |  6.121 ns | 0.336 ns |  56.27 ns |  56.94 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  63.79 ns | 22.337 ns | 1.224 ns |  62.37 ns |  64.51 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  68.91 ns | 25.607 ns | 1.404 ns |  67.40 ns |  70.17 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.88 ns |  0.145 ns | 0.008 ns |  19.87 ns |  19.88 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  19.90 ns |  0.076 ns | 0.004 ns |  19.90 ns |  19.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.26 ns |  0.705 ns | 0.039 ns |  19.21 ns |  19.28 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **177.66 ns** | **25.642 ns** | **1.406 ns** | **176.37 ns** | **179.16 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 179.70 ns | 69.734 ns | 3.822 ns | 175.31 ns | 182.27 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 171.59 ns | 13.998 ns | 0.767 ns | 171.03 ns | 172.47 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.28 ns |  2.767 ns | 0.152 ns |  59.17 ns |  59.45 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.68 ns |  5.189 ns | 0.284 ns |  58.47 ns |  59.01 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.06 ns |  0.749 ns | 0.041 ns |  58.02 ns |  58.11 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 170.93 ns | 32.368 ns | 1.774 ns | 169.83 ns | 172.98 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 183.28 ns | 71.502 ns | 3.919 ns | 178.93 ns | 186.55 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 170.08 ns | 18.023 ns | 0.988 ns | 168.99 ns | 170.91 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.93 ns |  0.900 ns | 0.049 ns |  59.90 ns |  59.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.07 ns |  0.226 ns | 0.012 ns |  59.06 ns |  59.08 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.71 ns |  1.018 ns | 0.056 ns |  57.67 ns |  57.78 ns |      - |         - |
