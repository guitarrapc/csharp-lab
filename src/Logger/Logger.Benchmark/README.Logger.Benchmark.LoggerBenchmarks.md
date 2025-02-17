```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                                     | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **LogWithoutIfParams**                         | **.NET 8.0** | **1**      |  **60.28 ns** |  **2.373 ns** | **0.130 ns** |  **60.18 ns** |  **60.43 ns** | **0.0052** |      **88 B** |
| LogWithIfParams                            | .NET 8.0 | 1      |  59.50 ns | 11.309 ns | 0.620 ns |  58.89 ns |  60.13 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 1      |  61.24 ns | 33.879 ns | 1.857 ns |  60.07 ns |  63.38 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 1      |  19.93 ns |  0.738 ns | 0.040 ns |  19.91 ns |  19.98 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 1      |  20.38 ns | 13.894 ns | 0.762 ns |  19.91 ns |  21.26 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 1      |  19.35 ns |  0.640 ns | 0.035 ns |  19.32 ns |  19.38 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 1      |  57.09 ns |  4.786 ns | 0.262 ns |  56.79 ns |  57.28 ns | 0.0052 |      88 B |
| LogWithIfParams                            | .NET 9.0 | 1      |  58.60 ns |  4.623 ns | 0.253 ns |  58.33 ns |  58.83 ns | 0.0052 |      88 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 1      |  57.99 ns |  3.562 ns | 0.195 ns |  57.78 ns |  58.16 ns | 0.0052 |      88 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 1      |  19.95 ns |  1.869 ns | 0.102 ns |  19.85 ns |  20.05 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 1      |  20.13 ns |  0.797 ns | 0.044 ns |  20.10 ns |  20.18 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 1      |  19.61 ns | 10.638 ns | 0.583 ns |  19.27 ns |  20.29 ns |      - |         - |
| **LogWithoutIfParams**                         | **.NET 8.0** | **3**      | **178.34 ns** |  **8.515 ns** | **0.467 ns** | **177.96 ns** | **178.86 ns** | **0.0157** |     **264 B** |
| LogWithIfParams                            | .NET 8.0 | 3      | 176.83 ns |  5.650 ns | 0.310 ns | 176.60 ns | 177.18 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 8.0 | 3      | 179.91 ns | 14.894 ns | 0.816 ns | 178.99 ns | 180.55 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 8.0 | 3      |  59.54 ns |  0.092 ns | 0.005 ns |  59.53 ns |  59.54 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 8.0 | 3      |  58.78 ns |  6.834 ns | 0.375 ns |  58.56 ns |  59.21 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 8.0 | 3      |  58.41 ns |  7.936 ns | 0.435 ns |  58.06 ns |  58.90 ns |      - |         - |
| LogWithoutIfParams                         | .NET 9.0 | 3      | 171.49 ns | 26.196 ns | 1.436 ns | 169.83 ns | 172.36 ns | 0.0157 |     264 B |
| LogWithIfParams                            | .NET 9.0 | 3      | 174.41 ns | 24.927 ns | 1.366 ns | 173.37 ns | 175.96 ns | 0.0157 |     264 B |
| LogAdapterWithoutIfParams                  | .NET 9.0 | 3      | 176.89 ns | 32.441 ns | 1.778 ns | 174.85 ns | 178.11 ns | 0.0157 |     264 B |
| LogDefineWithoutIfParams                   | .NET 9.0 | 3      |  59.62 ns |  2.671 ns | 0.146 ns |  59.47 ns |  59.77 ns |      - |         - |
| LogSourceGenWithoutIfParams                | .NET 9.0 | 3      |  58.97 ns |  1.908 ns | 0.105 ns |  58.90 ns |  59.09 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams | .NET 9.0 | 3      |  59.48 ns |  5.721 ns | 0.314 ns |  59.25 ns |  59.84 ns |      - |         - |
