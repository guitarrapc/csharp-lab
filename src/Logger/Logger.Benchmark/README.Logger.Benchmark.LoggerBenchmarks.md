```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.43 ns** | **25.029 ns** | **1.372 ns** |  **58.21 ns** |  **60.91 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.03 ns |  8.662 ns | 0.475 ns |  57.69 ns |  58.57 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.38 ns |  3.263 ns | 0.179 ns |  57.24 ns |  57.58 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  20.04 ns |  3.760 ns | 0.206 ns |  19.87 ns |  20.27 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.18 ns |  3.441 ns | 0.189 ns |  19.98 ns |  20.35 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.49 ns |  2.801 ns | 0.154 ns |  19.32 ns |  19.61 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.05 ns | 12.663 ns | 0.694 ns |  56.26 ns |  57.55 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.18 ns | 12.453 ns | 0.683 ns |  55.78 ns |  56.96 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.05 ns |  1.132 ns | 0.062 ns |  55.98 ns |  56.10 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.01 ns |  0.687 ns | 0.038 ns |  19.98 ns |  20.06 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.11 ns |  0.115 ns | 0.006 ns |  20.10 ns |  20.12 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.27 ns |  0.597 ns | 0.033 ns |  19.23 ns |  19.29 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **174.79 ns** |  **0.714 ns** | **0.039 ns** | **174.75 ns** | **174.82 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 172.96 ns | 10.404 ns | 0.570 ns | 172.53 ns | 173.60 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 171.68 ns |  4.566 ns | 0.250 ns | 171.41 ns | 171.90 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.25 ns |  2.057 ns | 0.113 ns |  59.17 ns |  59.38 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.60 ns |  2.778 ns | 0.152 ns |  58.51 ns |  58.78 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.11 ns |  3.277 ns | 0.180 ns |  57.93 ns |  58.29 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 166.41 ns | 14.405 ns | 0.790 ns | 165.51 ns | 166.99 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 168.31 ns | 17.964 ns | 0.985 ns | 167.23 ns | 169.15 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 170.06 ns | 20.024 ns | 1.098 ns | 168.93 ns | 171.12 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.44 ns |  5.154 ns | 0.282 ns |  59.27 ns |  59.76 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.35 ns |  2.828 ns | 0.155 ns |  59.25 ns |  59.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  59.60 ns |  1.766 ns | 0.097 ns |  59.53 ns |  59.71 ns |      - |         - |
