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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **58.90 ns** |  **8.023 ns** | **0.440 ns** |  **58.43 ns** |  **59.31 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  57.48 ns |  5.626 ns | 0.308 ns |  57.18 ns |  57.79 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  57.34 ns |  1.543 ns | 0.085 ns |  57.27 ns |  57.44 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.89 ns |  0.057 ns | 0.003 ns |  19.89 ns |  19.90 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.09 ns |  1.391 ns | 0.076 ns |  20.02 ns |  20.17 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.25 ns |  0.566 ns | 0.031 ns |  19.22 ns |  19.28 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  55.92 ns |  5.771 ns | 0.316 ns |  55.59 ns |  56.22 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  57.69 ns |  4.283 ns | 0.235 ns |  57.46 ns |  57.93 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  62.21 ns |  5.704 ns | 0.313 ns |  61.86 ns |  62.47 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  20.06 ns |  1.541 ns | 0.084 ns |  19.98 ns |  20.15 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  19.97 ns |  0.362 ns | 0.020 ns |  19.96 ns |  19.99 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.37 ns |  4.823 ns | 0.264 ns |  19.22 ns |  19.68 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **181.71 ns** |  **5.171 ns** | **0.283 ns** | **181.39 ns** | **181.92 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 170.68 ns |  4.785 ns | 0.262 ns | 170.44 ns | 170.96 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 175.35 ns | 16.701 ns | 0.915 ns | 174.53 ns | 176.33 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  60.47 ns |  0.412 ns | 0.023 ns |  60.44 ns |  60.49 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.71 ns |  3.262 ns | 0.179 ns |  58.61 ns |  58.92 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  60.12 ns |  3.918 ns | 0.215 ns |  59.98 ns |  60.37 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 165.63 ns | 10.813 ns | 0.593 ns | 165.21 ns | 166.31 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 166.56 ns |  9.667 ns | 0.530 ns | 166.04 ns | 167.10 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 170.82 ns | 14.551 ns | 0.798 ns | 170.04 ns | 171.64 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.50 ns |  5.652 ns | 0.310 ns |  59.30 ns |  59.85 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  59.25 ns |  3.619 ns | 0.198 ns |  59.13 ns |  59.48 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  57.04 ns |  0.238 ns | 0.013 ns |  57.02 ns |  57.05 ns |      - |         - |
