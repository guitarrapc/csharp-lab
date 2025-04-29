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
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **61.53 ns** |  **6.953 ns** | **0.381 ns** |  **61.31 ns** |  **61.97 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  60.93 ns |  7.269 ns | 0.398 ns |  60.58 ns |  61.36 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  60.94 ns |  7.929 ns | 0.435 ns |  60.67 ns |  61.44 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.94 ns |  1.268 ns | 0.070 ns |  19.89 ns |  20.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  19.90 ns |  0.116 ns | 0.006 ns |  19.90 ns |  19.91 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.33 ns |  2.052 ns | 0.112 ns |  19.27 ns |  19.46 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  59.45 ns | 10.526 ns | 0.577 ns |  59.11 ns |  60.12 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  60.01 ns |  8.497 ns | 0.466 ns |  59.48 ns |  60.32 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  58.44 ns |  5.365 ns | 0.294 ns |  58.14 ns |  58.73 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.93 ns |  1.378 ns | 0.076 ns |  19.88 ns |  20.02 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.20 ns |  4.144 ns | 0.227 ns |  19.96 ns |  20.42 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.31 ns |  1.460 ns | 0.080 ns |  19.24 ns |  19.40 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **186.95 ns** | **20.940 ns** | **1.148 ns** | **186.10 ns** | **188.26 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 182.34 ns |  7.410 ns | 0.406 ns | 182.08 ns | 182.80 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 182.56 ns | 16.091 ns | 0.882 ns | 181.80 ns | 183.53 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  60.06 ns |  4.140 ns | 0.227 ns |  59.90 ns |  60.32 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  59.22 ns | 23.144 ns | 1.269 ns |  58.48 ns |  60.68 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  59.39 ns |  3.009 ns | 0.165 ns |  59.29 ns |  59.58 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 176.19 ns |  7.386 ns | 0.405 ns | 175.89 ns | 176.65 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 198.27 ns | 20.813 ns | 1.141 ns | 197.44 ns | 199.57 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 179.94 ns | 24.430 ns | 1.339 ns | 178.86 ns | 181.44 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.06 ns |  3.795 ns | 0.208 ns |  58.93 ns |  59.30 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.90 ns |  3.656 ns | 0.200 ns |  58.78 ns |  59.13 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  59.15 ns |  1.815 ns | 0.100 ns |  59.09 ns |  59.27 ns |      - |         - |
