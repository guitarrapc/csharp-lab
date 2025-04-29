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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.49 ns** |  **3.957 ns** | **0.217 ns** |  **58.29 ns** |  **58.72 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.18 ns |  1.549 ns | 0.085 ns |  57.09 ns |  57.26 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  58.01 ns |  3.143 ns | 0.172 ns |  57.85 ns |  58.19 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.92 ns |  0.155 ns | 0.009 ns |  19.91 ns |  19.93 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.90 ns |  1.177 ns | 0.065 ns |  19.85 ns |  19.97 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.36 ns |  1.947 ns | 0.107 ns |  19.30 ns |  19.49 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.11 ns |  7.931 ns | 0.435 ns |  56.65 ns |  57.51 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.90 ns |  5.339 ns | 0.293 ns |  57.60 ns |  58.19 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.74 ns |  7.335 ns | 0.402 ns |  57.28 ns |  58.04 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.96 ns |  0.921 ns | 0.050 ns |  19.90 ns |  19.99 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.03 ns |  0.244 ns | 0.013 ns |  20.02 ns |  20.05 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.37 ns |  0.563 ns | 0.031 ns |  19.34 ns |  19.40 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **176.41 ns** | **19.496 ns** | **1.069 ns** | **175.43 ns** | **177.55 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 173.90 ns |  1.818 ns | 0.100 ns | 173.84 ns | 174.02 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 173.74 ns | 38.512 ns | 2.111 ns | 171.44 ns | 175.58 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.62 ns |  8.017 ns | 0.439 ns |  59.25 ns |  60.11 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.54 ns |  0.169 ns | 0.009 ns |  58.53 ns |  58.55 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.42 ns |  1.849 ns | 0.101 ns |  58.36 ns |  58.54 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 168.03 ns |  9.605 ns | 0.527 ns | 167.55 ns | 168.59 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 169.00 ns | 50.627 ns | 2.775 ns | 166.88 ns | 172.14 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 171.13 ns | 40.506 ns | 2.220 ns | 169.30 ns | 173.60 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.10 ns |  0.552 ns | 0.030 ns |  59.06 ns |  59.12 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.30 ns |  3.309 ns | 0.181 ns |  58.19 ns |  58.51 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.91 ns |  3.450 ns | 0.189 ns |  57.77 ns |  58.13 ns |      - |         - |
