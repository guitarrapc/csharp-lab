```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **61.82 ns** |  **2.052 ns** | **0.112 ns** |  **61.69 ns** |  **61.89 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  62.75 ns |  9.684 ns | 0.531 ns |  62.21 ns |  63.27 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.76 ns | 40.413 ns | 2.215 ns |  57.48 ns |  61.32 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  20.00 ns |  3.892 ns | 0.213 ns |  19.87 ns |  20.25 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.90 ns |  0.725 ns | 0.040 ns |  19.87 ns |  19.94 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.78 ns |  9.319 ns | 0.511 ns |  19.24 ns |  20.26 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.34 ns | 10.398 ns | 0.570 ns |  56.77 ns |  57.91 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  59.86 ns | 28.642 ns | 1.570 ns |  58.68 ns |  61.64 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.34 ns |  5.412 ns | 0.297 ns |  57.07 ns |  57.66 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.84 ns |  0.157 ns | 0.009 ns |  19.83 ns |  19.85 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.16 ns |  1.604 ns | 0.088 ns |  20.06 ns |  20.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.21 ns |  0.061 ns | 0.003 ns |  19.20 ns |  19.21 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **176.85 ns** | **30.167 ns** | **1.654 ns** | **175.87 ns** | **178.76 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 174.64 ns |  5.408 ns | 0.296 ns | 174.34 ns | 174.93 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 178.75 ns | 16.205 ns | 0.888 ns | 178.06 ns | 179.75 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.73 ns |  2.978 ns | 0.163 ns |  59.55 ns |  59.84 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  59.24 ns |  1.821 ns | 0.100 ns |  59.16 ns |  59.35 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  59.39 ns |  0.076 ns | 0.004 ns |  59.38 ns |  59.39 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 170.67 ns | 23.920 ns | 1.311 ns | 169.27 ns | 171.86 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 171.96 ns | 19.728 ns | 1.081 ns | 171.04 ns | 173.15 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 176.24 ns |  8.632 ns | 0.473 ns | 175.73 ns | 176.67 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.37 ns |  0.329 ns | 0.018 ns |  59.35 ns |  59.39 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.16 ns |  2.083 ns | 0.114 ns |  59.09 ns |  59.29 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.62 ns | 50.499 ns | 2.768 ns |  57.01 ns |  61.81 ns |      - |         - |
