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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **60.88 ns** |  **3.660 ns** | **0.201 ns** |  **60.65 ns** |  **61.02 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  61.02 ns |  4.758 ns | 0.261 ns |  60.83 ns |  61.32 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  59.75 ns | 12.382 ns | 0.679 ns |  58.99 ns |  60.30 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.94 ns |  1.408 ns | 0.077 ns |  19.89 ns |  20.03 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.90 ns |  0.456 ns | 0.025 ns |  19.88 ns |  19.93 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.30 ns |  0.839 ns | 0.046 ns |  19.25 ns |  19.34 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  59.05 ns |  6.787 ns | 0.372 ns |  58.63 ns |  59.34 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  59.08 ns |  3.650 ns | 0.200 ns |  58.86 ns |  59.26 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  60.68 ns |  6.297 ns | 0.345 ns |  60.30 ns |  60.98 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.99 ns |  2.345 ns | 0.129 ns |  19.91 ns |  20.14 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  19.94 ns |  1.913 ns | 0.105 ns |  19.87 ns |  20.06 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  20.17 ns | 11.735 ns | 0.643 ns |  19.46 ns |  20.72 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **184.23 ns** | **25.081 ns** | **1.375 ns** | **182.68 ns** | **185.30 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 176.34 ns | 17.108 ns | 0.938 ns | 175.31 ns | 177.15 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 180.04 ns | 11.507 ns | 0.631 ns | 179.32 ns | 180.45 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.50 ns |  0.239 ns | 0.013 ns |  59.49 ns |  59.52 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.68 ns |  4.215 ns | 0.231 ns |  58.54 ns |  58.94 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  57.30 ns |  0.554 ns | 0.030 ns |  57.28 ns |  57.34 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 177.04 ns | 75.332 ns | 4.129 ns | 174.15 ns | 181.77 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 176.45 ns | 18.077 ns | 0.991 ns | 175.81 ns | 177.59 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 177.82 ns | 27.124 ns | 1.487 ns | 176.24 ns | 179.19 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.37 ns |  3.326 ns | 0.182 ns |  59.22 ns |  59.57 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.42 ns |  3.141 ns | 0.172 ns |  58.22 ns |  58.53 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  58.08 ns |  1.871 ns | 0.103 ns |  57.96 ns |  58.15 ns |      - |         - |
