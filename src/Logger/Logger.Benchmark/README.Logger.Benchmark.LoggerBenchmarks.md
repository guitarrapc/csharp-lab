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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.43 ns** |  **7.764 ns** | **0.426 ns** |  **57.94 ns** |  **58.71 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.52 ns |  9.063 ns | 0.497 ns |  57.20 ns |  58.09 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.81 ns | 12.578 ns | 0.689 ns |  57.33 ns |  58.60 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.89 ns |  0.212 ns | 0.012 ns |  19.88 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.89 ns |  0.231 ns | 0.013 ns |  19.88 ns |  19.90 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.51 ns |  5.196 ns | 0.285 ns |  19.24 ns |  19.81 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  55.98 ns |  6.611 ns | 0.362 ns |  55.62 ns |  56.35 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  58.98 ns |  4.467 ns | 0.245 ns |  58.78 ns |  59.25 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.31 ns |  7.953 ns | 0.436 ns |  56.82 ns |  57.65 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.01 ns |  0.598 ns | 0.033 ns |  19.98 ns |  20.04 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.15 ns |  0.406 ns | 0.022 ns |  20.12 ns |  20.16 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.34 ns |  2.015 ns | 0.110 ns |  19.24 ns |  19.45 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **174.66 ns** | **23.020 ns** | **1.262 ns** | **173.91 ns** | **176.12 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 171.48 ns |  6.891 ns | 0.378 ns | 171.18 ns | 171.91 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 169.69 ns | 10.896 ns | 0.597 ns | 169.03 ns | 170.18 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.67 ns |  2.895 ns | 0.159 ns |  59.49 ns |  59.77 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.62 ns |  2.188 ns | 0.120 ns |  58.50 ns |  58.74 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.43 ns |  0.371 ns | 0.020 ns |  58.41 ns |  58.45 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 167.73 ns |  8.572 ns | 0.470 ns | 167.26 ns | 168.20 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 168.65 ns | 37.744 ns | 2.069 ns | 166.27 ns | 169.97 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 174.33 ns | 39.809 ns | 2.182 ns | 172.46 ns | 176.73 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.33 ns |  1.447 ns | 0.079 ns |  59.28 ns |  59.43 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.53 ns |  2.252 ns | 0.123 ns |  58.46 ns |  58.68 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.91 ns |  1.689 ns | 0.093 ns |  57.85 ns |  58.02 ns |      - |         - |
