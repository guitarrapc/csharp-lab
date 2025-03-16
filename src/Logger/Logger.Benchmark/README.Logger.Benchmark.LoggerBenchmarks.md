```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **61.53 ns** |  **3.709 ns** | **0.203 ns** |  **61.34 ns** |  **61.75 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.25 ns | 10.156 ns | 0.557 ns |  57.65 ns |  58.75 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.67 ns |  6.142 ns | 0.337 ns |  58.43 ns |  59.05 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  20.13 ns |  3.166 ns | 0.174 ns |  20.02 ns |  20.33 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.98 ns |  0.886 ns | 0.049 ns |  19.95 ns |  20.04 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.32 ns |  0.990 ns | 0.054 ns |  19.27 ns |  19.38 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.84 ns |  1.953 ns | 0.107 ns |  56.75 ns |  56.96 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  55.99 ns |  1.031 ns | 0.057 ns |  55.93 ns |  56.04 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  56.55 ns |  1.367 ns | 0.075 ns |  56.49 ns |  56.64 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.99 ns |  0.391 ns | 0.021 ns |  19.98 ns |  20.01 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  19.93 ns |  1.177 ns | 0.065 ns |  19.89 ns |  20.01 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.23 ns |  0.167 ns | 0.009 ns |  19.22 ns |  19.24 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **175.19 ns** | **10.090 ns** | **0.553 ns** | **174.61 ns** | **175.71 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 173.88 ns |  7.872 ns | 0.432 ns | 173.51 ns | 174.35 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 171.00 ns |  4.836 ns | 0.265 ns | 170.72 ns | 171.24 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.57 ns |  2.760 ns | 0.151 ns |  59.44 ns |  59.73 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.54 ns |  0.976 ns | 0.054 ns |  58.51 ns |  58.61 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  60.00 ns |  1.238 ns | 0.068 ns |  59.94 ns |  60.08 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 166.34 ns | 17.227 ns | 0.944 ns | 165.61 ns | 167.41 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 167.02 ns |  0.623 ns | 0.034 ns | 167.00 ns | 167.06 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 168.75 ns | 12.812 ns | 0.702 ns | 168.09 ns | 169.49 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  60.04 ns | 12.969 ns | 0.711 ns |  59.23 ns |  60.55 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.25 ns |  1.713 ns | 0.094 ns |  58.17 ns |  58.35 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.14 ns |  2.257 ns | 0.124 ns |  58.00 ns |  58.24 ns |      - |         - |
