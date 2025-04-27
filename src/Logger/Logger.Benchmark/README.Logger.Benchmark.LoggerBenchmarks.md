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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.62 ns** |  **5.490 ns** | **0.301 ns** |  **58.42 ns** |  **58.97 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.32 ns |  5.960 ns | 0.327 ns |  57.96 ns |  58.59 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  61.64 ns |  9.225 ns | 0.506 ns |  61.07 ns |  62.01 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.94 ns |  1.448 ns | 0.079 ns |  19.88 ns |  20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.98 ns |  0.564 ns | 0.031 ns |  19.95 ns |  20.01 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.26 ns |  0.206 ns | 0.011 ns |  19.25 ns |  19.27 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.96 ns |  2.497 ns | 0.137 ns |  56.80 ns |  57.05 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.22 ns | 12.368 ns | 0.678 ns |  56.51 ns |  57.86 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.11 ns | 10.173 ns | 0.558 ns |  56.71 ns |  57.75 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.96 ns |  1.805 ns | 0.099 ns |  19.87 ns |  20.07 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  19.92 ns |  0.839 ns | 0.046 ns |  19.88 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.60 ns | 10.038 ns | 0.550 ns |  19.26 ns |  20.23 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **174.34 ns** | **26.904 ns** | **1.475 ns** | **173.06 ns** | **175.95 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 173.35 ns | 38.273 ns | 2.098 ns | 171.45 ns | 175.60 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 176.60 ns | 18.875 ns | 1.035 ns | 175.42 ns | 177.30 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.54 ns |  0.209 ns | 0.011 ns |  59.53 ns |  59.55 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.68 ns |  3.067 ns | 0.168 ns |  58.57 ns |  58.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  59.17 ns |  0.370 ns | 0.020 ns |  59.16 ns |  59.20 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 167.53 ns | 16.646 ns | 0.912 ns | 166.64 ns | 168.46 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 172.60 ns | 30.561 ns | 1.675 ns | 170.67 ns | 173.67 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 171.29 ns | 35.967 ns | 1.971 ns | 170.11 ns | 173.56 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.06 ns |  1.603 ns | 0.088 ns |  58.98 ns |  59.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.28 ns |  2.655 ns | 0.146 ns |  59.15 ns |  59.43 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.40 ns |  9.680 ns | 0.531 ns |  57.07 ns |  58.01 ns |      - |         - |
