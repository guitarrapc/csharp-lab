```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.96 ns** |  **9.873 ns** | **0.541 ns** |  **59.44 ns** |  **60.52 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.72 ns |  2.597 ns | 0.142 ns |  58.55 ns |  58.82 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  59.08 ns | 16.660 ns | 0.913 ns |  58.55 ns |  60.14 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.90 ns |  0.393 ns | 0.022 ns |  19.88 ns |  19.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.99 ns |  1.091 ns | 0.060 ns |  19.95 ns |  20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.38 ns |  1.133 ns | 0.062 ns |  19.32 ns |  19.45 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  58.88 ns | 22.665 ns | 1.242 ns |  57.72 ns |  60.19 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  60.01 ns |  4.478 ns | 0.245 ns |  59.85 ns |  60.29 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.04 ns | 12.533 ns | 0.687 ns |  57.25 ns |  58.44 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.98 ns |  0.282 ns | 0.015 ns |  19.97 ns |  20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.30 ns |  4.098 ns | 0.225 ns |  20.04 ns |  20.44 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.28 ns |  0.199 ns | 0.011 ns |  19.27 ns |  19.29 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **177.05 ns** | **23.410 ns** | **1.283 ns** | **176.06 ns** | **178.50 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 171.10 ns |  7.492 ns | 0.411 ns | 170.82 ns | 171.57 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 172.26 ns | 49.302 ns | 2.702 ns | 170.42 ns | 175.36 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.92 ns |  1.016 ns | 0.056 ns |  59.88 ns |  59.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.76 ns |  0.483 ns | 0.026 ns |  58.73 ns |  58.78 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.76 ns |  5.829 ns | 0.320 ns |  57.52 ns |  58.12 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 170.09 ns | 70.682 ns | 3.874 ns | 166.45 ns | 174.16 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 169.47 ns |  6.549 ns | 0.359 ns | 169.23 ns | 169.89 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 170.39 ns | 16.938 ns | 0.928 ns | 169.77 ns | 171.46 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.47 ns |  6.109 ns | 0.335 ns |  59.21 ns |  59.84 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.12 ns |  1.016 ns | 0.056 ns |  59.07 ns |  59.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.04 ns |  0.616 ns | 0.034 ns |  58.00 ns |  58.07 ns |      - |         - |
