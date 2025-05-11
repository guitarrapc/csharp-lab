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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **62.15 ns** | **13.123 ns** | **0.719 ns** |  **61.49 ns** |  **62.92 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  58.99 ns |  7.778 ns | 0.426 ns |  58.68 ns |  59.48 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.36 ns |  3.526 ns | 0.193 ns |  58.21 ns |  58.58 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.93 ns |  1.319 ns | 0.072 ns |  19.89 ns |  20.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.94 ns |  1.005 ns | 0.055 ns |  19.87 ns |  19.98 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.31 ns |  0.152 ns | 0.008 ns |  19.30 ns |  19.32 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  56.72 ns |  4.802 ns | 0.263 ns |  56.44 ns |  56.97 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.36 ns |  3.419 ns | 0.187 ns |  57.16 ns |  57.53 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.69 ns |  9.178 ns | 0.503 ns |  58.13 ns |  59.11 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.94 ns |  0.242 ns | 0.013 ns |  19.93 ns |  19.96 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.08 ns |  1.617 ns | 0.089 ns |  20.03 ns |  20.19 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.26 ns |  0.214 ns | 0.012 ns |  19.25 ns |  19.27 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **183.51 ns** | **38.137 ns** | **2.090 ns** | **181.65 ns** | **185.77 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 172.83 ns |  7.532 ns | 0.413 ns | 172.37 ns | 173.15 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 176.59 ns | 99.688 ns | 5.464 ns | 172.27 ns | 182.74 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.33 ns |  1.451 ns | 0.080 ns |  59.28 ns |  59.42 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  59.14 ns |  0.850 ns | 0.047 ns |  59.09 ns |  59.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.03 ns |  0.741 ns | 0.041 ns |  57.99 ns |  58.07 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 177.07 ns | 11.372 ns | 0.623 ns | 176.39 ns | 177.62 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 172.70 ns | 12.205 ns | 0.669 ns | 171.94 ns | 173.19 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 170.24 ns | 21.584 ns | 1.183 ns | 169.46 ns | 171.60 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.72 ns |  2.090 ns | 0.115 ns |  59.65 ns |  59.85 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.82 ns |  0.709 ns | 0.039 ns |  58.79 ns |  58.86 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  56.96 ns |  0.860 ns | 0.047 ns |  56.91 ns |  57.01 ns |      - |         - |
