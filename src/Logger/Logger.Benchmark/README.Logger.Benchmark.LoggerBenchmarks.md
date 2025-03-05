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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.62 ns** |  **8.304 ns** | **0.455 ns** |  **59.21 ns** |  **60.11 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.14 ns |  8.669 ns | 0.475 ns |  57.81 ns |  58.69 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.68 ns |  7.466 ns | 0.409 ns |  58.21 ns |  58.93 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.91 ns |  0.894 ns | 0.049 ns |  19.88 ns |  19.97 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.98 ns |  0.663 ns | 0.036 ns |  19.94 ns |  20.01 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.58 ns |  3.629 ns | 0.199 ns |  19.36 ns |  19.73 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  58.34 ns |  9.802 ns | 0.537 ns |  57.73 ns |  58.75 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  56.68 ns |  5.753 ns | 0.315 ns |  56.37 ns |  57.00 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.25 ns |  8.075 ns | 0.443 ns |  56.76 ns |  57.62 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.99 ns |  0.095 ns | 0.005 ns |  19.99 ns |  20.00 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.15 ns |  0.439 ns | 0.024 ns |  20.13 ns |  20.17 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.38 ns |  1.775 ns | 0.097 ns |  19.29 ns |  19.48 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **175.83 ns** | **50.653 ns** | **2.776 ns** | **173.51 ns** | **178.91 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 174.56 ns | 26.967 ns | 1.478 ns | 173.63 ns | 176.27 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 176.58 ns | 15.173 ns | 0.832 ns | 175.95 ns | 177.52 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.49 ns |  3.872 ns | 0.212 ns |  59.26 ns |  59.69 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.60 ns |  0.622 ns | 0.034 ns |  58.57 ns |  58.64 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.46 ns |  3.136 ns | 0.172 ns |  57.36 ns |  57.66 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 166.82 ns |  4.080 ns | 0.224 ns | 166.57 ns | 166.99 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 172.36 ns | 37.414 ns | 2.051 ns | 170.77 ns | 174.68 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 175.07 ns |  9.265 ns | 0.508 ns | 174.55 ns | 175.57 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.40 ns |  1.811 ns | 0.099 ns |  59.29 ns |  59.47 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.29 ns |  2.728 ns | 0.150 ns |  58.18 ns |  58.46 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  56.97 ns |  0.454 ns | 0.025 ns |  56.95 ns |  56.99 ns |      - |         - |
