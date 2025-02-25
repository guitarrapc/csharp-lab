```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **59.36 ns** |   **2.376 ns** |  **0.130 ns** |  **59.21 ns** |  **59.46 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.72 ns |   4.063 ns |  0.223 ns |  57.47 ns |  57.86 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.66 ns |  14.577 ns |  0.799 ns |  56.97 ns |  58.53 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.98 ns |   1.482 ns |  0.081 ns |  19.89 ns |  20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.03 ns |   3.262 ns |  0.179 ns |  19.90 ns |  20.23 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.93 ns |   1.014 ns |  0.056 ns |  19.90 ns |  20.00 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  62.08 ns |  15.318 ns |  0.840 ns |  61.25 ns |  62.93 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  58.55 ns |   8.083 ns |  0.443 ns |  58.09 ns |  58.97 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.05 ns |  12.077 ns |  0.662 ns |  56.31 ns |  57.57 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.97 ns |   0.176 ns |  0.010 ns |  19.96 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.26 ns |   2.129 ns |  0.117 ns |  20.15 ns |  20.38 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.25 ns |   1.018 ns |  0.056 ns |  19.21 ns |  19.31 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **175.96 ns** |  **63.249 ns** |  **3.467 ns** | **173.32 ns** | **179.89 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 179.97 ns | 220.970 ns | 12.112 ns | 172.27 ns | 193.93 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 171.26 ns |  18.548 ns |  1.017 ns | 170.58 ns | 172.43 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  60.13 ns |   4.176 ns |  0.229 ns |  59.89 ns |  60.35 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.62 ns |   4.057 ns |  0.222 ns |  58.46 ns |  58.87 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.15 ns |   3.635 ns |  0.199 ns |  57.99 ns |  58.37 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 167.74 ns |   8.512 ns |  0.467 ns | 167.24 ns | 168.17 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 171.04 ns |  14.378 ns |  0.788 ns | 170.50 ns | 171.94 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 171.90 ns |  29.630 ns |  1.624 ns | 170.30 ns | 173.55 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.38 ns |   3.222 ns |  0.177 ns |  59.27 ns |  59.59 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.45 ns |   7.223 ns |  0.396 ns |  59.20 ns |  59.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  59.79 ns |   3.323 ns |  0.182 ns |  59.62 ns |  59.98 ns |      - |         - |
