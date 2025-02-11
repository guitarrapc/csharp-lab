```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.51 ns** |  **7.312 ns** | **0.401 ns** |  **58.13 ns** |  **58.93 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.18 ns | 19.988 ns | 1.096 ns |  57.97 ns |  60.10 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  61.21 ns | 27.146 ns | 1.488 ns |  59.52 ns |  62.32 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.95 ns |  1.116 ns | 0.061 ns |  19.91 ns |  20.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.97 ns |  0.671 ns | 0.037 ns |  19.93 ns |  20.00 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.26 ns |  0.146 ns | 0.008 ns |  19.25 ns |  19.27 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.42 ns |  4.753 ns | 0.261 ns |  57.19 ns |  57.70 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.39 ns | 14.462 ns | 0.793 ns |  56.50 ns |  58.03 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.83 ns |  9.544 ns | 0.523 ns |  57.32 ns |  58.37 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.94 ns |  0.876 ns | 0.048 ns |  19.89 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.18 ns |  0.447 ns | 0.024 ns |  20.15 ns |  20.19 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.25 ns |  0.120 ns | 0.007 ns |  19.24 ns |  19.25 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **179.03 ns** |  **6.117 ns** | **0.335 ns** | **178.65 ns** | **179.28 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 175.49 ns | 46.388 ns | 2.543 ns | 173.83 ns | 178.41 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 174.67 ns | 41.954 ns | 2.300 ns | 172.75 ns | 177.22 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.49 ns |  4.916 ns | 0.269 ns |  59.24 ns |  59.78 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.61 ns |  1.952 ns | 0.107 ns |  58.53 ns |  58.73 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.32 ns |  0.800 ns | 0.044 ns |  57.27 ns |  57.36 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 171.22 ns | 31.601 ns | 1.732 ns | 170.06 ns | 173.21 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 175.37 ns | 41.728 ns | 2.287 ns | 173.97 ns | 178.01 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 174.67 ns |  8.901 ns | 0.488 ns | 174.11 ns | 174.97 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.55 ns |  2.697 ns | 0.148 ns |  59.39 ns |  59.67 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.11 ns |  0.484 ns | 0.027 ns |  59.08 ns |  59.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.65 ns |  0.243 ns | 0.013 ns |  58.64 ns |  58.66 ns |      - |         - |
